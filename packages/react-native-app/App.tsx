import React from 'react';
import { StatusBar } from 'expo-status-bar';
import { SafeAreaProvider } from 'react-native-safe-area-context';
import { useEffect } from 'react';
import { LogBox, Pressable, Text } from 'react-native';
import useCachedResources from './hooks/useCachedResources';
import useColorScheme from './hooks/useColorScheme';
import Navigation from './navigation';
import { ThemeProvider } from './context/ThemeProvider';
import {
  WalletConnectModal,
  useWalletConnectModal,
} from '@walletconnect/modal-react-native';
import { NavigationContainer } from '@react-navigation/native';

// @ts-expect-error - `@env` is a virtualised module via Babel config.
import { ENV_PROJECT_ID } from '@env';

export default function App() {
  const isLoadingComplete = useCachedResources();
  const colorScheme = useColorScheme();

  const projectId = process.env.ENV_PROJECT_ID || ENV_PROJECT_ID;

  const providerMetadata = {
    name: 'Decentralance',
    description: 'A decentralized gigs app for freelancers',
    url: 'https://your-project-website.com/',
    icons: ['https://your-project-logo.com/'],
    redirect: {
      native: 'YOUR_APP_SCHEME://',
      universal: 'YOUR_APP_UNIVERSAL_LINK.com',
    },
  };

  // avoid warnings showing up in app. comment below code if you want to see warnings.
  useEffect(() => {
    LogBox.ignoreAllLogs();
  }, []);

  if (!isLoadingComplete) {
    return null;
  } else {
    return (
      <ThemeProvider>
        <SafeAreaProvider>
          <Navigation colorScheme={colorScheme} />
          <StatusBar />

          <WalletConnectModal
            projectId={projectId}
            providerMetadata={providerMetadata}
          />
        </SafeAreaProvider>
      </ThemeProvider>
    );
  }
}
