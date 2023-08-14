import { Text, View } from "./Themed";
import { useWalletConnectModal } from '@walletconnect/modal-react-native';
import { useEffect, useState } from "react";

const AccountBalance = () => {
    const [balances, setBalances] = useState<any>(null);
    const { address } = useWalletConnectModal();

    return (
        <View>
            {balances
                ? Object.keys(balances).map((key) => (
                      <Text>{`${key}: ${balances[key]}`}</Text>
                  ))
                : null}
        </View>
    );
};

export default AccountBalance;
