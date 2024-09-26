namespace Hardhat.Contracts.IERC20Token.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts
open System.Threading

    
    
    type IERC20TokenDeployment(byteCode: string) =
        inherit ContractDeploymentMessage(byteCode)
        
        static let BYTECODE = ""
        
        new() = IERC20TokenDeployment(BYTECODE)
        

        
    
    [<Function("allowance", "uint256")>]
    type AllowanceFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<string> with get, set
        
    
    [<Function("approve", "bool")>]
    type ApproveFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("balanceOf", "uint256")>]
    type BalanceOfFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<Function("totalSupply", "uint256")>]
    type TotalSupplyFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("transfer", "bool")>]
    type TransferFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("transferFrom", "bool")>]
    type TransferFromFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "", 3)>]
            member val public ReturnValue3 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Event("Approval")>]
    type ApprovalEventDTO() =
        inherit EventDTO()
            [<Parameter("address", "owner", 1, true )>]
            member val Owner = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "spender", 2, true )>]
            member val Spender = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "value", 3, false )>]
            member val Value = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Event("Transfer")>]
    type TransferEventDTO() =
        inherit EventDTO()
            [<Parameter("address", "from", 1, true )>]
            member val From = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "to", 2, true )>]
            member val To = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "value", 3, false )>]
            member val Value = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type AllowanceOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    
    
    [<FunctionOutput>]
    type BalanceOfOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type TotalSupplyOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    
    


