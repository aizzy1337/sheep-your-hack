import React from 'react'
import Box from '@mui/material/Box'
import { Button } from '@mui/material'

interface Props {
    visibility: string
}

const NewFeedSelect = ({visibility}: Props) => {
  return (
    <Box 
    sx={{
        height: '200px',
        width: '250px',
        bgcolor: '#343432',
        position: 'fixed',
        bottom: '100px',
        right: '30px',
        borderRadius: '10px',
        visibility: visibility
    }}
    display='flex'
    flexDirection='column'
    justifyContent='space-around'
    alignItems='center'
    >
        <Button variant="contained" color="secondary" sx={{width: '80%', height: '20%'}}>Post</Button>
        <Button variant="contained" color="secondary" sx={{width: '80%', height: '20%'}}>Wydarzenie</Button>
        <Button variant="contained" color="secondary" sx={{width: '80%', height: '20%'}}>Ankieta</Button>
    </Box>
  )
}

export default NewFeedSelect