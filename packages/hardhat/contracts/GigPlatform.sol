// SPDX-License-Identifier: GPL-3.0

pragma solidity >=0.8.2 <0.9.0;

interface IERC20Token {
    function transfer(address, uint256) external returns (bool);

    function approve(address, uint256) external returns (bool);

    function transferFrom(address, address, uint256) external returns (bool);

    function totalSupply() external view returns (uint256);

    function balanceOf(address) external view returns (uint256);

    function allowance(address, address) external view returns (uint256);

    event Transfer(address indexed from, address indexed to, uint256 value);
    event Approval(
        address indexed owner,
        address indexed spender,
        uint256 value
    );
}

contract GigPlatform {
    address internal cUsdTokenAddress =
        0x874069Fa1Eb16D44d622F2e0Ca25eeA172369bC1;

    struct Service {
        address jobPoster;
        string image;
        uint256 price;
        string category;
        string subCategory;
        string title;
        string description;
        uint256 rating;
    }

    struct Bid {
        address bidder;
        uint256 amount;
        bool accepted;
        bool completed;
        bool cancelled;
    }

    struct Transaction {
        address user;
        uint256 amount;
        bool received;
    }

    mapping(uint256 => Service) public services;
    mapping(uint256 => Bid[]) public bids;
    mapping(address => Transaction[]) public transactions;
    mapping(address => uint256) public userToServiceCount;

    uint256 public serviceCount;

    modifier serviceExists(uint256 _serviceId) {
        require(_serviceId <= serviceCount, "Service not found");
        _;
    }

    modifier onlyJobPoster(uint256 _serviceId, uint256 _bidIndex) {
        require(
            bids[_serviceId][_bidIndex].bidder ==
                services[_serviceId].jobPoster,
            "Only job poster can perform this action"
        );
        _;
    }

    modifier onlyServiceJobPoster(uint256 _serviceId, address _userAddress) {
        require(
            services[_serviceId].jobPoster == _userAddress,
            "Only job poster can perform this action"
        );
        _;
    }

    function createService(
        string memory _image,
        uint256 _price,
        string memory _title,
        string memory _description,
        string memory _category,
        string memory _subCategory,
        address _userAddress
    ) external {
        serviceCount++;
        services[serviceCount] = Service(
            _userAddress,
            _image,
            _price,
            _title,
            _description,
            _category,
            _subCategory,
            0
        );
        userToServiceCount[_userAddress]++;
    }

    function readService(
        uint256 _index
    )
        external
        view
        returns (
            string memory image,
            uint256 price,
            string memory title,
            string memory description,
            string memory category,
            string memory subCategory
        )
    {
        require(_index > 0 && _index <= serviceCount, "Invalid service index");

        Service memory service = services[_index];
        return (
            service.image,
            service.price,
            service.title,
            service.description,
            service.category,
            service.subCategory
        );
    }

    function getUserServices(
        address _userAddress
    ) external view returns (Service[] memory) {
        uint256 userServicesCount = userToServiceCount[_userAddress];
        Service[] memory userServices = new Service[](userServicesCount);
        uint256 currentIndex = 0;

        for (uint256 i = 1; i <= serviceCount; i++) {
            if (services[i].jobPoster == _userAddress) {
                userServices[currentIndex] = services[i];
                currentIndex++;
            }
        }

        return userServices;
    }

    function updateService(
        address _userAddress,
        uint256 _serviceId,
        string memory _image,
        uint256 _price,
        string memory _title,
        string memory _description,
        string memory _category,
        string memory _subCategory
    ) external onlyServiceJobPoster(_serviceId, _userAddress) {
        require(_serviceId <= serviceCount, "Service not found");

        Service storage service = services[_serviceId];
        service.image = _image;
        service.price = _price;
        service.title = _title;
        service.description = _description;
        service.description = _category;
        service.description = _subCategory;
    }

    function deleteService(
        uint256 _serviceId,
        address _userAddress
    )
        external
        serviceExists(_serviceId)
        onlyServiceJobPoster(_serviceId, _userAddress)
    {
        // Delete service and associated bids
        delete services[_serviceId];
        delete bids[_serviceId];
    }

    function placeBid(
        uint256 _serviceId,
        uint256 _amount,
        address _userAddress
    ) external serviceExists(_serviceId) {
        bids[_serviceId].push(Bid(_userAddress, _amount, false, false, false));
    }

    function acceptBid(
        uint256 _serviceId,
        uint256 _bidIndex
    ) external serviceExists(_serviceId) onlyJobPoster(_serviceId, _bidIndex) {
        bids[_serviceId][_bidIndex].accepted = true;
    }

    function getAcceptedBidsForUser(address _user) external view returns (Bid[] memory) {
        uint256 userAcceptedBidsCount = 0;

        // Count the user's accepted bids
        for (uint256 i = 1; i <= serviceCount; i++) {
            for (uint256 j = 0; j < bids[i].length; j++) {
                if (bids[i][j].accepted && bids[i][j].bidder == _user) {
                    userAcceptedBidsCount++;
                }
            }
        }

        Bid[] memory userAcceptedBids = new Bid[](userAcceptedBidsCount);
        uint256 currentIndex = 0;

        // Fetch the user's accepted bids
        for (uint256 i = 1; i <= serviceCount; i++) {
            for (uint256 j = 0; j < bids[i].length; j++) {
                if (bids[i][j].accepted && bids[i][j].bidder == _user) {
                    userAcceptedBids[currentIndex] = bids[i][j];
                    currentIndex++;
                }
            }
        }

        return userAcceptedBids;
    }


    function completeBid(uint256 _serviceId, uint256 _bidIndex) external {
        require(bids[_serviceId][_bidIndex].accepted, "Bid not accepted");
        require(
            !bids[_serviceId][_bidIndex].completed,
            "Bid already completed"
        );

        address jobBidder = bids[_serviceId][_bidIndex].bidder;
        uint256 amount = bids[_serviceId][_bidIndex].amount;
        transactions[jobBidder].push(Transaction(jobBidder, amount, false));
        bids[_serviceId][_bidIndex].completed = true;
    }

	function getCompletedBidsForUser(address _user) external view returns (Bid[] memory) {
        uint256 userCompletedBidsCount = 0;

        // Count the user's completed bids
        for (uint256 i = 1; i <= serviceCount; i++) {
            for (uint256 j = 0; j < bids[i].length; j++) {
                if (bids[i][j].completed && bids[i][j].bidder == _user) {
                    userCompletedBidsCount++;
                }
            }
        }

        Bid[] memory userCompletedBids = new Bid[](userCompletedBidsCount);
        uint256 currentIndex = 0;

        // Fetch the user's completed bids
        for (uint256 i = 1; i <= serviceCount; i++) {
            for (uint256 j = 0; j < bids[i].length; j++) {
                if (bids[i][j].completed && bids[i][j].bidder == _user) {
                    userCompletedBids[currentIndex] = bids[i][j];
                    currentIndex++;
                }
            }
        }

        return userCompletedBids;
    }

    function releaseFunds(
        uint256 _transactionIndex,
        address _userAddress
    ) external {
        require(
            _transactionIndex < transactions[_userAddress].length,
            "Transaction index out of bounds"
        );
        require(
            !transactions[_userAddress][_transactionIndex].received,
            "Funds already received"
        );

        Transaction storage transaction = transactions[_userAddress][
            _transactionIndex
        ];
        require(
            transaction.amount > 0,
            "Transaction amount must be greater than 0"
        );

        transactions[_userAddress][_transactionIndex].received = true;

        address jobBidder = transaction.user;
        uint256 amount = transaction.amount;

        // Transfer cUSD tokens from job poster to job bidder
        IERC20Token cUsdToken = IERC20Token(cUsdTokenAddress);
        require(
            cUsdToken.transferFrom(_userAddress, jobBidder, amount),
            "cUSD transfer failed"
        );
    }

    function getTotalServiceCount() external view returns (uint256) {
        return serviceCount;
    }

    function getUserServiceCount(
        address _user
    ) external view returns (uint256) {
        return userToServiceCount[_user];
    }
}
