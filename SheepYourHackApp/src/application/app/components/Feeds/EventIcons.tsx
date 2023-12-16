import React from 'react'
import Box from '@mui/material/Box';
import ThumbUpOffAltIcon from '@mui/icons-material/ThumbUpOffAlt';
import ThumbDownOffAltIcon from '@mui/icons-material/ThumbDownOffAlt';

const EventIcons = () => {
  return (
    <Box display='flex' 
    sx={{width: '100%',marginTop: '20px'}} 
    justifyContent='center'
    >
        <Box sx={{marginRight: '20px'}}>
            <ThumbUpOffAltIcon sx={{fontSize: '60px'}}/>
        </Box>
        <Box sx={{marginLeft: '20px'}}>
            <ThumbDownOffAltIcon sx={{fontSize: '60px'}}/>
        </Box>
    </Box>
  )
}

export default EventIcons