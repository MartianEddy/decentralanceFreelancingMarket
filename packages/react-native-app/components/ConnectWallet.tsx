import { useWalletConnectModal } from '@walletconnect/modal-react-native';
import Button from './Button';
import { Text } from './Themed';
import { Pressable } from 'react-native';

const ConnectWallet = () => {
  const { provider, isConnected } = useWalletConnectModal();
  
  return (
    <Pressable onPress={open}>
      <Text>{isConnected ? 'View Account' : 'Connect'}</Text>
    </Pressable>
  );
};

export default ConnectWallet;
