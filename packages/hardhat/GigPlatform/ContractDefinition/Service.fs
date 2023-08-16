namespace Hardhat.Contracts.GigPlatform.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type Service() =
            [<Parameter("address", "jobPoster", 1)>]
            member val public JobPoster = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "image", 2)>]
            member val public Image = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "price", 3)>]
            member val public Price = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("string", "category", 4)>]
            member val public Category = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "subCategory", 5)>]
            member val public SubCategory = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "title", 6)>]
            member val public Title = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "description", 7)>]
            member val public Description = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "rating", 8)>]
            member val public Rating = Unchecked.defaultof<BigInteger> with get, set
    

