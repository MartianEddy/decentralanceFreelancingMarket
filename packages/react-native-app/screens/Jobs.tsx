import React, { useContext, useLayoutEffect } from 'react';
import { Text, View } from 'react-native';
import { ThemeContext } from '../context/ThemeProvider';
import { useNavigation } from '@react-navigation/native';

const Jobs = () => {
 const { styles } = useContext(ThemeContext);

 const navigation = useNavigation();

 useLayoutEffect(() => {
   navigation.setOptions({
     headerShown: true,
   });
 }, []);
  

  return (
    <View>
      <Text >Jobs</Text>
    </View>
  );
};

export default Jobs;
