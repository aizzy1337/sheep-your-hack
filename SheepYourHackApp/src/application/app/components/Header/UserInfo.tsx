'use client'

import { Typography } from '@mui/material';
import Box from '@mui/material/Box'

interface Props {
    visibility: string,
    nickname: string,
    firstname: string,
    lastname: string
}

export const UserInfo = ({ nickname, firstname, lastname }: Props) => {

    return (
        <Box
            sx={{
                height: '200px',
                width: '250px',
                bgcolor: '#FAFFF5',
                position: 'fixed',
                top: '65px',
                right: '250px',
                borderRadius: '10px',
                boxShadow: '0px 0px 23px -4px rgba(66, 68, 90, 1)',
                transition: 'all ease-in-out 0.3s'
            }}
            display='flex'
            flexDirection='column'
            justifyContent='space-around'
            alignItems='center'
        >
            <Box
                sx={{
                    width: '100%',
                    height: '60%'
                }}
                display='flex'
                flexDirection='column'
                justifyContent='space-around'
                alignItems='center'
            >

                <Typography variant='h4' sx={{ color: '#69A068' }} >{nickname}</Typography>
                <Typography variant='h5' sx={{ color: '#787878' }} >{firstname} {lastname}</Typography>
            </Box>
        </Box >
    );
}