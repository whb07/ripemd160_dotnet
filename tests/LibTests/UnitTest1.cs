using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Crypto.RIPEMD;


namespace LibTests

{
    public class UnitTest1
    {
        // TEST VECTORS FROM https://homes.esat.kuleuven.be/~bosselae/ripemd160.html 
        private static readonly Dictionary<string, string> RIPEMD160Vectors
            = new Dictionary<string, string>
        {
            { "", "9c1185a5c5e9fc54612808977ee8f548b2258d31" },
            { "a", "0bdc9d2d256b3ee9daae347be6f4dc835a467ffe" },
            { "abc", "8eb208f7e05d987a9b044a8e98c6b087f15a0bfc" },
            { "message digest", "5d0689ef49d2fae572b881b123a85ffa21595f36" },
            { "abcdefghijklmnopqrstuvwxyz", "f71c27109c692c1b56bbdceb5b9d2865b3708dbc" },
            { "abcdbcdecdefdefgefghfghighijhijkijkljklmklmnlmnomnopnopq", "12a053384a9c0c88e405a06c27dcf49ada62eb2b" },
            { "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", "b0e20b6e3116640286ed3a87a5713079b21f5189" },
        };

        [Fact]
        public void TestBytesToHexString()
        {
            var rip = new RIPEMD160Managed();
            var hash = rip.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes("Hello World!"));
            Assert.Equal("8476ee4631b9b30ac2754b0ee0c47e161d3f724c", rip.bytesToHexString(hash));
        }

        [Fact]
        public void TestVectors()
        {
            var rip = new RIPEMD160Managed();
            foreach (KeyValuePair<string, string> item in RIPEMD160Vectors)
            {
                Assert.Equal(item.Value, rip.bytesToHexString(rip.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(item.Key))));
            }
            // last two special cases
            // repeat the string 8 times
            string eightimes = String.Concat(Enumerable.Repeat("1234567890", 8));
            Assert.Equal("9b752e45573d4b39f4dbd3323cab82bf63326bfb", rip.bytesToHexString(rip.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(eightimes))));
            // repeat the string 1 million times
            string onemillion = String.Concat(Enumerable.Repeat("a", 1000000));
            Assert.Equal("52783243c1697bdbe16d37f97f68f08325dc1528", rip.bytesToHexString(rip.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(onemillion))));

        }
    }
}
