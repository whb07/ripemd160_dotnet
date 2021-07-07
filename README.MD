
# RIPEMD160

RIPEMD160 is the .NET copy/paste code from their .NET Framework source. For whatever reason it appears that they removed this particular algorithm for the .NETCORE/.NET

For more info take a look at the canonical version:

https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.ripemd160managed

## Usage

```fsharp
// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Crypto.RIPEMD // <-- this is the library


let bytesToHexString bytes =
    let text = BitConverter.ToString bytes
    text.Split("-")
    |> Array.map (fun x -> x.ToLower())
    |> String.Concat


[<EntryPoint>]
let main argv =
    let rip = new RIPEMD160Managed()
    let hashValue = bytesToHexString (rip.ComputeHash(Text.ASCIIEncoding.ASCII.GetBytes "Hello World!"))
    printfn "Hello world %A" hashValue
    assert ("8476ee4631b9b30ac2754b0ee0c47e161d3f724c" = hashValue) |> ignore
    0
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.


## License
[MIT](https://choosealicense.com/licenses/mit/)