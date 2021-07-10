
# RIPEMD160

RIPEMD160 is the .NET copy/paste code from their .NET Framework source. For whatever reason it appears that they removed this particular algorithm for the .NETCORE/.NET

For more info take a look at the canonical version:

https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.ripemd160managed

## Install
Nuget link: https://www.nuget.org/packages/Crypto.RIPEMD/

```shell
$ dotnet add package Crypto.RIPEMD --version 1.0.3
```


## Tests
```shell
$ dotnet test
```

## Usage

```fsharp
// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Crypto.RIPEMD // <-- this is the library


[<EntryPoint>]
let main argv =
    let hashValue = RIPEMD160Managed.HashInString "Hello World!"
    printfn "Hash is %s" hashValue
    // compare against known ripemd160 value
    assert ("8476ee4631b9b30ac2754b0ee0c47e161d3f724c" = hashValue) |> ignore
    0 // return an integer exit code
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.


## License
[MIT](https://choosealicense.com/licenses/mit/)