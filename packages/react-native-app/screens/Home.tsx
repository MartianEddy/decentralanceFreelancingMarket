import { useNavigation } from '@react-navigation/native';
import { Text, View } from '../components/Themed';
import { useContext, useLayoutEffect } from 'react';
import { SafeAreaView } from 'react-native-safe-area-context';
import { ThemeContext } from '../context/ThemeProvider';
// import { SafeAreaView } from 'react-native';

const Home = () => {
	    const { styles } = useContext(ThemeContext);

	const navigation = useNavigation();

	useLayoutEffect(() => {
		navigation.setOptions({
			headerShown: true,

		});
	}, []);

  return (
      <View style={styles.container}>
        <View>
          <Text>Home </Text>
        </View>
      </View>
  );
};

export default Home;
