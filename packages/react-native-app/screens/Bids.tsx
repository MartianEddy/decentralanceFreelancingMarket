import { View, Text } from 'react-native'
import React, { useContext, useLayoutEffect } from 'react'
import { ThemeContext } from '../context/ThemeProvider';
import { useNavigation } from '@react-navigation/native';

const Bids = () => {
	  const { styles } = useContext(ThemeContext);

     const navigation = useNavigation();

     useLayoutEffect(() => {
       navigation.setOptions({
         headerShown: true,
       });
     }, []);


  return (
	<View style={styles.container}>
	  <Text>Bids</Text>
	</View>
  )
}

export default Bids