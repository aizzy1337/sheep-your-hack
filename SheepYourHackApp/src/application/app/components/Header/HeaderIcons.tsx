import React from 'react'
import Box from '@mui/material/Box';
import { Avatar } from '@mui/material';
import NotificationsNoneIcon from '@mui/icons-material/NotificationsNone';
import LogoutIcon from '@mui/icons-material/Logout';
import Link from 'next/link';

const HeaderIcons = () => {
  return (
    <Box sx={{display: 'flex', gap: '50px', marginLeft: '150px'}} >
        <Box >
            <Link href='/profile'>
                <Avatar>HP</Avatar>
            </Link>
        </Box>
        <Box >
            <Link href='/notifications'>
                <NotificationsNoneIcon fontSize='large' color="primary"/>
            </Link>
        </Box>
        <Box >
            <Link href='/signout'>
                <LogoutIcon fontSize='large' color="primary"/>
            </Link>
        </Box>
        
        
    </Box>
  )
}

export default HeaderIcons