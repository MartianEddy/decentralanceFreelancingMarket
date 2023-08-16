namespace Hardhat.Contracts.GigPlatform.ContractDefinition

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

    
    
    type GigPlatformDeployment(byteCode: string) =
        inherit ContractDeploymentMessage(byteCode)
        
        static let BYTECODE = "6080604052600080546001600160a01b03191673874069fa1eb16d44d622f2e0ca25eea172369bc117905534801561003657600080fd5b506127ad806100466000396000f3fe608060405234801561001057600080fd5b50600436106101165760003560e01c80635fc7692f116100a2578063995864ab11610071578063995864ab146102b5578063a59b2c6b146102d5578063ad6561ec146102e8578063c22c4f43146102fb578063f2f704141461032257600080fd5b80635fc7692f1461022257806379048ec1146102355780637b3c4baa146102485780638ed0836f1461029557600080fd5b80631af23a59116100e95780631af23a59146101af57806347e905b4146101c257806357635148146101ca5780635dc14088146101ea5780635ecb6ab1146101fd57600080fd5b806302e9d5e41461011b5780630623752614610130578063070aab391461014c5780631453812814610175575b600080fd5b61012e610129366004611f0e565b610335565b005b61013960055481565b6040519081526020015b60405180910390f35b61013961015a366004611f4c565b6001600160a01b031660009081526004602052604090205490565b610188610183366004611f6e565b610421565b604080516001600160a01b0390941684526020840192909252151590820152606001610143565b61012e6101bd366004611f98565b610470565b600554610139565b6101dd6101d8366004611f4c565b610725565b604051610143919061200a565b61012e6101f8366004611f0e565b610b6f565b61021061020b36600461210c565b610d9f565b60405161014396959493929190612125565b61012e61023036600461223c565b61114d565b61012e610243366004611f98565b611284565b61025b610256366004611f0e565b61137a565b604080516001600160a01b03909616865260208601949094529115159284019290925290151560608301521515608082015260a001610143565b6102a86102a3366004611f4c565b6113dc565b6040516101439190612328565b6101396102c3366004611f4c565b60046020526000908152604090205481565b6102a86102e3366004611f4c565b6116c8565b61012e6102f63660046123a5565b6119c4565b61030e61030936600461210c565b611aa1565b6040516101439897969594939291906123da565b61012e61033036600461246b565b611d95565b816005548111156103615760405162461bcd60e51b815260040161035890612561565b60405180910390fd5b60008381526001602090815260408083205460029092529091208054859285926001600160a01b03909116918390811061039d5761039d61258c565b60009182526020909120600390910201546001600160a01b0316146103d45760405162461bcd60e51b8152600401610358906125a2565b6000858152600260205260409020805460019190869081106103f8576103f861258c565b60009182526020909120600390910201600201805460ff19169115159190911790555050505050565b6003602052816000526040600020818154811061043d57600080fd5b60009182526020909120600390910201805460018201546002909201546001600160a01b03909116935090915060ff1683565b6001600160a01b03811660009081526003602052604090205482106104d75760405162461bcd60e51b815260206004820152601f60248201527f5472616e73616374696f6e20696e646578206f7574206f6620626f756e6473006044820152606401610358565b6001600160a01b03811660009081526003602052604090208054839081106105015761050161258c565b600091825260209091206002600390920201015460ff161561055e5760405162461bcd60e51b8152602060048201526016602482015275119d5b991cc8185b1c9958591e481c9958d95a5d995960521b6044820152606401610358565b6001600160a01b03811660009081526003602052604081208054849081106105885761058861258c565b9060005260206000209060030201905060008160010154116105fe5760405162461bcd60e51b815260206004820152602960248201527f5472616e73616374696f6e20616d6f756e74206d75737420626520677265617460448201526806572207468616e20360bc1b6064820152608401610358565b6001600160a01b03821660009081526003602052604090208054600191908590811061062c5761062c61258c565b60009182526020822060039190910201600201805460ff1916921515929092179091558154600183015491546040516323b872dd60e01b81526001600160a01b038681166004830152928316602482018190526044820185905293929091169081906323b872dd906064016020604051808303816000875af11580156106b6573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106da91906125e9565b61071d5760405162461bcd60e51b815260206004820152601460248201527318d554d1081d1c985b9cd9995c8819985a5b195960621b6044820152606401610358565b505050505050565b6001600160a01b0381166000908152600460205260408120546060918167ffffffffffffffff81111561075a5761075a612199565b6040519080825280602002602001820160405280156107dc57816020015b6107c960405180610100016040528060006001600160a01b03168152602001606081526020016000815260200160608152602001606081526020016060815260200160608152602001600081525090565b8152602001906001900390816107785790505b509050600060015b6005548111610b65576000818152600160205260409020546001600160a01b03808816911603610b53576000818152600160208181526040928390208351610100810190945280546001600160a01b031684529182018054918401916108499061260b565b80601f01602080910402602001604051908101604052809291908181526020018280546108759061260b565b80156108c25780601f10610897576101008083540402835291602001916108c2565b820191906000526020600020905b8154815290600101906020018083116108a557829003601f168201915b50505050508152602001600282015481526020016003820180546108e59061260b565b80601f01602080910402602001604051908101604052809291908181526020018280546109119061260b565b801561095e5780601f106109335761010080835404028352916020019161095e565b820191906000526020600020905b81548152906001019060200180831161094157829003601f168201915b505050505081526020016004820180546109779061260b565b80601f01602080910402602001604051908101604052809291908181526020018280546109a39061260b565b80156109f05780601f106109c5576101008083540402835291602001916109f0565b820191906000526020600020905b8154815290600101906020018083116109d357829003601f168201915b50505050508152602001600582018054610a099061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054610a359061260b565b8015610a825780601f10610a5757610100808354040283529160200191610a82565b820191906000526020600020905b815481529060010190602001808311610a6557829003601f168201915b50505050508152602001600682018054610a9b9061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054610ac79061260b565b8015610b145780601f10610ae957610100808354040283529160200191610b14565b820191906000526020600020905b815481529060010190602001808311610af757829003601f168201915b50505050508152602001600782015481525050838381518110610b3957610b3961258c565b60200260200101819052508180610b4f90612645565b9250505b80610b5d81612645565b9150506107e4565b5090949350505050565b6000828152600260205260409020805482908110610b8f57610b8f61258c565b600091825260209091206002600390920201015460ff16610be55760405162461bcd60e51b815260206004820152601060248201526f109a59081b9bdd081858d8d95c1d195960821b6044820152606401610358565b6000828152600260205260409020805482908110610c0557610c0561258c565b906000526020600020906003020160020160019054906101000a900460ff1615610c695760405162461bcd60e51b8152602060048201526015602482015274109a5908185b1c9958591e4818dbdb5c1b195d1959605a1b6044820152606401610358565b6000828152600260205260408120805483908110610c8957610c8961258c565b6000918252602080832060039092029091015485835260029091526040822080546001600160a01b0390921693509084908110610cc857610cc861258c565b600091825260208083206003928302016001908101546001600160a01b03878116808752858552604080882081516060810183529283528287018581528383018a815282548089018455928b52888b2094519290990290930180546001600160a01b0319169190941617835590518285015594516002918201805460ff1916911515919091179055898652909252919092208054929350909185908110610d7157610d7161258c565b906000526020600020906003020160020160016101000a81548160ff02191690831515021790555050505050565b60606000606080606080600087118015610dbb57506005548711155b610dff5760405162461bcd60e51b8152602060048201526015602482015274092dcecc2d8d2c840e6cae4ecd2c6ca40d2dcc8caf605b1b6044820152606401610358565b60008781526001602081815260408084208151610100810190925280546001600160a01b031682529283018054919392840191610e3b9061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054610e679061260b565b8015610eb45780601f10610e8957610100808354040283529160200191610eb4565b820191906000526020600020905b815481529060010190602001808311610e9757829003601f168201915b5050505050815260200160028201548152602001600382018054610ed79061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054610f039061260b565b8015610f505780601f10610f2557610100808354040283529160200191610f50565b820191906000526020600020905b815481529060010190602001808311610f3357829003601f168201915b50505050508152602001600482018054610f699061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054610f959061260b565b8015610fe25780601f10610fb757610100808354040283529160200191610fe2565b820191906000526020600020905b815481529060010190602001808311610fc557829003601f168201915b50505050508152602001600582018054610ffb9061260b565b80601f01602080910402602001604051908101604052809291908181526020018280546110279061260b565b80156110745780601f1061104957610100808354040283529160200191611074565b820191906000526020600020905b81548152906001019060200180831161105757829003601f168201915b5050505050815260200160068201805461108d9061260b565b80601f01602080910402602001604051908101604052809291908181526020018280546110b99061260b565b80156111065780601f106110db57610100808354040283529160200191611106565b820191906000526020600020905b8154815290600101906020018083116110e957829003601f168201915b505050918352505060079190910154602091820152810151604082015160a083015160c08401516060850151608090950151939d929c50909a509850919650945092505050565b6005805490600061115d83612645565b909155505060408051610100810182526001600160a01b03838116825260208083018b81528385018b9052606084018a90526080840189905260a0840188905260c08401879052600060e08501819052600554815260019283905294909420835181546001600160a01b0319169316929092178255925191929091908201906111e690826126b7565b50604082015160028201556060820151600382019061120590826126b7565b506080820151600482019061121a90826126b7565b5060a0820151600582019061122f90826126b7565b5060c0820151600682019061124490826126b7565b5060e091909101516007909101556001600160a01b038116600090815260046020526040812080549161127683612645565b919050555050505050505050565b816005548111156112a75760405162461bcd60e51b815260040161035890612561565b600083815260016020526040902054839083906001600160a01b038083169116146112e45760405162461bcd60e51b8152600401610358906125a2565b6000858152600160208190526040822080546001600160a01b0319168155919061131090830182611e63565b60028201600090556003820160006113289190611e63565b611336600483016000611e63565b611344600583016000611e63565b611352600683016000611e63565b50600060079190910181905585815260026020526040812061137391611ea0565b5050505050565b6002602052816000526040600020818154811061139657600080fd5b60009182526020909120600390910201805460018201546002909201546001600160a01b03909116935090915060ff808216916101008104821691620100009091041685565b6060600060015b60055481116114c35760005b6000828152600260205260409020548110156114b05760008281526002602052604090208054829081106114255761142561258c565b600091825260209091206002600390920201015460ff16801561148b5750600082815260026020526040902080546001600160a01b03871691908390811061146f5761146f61258c565b60009182526020909120600390910201546001600160a01b0316145b1561149e578261149a81612645565b9350505b806114a881612645565b9150506113ef565b50806114bb81612645565b9150506113e3565b5060008167ffffffffffffffff8111156114df576114df612199565b60405190808252806020026020018201604052801561153857816020015b6040805160a0810182526000808252602080830182905292820181905260608201819052608082015282526000199092019101816114fd5790505b509050600060015b6005548111610b655760005b6000828152600260205260409020548110156116b55760008281526002602052604090208054829081106115825761158261258c565b600091825260209091206002600390920201015460ff1680156115e85750600082815260026020526040902080546001600160a01b0389169190839081106115cc576115cc61258c565b60009182526020909120600390910201546001600160a01b0316145b156116a357600082815260026020526040902080548290811061160d5761160d61258c565b60009182526020918290206040805160a081018252600390930290910180546001600160a01b0316835260018101549383019390935260029092015460ff80821615159383019390935261010081048316151560608301526201000090049091161515608082015284518590859081106116895761168961258c565b6020026020010181905250828061169f90612645565b9350505b806116ad81612645565b91505061154c565b50806116c081612645565b915050611540565b6060600060015b60055481116117b75760005b6000828152600260205260409020548110156117a45760008281526002602052604090208054829081106117115761171161258c565b906000526020600020906003020160020160019054906101000a900460ff16801561177f5750600082815260026020526040902080546001600160a01b0387169190839081106117635761176361258c565b60009182526020909120600390910201546001600160a01b0316145b15611792578261178e81612645565b9350505b8061179c81612645565b9150506116db565b50806117af81612645565b9150506116cf565b5060008167ffffffffffffffff8111156117d3576117d3612199565b60405190808252806020026020018201604052801561182c57816020015b6040805160a0810182526000808252602080830182905292820181905260608201819052608082015282526000199092019101816117f15790505b509050600060015b6005548111610b655760005b6000828152600260205260409020548110156119b15760008281526002602052604090208054829081106118765761187661258c565b906000526020600020906003020160020160019054906101000a900460ff1680156118e45750600082815260026020526040902080546001600160a01b0389169190839081106118c8576118c861258c565b60009182526020909120600390910201546001600160a01b0316145b1561199f5760008281526002602052604090208054829081106119095761190961258c565b60009182526020918290206040805160a081018252600390930290910180546001600160a01b0316835260018101549383019390935260029092015460ff80821615159383019390935261010081048316151560608301526201000090049091161515608082015284518590859081106119855761198561258c565b6020026020010181905250828061199b90612645565b9350505b806119a981612645565b915050611840565b50806119bc81612645565b915050611834565b826005548111156119e75760405162461bcd60e51b815260040161035890612561565b506000928352600260208181526040808620815160a0810183526001600160a01b0395861681528084019687529182018781526060830188815260808401898152835460018082018655948b52959099209351600390950290930180546001600160a01b0319169490961693909317855594519484019490945551910180549251935161ffff1990931691151561ff00191691909117610100931515939093029290921762ff000019166201000091151591909102179055565b6001602081905260009182526040909120805491810180546001600160a01b0390931692611ace9061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054611afa9061260b565b8015611b475780601f10611b1c57610100808354040283529160200191611b47565b820191906000526020600020905b815481529060010190602001808311611b2a57829003601f168201915b505050505090806002015490806003018054611b629061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054611b8e9061260b565b8015611bdb5780601f10611bb057610100808354040283529160200191611bdb565b820191906000526020600020905b815481529060010190602001808311611bbe57829003601f168201915b505050505090806004018054611bf09061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054611c1c9061260b565b8015611c695780601f10611c3e57610100808354040283529160200191611c69565b820191906000526020600020905b815481529060010190602001808311611c4c57829003601f168201915b505050505090806005018054611c7e9061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054611caa9061260b565b8015611cf75780601f10611ccc57610100808354040283529160200191611cf7565b820191906000526020600020905b815481529060010190602001808311611cda57829003601f168201915b505050505090806006018054611d0c9061260b565b80601f0160208091040260200160405190810160405280929190818152602001828054611d389061260b565b8015611d855780601f10611d5a57610100808354040283529160200191611d85565b820191906000526020600020905b815481529060010190602001808311611d6857829003601f168201915b5050505050908060070154905088565b600087815260016020526040902054879089906001600160a01b03808316911614611dd25760405162461bcd60e51b8152600401610358906125a2565b600554891115611df45760405162461bcd60e51b815260040161035890612561565b6000898152600160208190526040909120908101611e128a826126b7565b506002810188905560058101611e2888826126b7565b5060068101611e3787826126b7565b5060068101611e4686826126b7565b5060068101611e5585826126b7565b505050505050505050505050565b508054611e6f9061260b565b6000825580601f10611e7f575050565b601f016020900490600052602060002090810190611e9d9190611ec1565b50565b5080546000825560030290600052602060002090810190611e9d9190611eda565b5b80821115611ed65760008155600101611ec2565b5090565b5b80821115611ed65780546001600160a01b03191681556000600182015560028101805462ffffff19169055600301611edb565b60008060408385031215611f2157600080fd5b50508035926020909101359150565b80356001600160a01b0381168114611f4757600080fd5b919050565b600060208284031215611f5e57600080fd5b611f6782611f30565b9392505050565b60008060408385031215611f8157600080fd5b611f8a83611f30565b946020939093013593505050565b60008060408385031215611fab57600080fd5b82359150611fbb60208401611f30565b90509250929050565b6000815180845260005b81811015611fea57602081850181015186830182015201611fce565b506000602082860101526020601f19601f83011685010191505092915050565b60006020808301818452808551808352604092508286019150828160051b87010184880160005b838110156120fe57888303603f19018552815180516001600160a01b0316845261010088820151818a87015261206982870182611fc4565b91505087820151888601526060808301518683038288015261208b8382611fc4565b92505050608080830151868303828801526120a68382611fc4565b9250505060a080830151868303828801526120c18382611fc4565b9250505060c080830151868303828801526120dc8382611fc4565b60e0948501519790940196909652505094870194925090860190600101612031565b509098975050505050505050565b60006020828403121561211e57600080fd5b5035919050565b60c08152600061213860c0830189611fc4565b87602084015282810360408401526121508188611fc4565b905082810360608401526121648187611fc4565b905082810360808401526121788186611fc4565b905082810360a084015261218c8185611fc4565b9998505050505050505050565b634e487b7160e01b600052604160045260246000fd5b600082601f8301126121c057600080fd5b813567ffffffffffffffff808211156121db576121db612199565b604051601f8301601f19908116603f0116810190828211818310171561220357612203612199565b8160405283815286602085880101111561221c57600080fd5b836020870160208301376000602085830101528094505050505092915050565b600080600080600080600060e0888a03121561225757600080fd5b873567ffffffffffffffff8082111561226f57600080fd5b61227b8b838c016121af565b985060208a0135975060408a013591508082111561229857600080fd5b6122a48b838c016121af565b965060608a01359150808211156122ba57600080fd5b6122c68b838c016121af565b955060808a01359150808211156122dc57600080fd5b6122e88b838c016121af565b945060a08a01359150808211156122fe57600080fd5b5061230b8a828b016121af565b92505061231a60c08901611f30565b905092959891949750929550565b602080825282518282018190526000919060409081850190868401855b8281101561239857815180516001600160a01b0316855286810151878601528581015115158686015260608082015115159086015260809081015115159085015260a09093019290850190600101612345565b5091979650505050505050565b6000806000606084860312156123ba57600080fd5b83359250602084013591506123d160408501611f30565b90509250925092565b6001600160a01b0389168152610100602082018190526000906123ff8382018b611fc4565b905088604084015282810360608401526124198189611fc4565b9050828103608084015261242d8188611fc4565b905082810360a08401526124418187611fc4565b905082810360c08401526124558186611fc4565b9150508260e08301529998505050505050505050565b600080600080600080600080610100898b03121561248857600080fd5b61249189611f30565b975060208901359650604089013567ffffffffffffffff808211156124b557600080fd5b6124c18c838d016121af565b975060608b0135965060808b01359150808211156124de57600080fd5b6124ea8c838d016121af565b955060a08b013591508082111561250057600080fd5b61250c8c838d016121af565b945060c08b013591508082111561252257600080fd5b61252e8c838d016121af565b935060e08b013591508082111561254457600080fd5b506125518b828c016121af565b9150509295985092959890939650565b60208082526011908201527014d95c9d9a58d9481b9bdd08199bdd5b99607a1b604082015260600190565b634e487b7160e01b600052603260045260246000fd5b60208082526027908201527f4f6e6c79206a6f6220706f737465722063616e20706572666f726d20746869736040820152661030b1ba34b7b760c91b606082015260800190565b6000602082840312156125fb57600080fd5b81518015158114611f6757600080fd5b600181811c9082168061261f57607f821691505b60208210810361263f57634e487b7160e01b600052602260045260246000fd5b50919050565b60006001820161266557634e487b7160e01b600052601160045260246000fd5b5060010190565b601f8211156126b257600081815260208120601f850160051c810160208610156126935750805b601f850160051c820191505b8181101561071d5782815560010161269f565b505050565b815167ffffffffffffffff8111156126d1576126d1612199565b6126e5816126df845461260b565b8461266c565b602080601f83116001811461271a57600084156127025750858301515b600019600386901b1c1916600185901b17855561071d565b600085815260208120601f198616915b828110156127495788860151825594840194600190910190840161272a565b50858210156127675787850151600019600388901b60f8161c191681555b5050505050600190811b0190555056fea2646970667358221220fb6f65593261a83a779bb4d206548f167efd35e5d2737e44d539f6b56ff4063264736f6c63430008130033"
        
        new() = GigPlatformDeployment(BYTECODE)
        

        
    
    [<Function("acceptBid")>]
    type AcceptBidFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "_serviceId", 1)>]
            member val public ServiceId = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "_bidIndex", 2)>]
            member val public BidIndex = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("bids", typeof<BidsOutputDTO>)>]
    type BidsFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("completeBid")>]
    type CompleteBidFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "_serviceId", 1)>]
            member val public ServiceId = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "_bidIndex", 2)>]
            member val public BidIndex = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("createService")>]
    type CreateServiceFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("string", "_image", 1)>]
            member val public Image = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "_price", 2)>]
            member val public Price = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("string", "_title", 3)>]
            member val public Title = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "_description", 4)>]
            member val public Description = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "_category", 5)>]
            member val public Category = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "_subCategory", 6)>]
            member val public SubCategory = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "_userAddress", 7)>]
            member val public UserAddress = Unchecked.defaultof<string> with get, set
        
    
    [<Function("deleteService")>]
    type DeleteServiceFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "_serviceId", 1)>]
            member val public ServiceId = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("address", "_userAddress", 2)>]
            member val public UserAddress = Unchecked.defaultof<string> with get, set
        
    
    [<Function("getAcceptedBidsForUser", typeof<GetAcceptedBidsForUserOutputDTO>)>]
    type GetAcceptedBidsForUserFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_user", 1)>]
            member val public User = Unchecked.defaultof<string> with get, set
        
    
    [<Function("getCompletedBidsForUser", typeof<GetCompletedBidsForUserOutputDTO>)>]
    type GetCompletedBidsForUserFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_user", 1)>]
            member val public User = Unchecked.defaultof<string> with get, set
        
    
    [<Function("getTotalServiceCount", "uint256")>]
    type GetTotalServiceCountFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("getUserServiceCount", "uint256")>]
    type GetUserServiceCountFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_user", 1)>]
            member val public User = Unchecked.defaultof<string> with get, set
        
    
    [<Function("getUserServices", typeof<GetUserServicesOutputDTO>)>]
    type GetUserServicesFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_userAddress", 1)>]
            member val public UserAddress = Unchecked.defaultof<string> with get, set
        
    
    [<Function("placeBid")>]
    type PlaceBidFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "_serviceId", 1)>]
            member val public ServiceId = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "_amount", 2)>]
            member val public Amount = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("address", "_userAddress", 3)>]
            member val public UserAddress = Unchecked.defaultof<string> with get, set
        
    
    [<Function("readService", typeof<ReadServiceOutputDTO>)>]
    type ReadServiceFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "_index", 1)>]
            member val public Index = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("releaseFunds")>]
    type ReleaseFundsFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "_transactionIndex", 1)>]
            member val public TransactionIndex = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("address", "_userAddress", 2)>]
            member val public UserAddress = Unchecked.defaultof<string> with get, set
        
    
    [<Function("serviceCount", "uint256")>]
    type ServiceCountFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("services", typeof<ServicesOutputDTO>)>]
    type ServicesFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("transactions", typeof<TransactionsOutputDTO>)>]
    type TransactionsFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("updateService")>]
    type UpdateServiceFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_userAddress", 1)>]
            member val public UserAddress = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "_serviceId", 2)>]
            member val public ServiceId = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("string", "_image", 3)>]
            member val public Image = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "_price", 4)>]
            member val public Price = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("string", "_title", 5)>]
            member val public Title = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "_description", 6)>]
            member val public Description = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "_category", 7)>]
            member val public Category = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "_subCategory", 8)>]
            member val public SubCategory = Unchecked.defaultof<string> with get, set
        
    
    [<Function("userToServiceCount", "uint256")>]
    type UserToServiceCountFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    
    
    [<FunctionOutput>]
    type BidsOutputDTO() =
        inherit FunctionOutputDTO() 
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
        
    
    
    
    
    
    
    
    [<FunctionOutput>]
    type GetAcceptedBidsForUserOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("tuple[]", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<List<Bid>> with get, set
        
    
    [<FunctionOutput>]
    type GetCompletedBidsForUserOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("tuple[]", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<List<Bid>> with get, set
        
    
    [<FunctionOutput>]
    type GetTotalServiceCountOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type GetUserServiceCountOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type GetUserServicesOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("tuple[]", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<List<Service>> with get, set
        
    
    
    
    [<FunctionOutput>]
    type ReadServiceOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("string", "image", 1)>]
            member val public Image = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "price", 2)>]
            member val public Price = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("string", "title", 3)>]
            member val public Title = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "description", 4)>]
            member val public Description = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "category", 5)>]
            member val public Category = Unchecked.defaultof<string> with get, set
            [<Parameter("string", "subCategory", 6)>]
            member val public SubCategory = Unchecked.defaultof<string> with get, set
        
    
    
    
    [<FunctionOutput>]
    type ServiceCountOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type ServicesOutputDTO() =
        inherit FunctionOutputDTO() 
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
        
    
    [<FunctionOutput>]
    type TransactionsOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("address", "user", 1)>]
            member val public User = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "amount", 2)>]
            member val public Amount = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bool", "received", 3)>]
            member val public Received = Unchecked.defaultof<bool> with get, set
        
    
    
    
    [<FunctionOutput>]
    type UserToServiceCountOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
    

