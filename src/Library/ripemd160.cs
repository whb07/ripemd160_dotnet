// 
//
// RIPEMD160.cs
//

namespace Crypto.RIPEMD
{

    [System.Runtime.InteropServices.ComVisible(true)]
    public abstract class RIPEMD160 : HashAlgorithm
    {
        //
        // public constructors
        //

        protected RIPEMD160()
        {
            HashSizeValue = 160;
        }


    }
}
