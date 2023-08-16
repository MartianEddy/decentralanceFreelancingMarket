namespace Hardhat.Contracts.GigPlatform

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts.ContractHandlers
open Nethereum.Contracts
open System.Threading
open Hardhat.Contracts.GigPlatform.ContractDefinition


    type GigPlatformService (web3: Web3, contractAddress: string) =
    
        member val Web3 = web3 with get
        member val ContractHandler = web3.Eth.GetContractHandler(contractAddress) with get
    
        static member DeployContractAndWaitForReceiptAsync(web3: Web3, gigPlatformDeployment: GigPlatformDeployment, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> = 
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            web3.Eth.GetContractDeploymentHandler<GigPlatformDeployment>().SendRequestAndWaitForReceiptAsync(gigPlatformDeployment, cancellationTokenSourceVal)
        
        static member DeployContractAsync(web3: Web3, gigPlatformDeployment: GigPlatformDeployment): Task<string> =
            web3.Eth.GetContractDeploymentHandler<GigPlatformDeployment>().SendRequestAsync(gigPlatformDeployment)
        
        static member DeployContractAndGetServiceAsync(web3: Web3, gigPlatformDeployment: GigPlatformDeployment, ?cancellationTokenSource : CancellationTokenSource) = async {
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            let! receipt = GigPlatformService.DeployContractAndWaitForReceiptAsync(web3, gigPlatformDeployment, cancellationTokenSourceVal) |> Async.AwaitTask
            return new GigPlatformService(web3, receipt.ContractAddress);
            }
    
        member this.AcceptBidRequestAsync(acceptBidFunction: AcceptBidFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(acceptBidFunction);
        
        member this.AcceptBidRequestAndWaitForReceiptAsync(acceptBidFunction: AcceptBidFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(acceptBidFunction, cancellationTokenSourceVal);
        
        member this.BidsQueryAsync(bidsFunction: BidsFunction, ?blockParameter: BlockParameter): Task<BidsOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<BidsFunction, BidsOutputDTO>(bidsFunction, blockParameterVal)
            
        member this.CompleteBidRequestAsync(completeBidFunction: CompleteBidFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(completeBidFunction);
        
        member this.CompleteBidRequestAndWaitForReceiptAsync(completeBidFunction: CompleteBidFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(completeBidFunction, cancellationTokenSourceVal);
        
        member this.CreateServiceRequestAsync(createServiceFunction: CreateServiceFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(createServiceFunction);
        
        member this.CreateServiceRequestAndWaitForReceiptAsync(createServiceFunction: CreateServiceFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(createServiceFunction, cancellationTokenSourceVal);
        
        member this.DeleteServiceRequestAsync(deleteServiceFunction: DeleteServiceFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(deleteServiceFunction);
        
        member this.DeleteServiceRequestAndWaitForReceiptAsync(deleteServiceFunction: DeleteServiceFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(deleteServiceFunction, cancellationTokenSourceVal);
        
        member this.GetAcceptedBidsForUserQueryAsync(getAcceptedBidsForUserFunction: GetAcceptedBidsForUserFunction, ?blockParameter: BlockParameter): Task<GetAcceptedBidsForUserOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<GetAcceptedBidsForUserFunction, GetAcceptedBidsForUserOutputDTO>(getAcceptedBidsForUserFunction, blockParameterVal)
            
        member this.GetCompletedBidsForUserQueryAsync(getCompletedBidsForUserFunction: GetCompletedBidsForUserFunction, ?blockParameter: BlockParameter): Task<GetCompletedBidsForUserOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<GetCompletedBidsForUserFunction, GetCompletedBidsForUserOutputDTO>(getCompletedBidsForUserFunction, blockParameterVal)
            
        member this.GetTotalServiceCountQueryAsync(getTotalServiceCountFunction: GetTotalServiceCountFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetTotalServiceCountFunction, BigInteger>(getTotalServiceCountFunction, blockParameterVal)
            
        member this.GetUserServiceCountQueryAsync(getUserServiceCountFunction: GetUserServiceCountFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetUserServiceCountFunction, BigInteger>(getUserServiceCountFunction, blockParameterVal)
            
        member this.GetUserServicesQueryAsync(getUserServicesFunction: GetUserServicesFunction, ?blockParameter: BlockParameter): Task<GetUserServicesOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<GetUserServicesFunction, GetUserServicesOutputDTO>(getUserServicesFunction, blockParameterVal)
            
        member this.PlaceBidRequestAsync(placeBidFunction: PlaceBidFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(placeBidFunction);
        
        member this.PlaceBidRequestAndWaitForReceiptAsync(placeBidFunction: PlaceBidFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(placeBidFunction, cancellationTokenSourceVal);
        
        member this.ReadServiceQueryAsync(readServiceFunction: ReadServiceFunction, ?blockParameter: BlockParameter): Task<ReadServiceOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<ReadServiceFunction, ReadServiceOutputDTO>(readServiceFunction, blockParameterVal)
            
        member this.ReleaseFundsRequestAsync(releaseFundsFunction: ReleaseFundsFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(releaseFundsFunction);
        
        member this.ReleaseFundsRequestAndWaitForReceiptAsync(releaseFundsFunction: ReleaseFundsFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(releaseFundsFunction, cancellationTokenSourceVal);
        
        member this.ServiceCountQueryAsync(serviceCountFunction: ServiceCountFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<ServiceCountFunction, BigInteger>(serviceCountFunction, blockParameterVal)
            
        member this.ServicesQueryAsync(servicesFunction: ServicesFunction, ?blockParameter: BlockParameter): Task<ServicesOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<ServicesFunction, ServicesOutputDTO>(servicesFunction, blockParameterVal)
            
        member this.TransactionsQueryAsync(transactionsFunction: TransactionsFunction, ?blockParameter: BlockParameter): Task<TransactionsOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<TransactionsFunction, TransactionsOutputDTO>(transactionsFunction, blockParameterVal)
            
        member this.UpdateServiceRequestAsync(updateServiceFunction: UpdateServiceFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(updateServiceFunction);
        
        member this.UpdateServiceRequestAndWaitForReceiptAsync(updateServiceFunction: UpdateServiceFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(updateServiceFunction, cancellationTokenSourceVal);
        
        member this.UserToServiceCountQueryAsync(userToServiceCountFunction: UserToServiceCountFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<UserToServiceCountFunction, BigInteger>(userToServiceCountFunction, blockParameterVal)
            
    

