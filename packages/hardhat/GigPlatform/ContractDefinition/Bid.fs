namespace Hardhat.Contracts.GigPlatform.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type Bid() =
            [<Parameter("address", "bidder", 1)>]
            member val public Bidder = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "amount", 2)>]
            member val public Amount = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bool", "accepted", 3)>]
            member val public Accepted = Unchecked.defaultof<bool> with get, set
            [<Parameter("bool", "completed", 4)>]
            member val public Completed = Unchecked.defaultof<bool> with get, set
            [<Parameter("bool", "cancelled", 5)>]
            member val public Cancelled = Unchecked.defaultof<bool> with get, set
    

