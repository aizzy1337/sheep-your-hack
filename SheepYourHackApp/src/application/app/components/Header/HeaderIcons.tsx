import EventNoteIcon from '@mui/icons-material/EventNote';
import LogoutIcon from '@mui/icons-material/Logout';
import NotificationsNoneIcon from '@mui/icons-material/NotificationsNone';
import { Avatar } from '@mui/material';
import Box from '@mui/material/Box';
import Link from 'next/link';
import { useState } from 'react';
import { UserInfo } from './UserInfo';

const HeaderIcons = () => {
    const [isShown, setIsShown] = useState(false);


    return (
        <Box sx={{ display: 'flex', gap: '50px', marginLeft: '150px' }} >
            <Box >
                <Link href='/profile'>
                    <Avatar
                        sx={{ bgcolor: '#FDA5A5', color: '#843434' }}
                        onMouseEnter={() => setIsShown(true)}
                        onMouseLeave={() => setIsShown(false)}
                    >B</Avatar>
                </Link>

                {isShown && (
                    <UserInfo nickname='bulbek' firstname='Bulbulezar' lastname='Gąbka' />
                )}
            </Box>
            <Box >
                <Link href='/calendary'>
                    <EventNoteIcon fontSize='large' color="primary" />
                </Link>
            </Box>
            <Box >
                <Link href='/notifications'>
                    <NotificationsNoneIcon fontSize='large' color="primary" />
                </Link>
            </Box>
            <Box >
                <Link href='/signout'>
                    <LogoutIcon fontSize='large' color="primary" />
                </Link>
            </Box>


        </Box>
    )
}

export default HeaderIcons