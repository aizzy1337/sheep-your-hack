'use client'
import React from 'react'
import Box from '@mui/material/Box'
import AddIcon from '@mui/icons-material/Add';

interface Props {
    handleClick: () => void
}

const NewFeedButton = ({handleClick}: Props) => {

  return (
    // <Box sx={{
    // //     borderRadius: '50%', 
    // //     height: '60px', 
    // //     width: '60px', 
    // //     position:'fixed', 
    // //     bottom:'30px', 
    // //     right:'30px',
    // //     bgcolor: '#343432',
    // //     color: 'white',
    // //     cursor: 'pointer',
    // // visibility: ''}} 
    // //     display='flex'
    // //     justifyContent='center'
    // //     alignItems='center'
    // //     onClick ={handleClick}>
    // //     <AddIcon sx={{fontSize: '40px'}} />
    // </Box>
  )
}

export default NewFeedButton