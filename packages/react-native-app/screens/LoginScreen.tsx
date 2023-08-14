import { Pressable, StyleSheet, Text } from "react-native";
import { RootStackScreenProps } from "../types";
import { View } from "../components/Themed";
import {
  useWalletConnectModal,
} from '@walletconnect/modal-react-native';


export default function LoginScreen({
    navigation,
}: RootStackScreenProps<"Root">) {
		  const { open, isConnected } = useWalletConnectModal();

    return (
      <View style={styles.container}>
        <Pressable onPress={open}>
          <Text>{isConnected ? 'View Account' : 'Connect'}</Text>
        </Pressable>
      </View>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        alignItems: "center",
        justifyContent: "center",
    },
    title: {
        fontSize: 20,
        fontWeight: "bold",
    },
});
