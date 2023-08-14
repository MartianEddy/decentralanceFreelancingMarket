import { useContext } from "react";
import { ThemeContext } from "../context/ThemeProvider";
import { Text } from "./Themed";
import { useWalletConnectModal } from '@walletconnect/modal-react-native';

const AccountAddress = () => {
    const { styles } = useContext(ThemeContext);
    const { address } = useWalletConnectModal();

    return <Text style={styles.externalLink}>{address}</Text>;
};

export default AccountAddress;
