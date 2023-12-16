import EventNoteIcon from '@mui/icons-material/EventNote';
import LogoutIcon from '@mui/icons-material/Logout';
import NotificationsNoneIcon from '@mui/icons-material/NotificationsNone';
import { Avatar, Button } from '@mui/material';
import Box from '@mui/material/Box';
import { useState } from 'react';
import { UserInfo } from './UserInfo';
import Link from 'next/link';

const HeaderIcons = () => {
    const [isShown, setIsShown] = useState(false);


    return (
        <Box sx={{ display: 'flex', gap: '25px', marginLeft: '150px', alignItems: 'center' }} >
                <Button href='/calendary' startIcon={<EventNoteIcon />}>
                    Kalendarz
                </Button>
                <Button href='/notifications' startIcon={<NotificationsNoneIcon />}>
                    Powiadomienia
                </Button>

                <Link href="/profile">
                    <Avatar
                            sx={{ bgcolor: '#333533', color: '#fff', width: '30px', height: '30px' }}
                            onMouseEnter={() => setIsShown(true)}
                            onMouseLeave={() => setIsShown(false)}
                    >K</Avatar>
                </Link>

        </Box>
    )
}

export default HeaderIcons