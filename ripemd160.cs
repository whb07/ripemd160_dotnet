// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
// <OWNER>Microsoft</OWNER>
// 

//
// RIPEMD160.cs
//

namespace Crypto.RIPEMD
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    

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
