"use client";
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import './globals.css'
import { CacheProvider, ThemeProvider } from '@emotion/react'
import createEmotionCache from "./utils/createEmotionCache";
import ThemeRegistry from './ThemeRegistry/ThemeRegistry';
import Header from './components/Header/Header'

const inter = Inter({ subsets: ['latin'] })

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <body className={inter.className}>
        <ThemeRegistry>
          <Header />
          <main>
            {children}
          </main>
        </ThemeRegistry>
      </body>
    </html>
  )
}
