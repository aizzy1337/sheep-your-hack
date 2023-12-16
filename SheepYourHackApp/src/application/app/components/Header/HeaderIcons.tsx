import EventNoteIcon from '@mui/icons-material/EventNote';
import LogoutIcon from '@mui/icons-material/Logout';
import NotificationsNoneIcon from '@mui/icons-material/NotificationsNone';
import { Avatar, Link } from '@mui/material';
import Box from '@mui/material/Box';
import { useState } from 'react';
import { UserInfo } from './UserInfo';

const HeaderIcons = () => {
    const [isShown, setIsShown] = useState(false);


    return (
        <Box sx={{ display: 'flex', gap: '50px', marginLeft: '150px' }} >
            <Box >
                <Link href='/profile'>
                    <Avatar
                        sx={{ bgcolor: '#333533', color: '#fff' }}
                        onMouseEnter={() => setIsShown(true)}
                        onMouseLeave={() => setIsShown(false)}
                    >B</Avatar>
                </Link>

                {isShown && (
                    <UserInfo nickname='bulbek' firstname='Bulbulezar' lastname='Gąbka' />
                )}
            </Box>
                <Link href='/calendary' sx={{display: 'flex', justifyContent: 'center', alignItems: 'center'}} >
                    <EventNoteIcon fontSize='large' color="primary" />
                </Link>
                <Link href='/notifications'>
                    <NotificationsNoneIcon fontSize='large' color="primary" />
                </Link>
                <Link href='/signout'>
                    <LogoutIcon fontSize='large' color="primary" />
                </Link>


        </Box>
    )
}

export default HeaderIcons