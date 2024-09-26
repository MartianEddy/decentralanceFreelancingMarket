import { useState, useEffect, useContext, useLayoutEffect } from "react";
import { Text, View } from "../components/Themed";
import Button from "../components/Button";
import * as WebBrowser from "expo-web-browser";
import { ThemeContext } from "../context/ThemeProvider";
import AccountAddress from "../components/AccountAddress";
import AccountBalance from "../components/AccountBalance";
import Colors from "../constants/Colors";
import { useWalletConnectModal } from '@walletconnect/modal-react-native';
import { BlockchainActions } from "../components/BlockchainActions";
import { useNavigation } from "@react-navigation/native";

export default function Profile() {
    const { address, provider } = useWalletConnectModal();
    const { styles } = useContext(ThemeContext);
    const [accountLink, setAccountLink] = useState("");


   const navigation = useNavigation();

   useLayoutEffect(() => {
     navigation.setOptions({
       headerShown: true,
     });
   }, []);


    useEffect(() => {
        setAccountLink(`https://celoscan.io/address/${address}`);
    }, [address]);

    function handlePress() {
        WebBrowser.openBrowserAsync(accountLink);
    }

    return (
        <View>
            <View >
                <Text style={styles.title}>Connected As:</Text>
                <Button style={styles.externalLink} onPress={handlePress}>
                    <AccountAddress />
                    <AccountBalance />
                </Button>
                {/* <BlockchainActions /> */}
            </View>
            <Button onPress={() => provider?.disconnect()}>
                <Text style={{ color: Colors.brand.snow }}>
                    Disconnect Wallet
                </Text>
            </Button>
        </View>
    );
}
