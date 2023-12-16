'use client'
import React from 'react'
import { Button } from '@mui/material';
import Box from '@mui/material/Box';
import { useRouter } from 'next/navigation';

const HeaderButtons = () => {

    const router = useRouter()

  return (
    <Box sx={{display: 'flex', gap: '50px'}}>
        <Button  
        variant="contained" 
        color='primary' 
        onClick={() => router.push('/my-group')}>
            Moja Grupa
        </Button>
        <Button  
        variant="contained" 
        color='primary'
        onClick={() => router.push('/calendary')}>
            Kalendarz
        </Button>
    </Box>
  )
}

export default HeaderButtons