import React from 'react'
import  Avatar from '@mui/material/Avatar';
import  Typography from '@mui/material/Typography';
import Box from '@mui/material/Box'

const AuthorAvatar = () => {
  
  return (
    <Box display={'flex'} sx={{ marginBottom: '20px'}}>
        <Avatar sx={{bgcolor: '#FDA5A5', color: '#843434'}}>B</Avatar>
        <Box sx={{ marginLeft: '10px'}}
        display="flex"
        alignItems="center"
        justifyContent="center">
            <Typography fontSize='24px' color='#843434'>Bubelek</Typography>
        </Box>
    </Box>
  )
}

export default AuthorAvatar