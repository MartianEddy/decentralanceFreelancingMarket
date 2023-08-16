const { ethers } = require('hardhat');

async function main() {
  // Load the GigPlatform contract artifacts
  const GigPlatformFactory = await ethers.getContractFactory(
    'GigPlatform'
  );

  // Deploy the contract
  const GigPlatformContract = await GigPlatformFactory.deploy();

  // Wait for deployment to finish
  await GigPlatformContract.deployed();

  // Log the address of the new contract
  console.log('GigPlatform Details deployed to:', GigPlatformContract.address);
}

main()
  .then(() => process.exit(0))
  .catch((error) => {
    console.error(error);
    process.exit(1);
  });
