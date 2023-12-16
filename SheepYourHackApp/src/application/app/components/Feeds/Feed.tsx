import  Paper  from '@mui/material/Paper'
import Box from '@mui/material/Box'
import React from 'react'
import {Typography}  from '@mui/material';
import AuthorAvatar from './AuthorAvatar';
import EventIcons from './EventIcons';

interface Props {
    content: string,
    type: string
}

const Feed = ({content, type}: Props) => {

    if(type == "POST"){
    return (
        <Paper sx={{width: '600px', p: '20px', border: 'solid 2px #DE4C30', borderRadius: '10px', paddingLeft: '30px'}}>
            <Box>
                <AuthorAvatar />
                <Typography>
                    {content}
                </Typography>
            </Box>
        </Paper>
    )
    }
    if(type == "EVENT"){
    return (
        <Paper sx={{width: '600px', p: '20px', border: 'solid 2px #9CC69B', borderRadius: '10px'}} >
            <Box display='flex' flexDirection='column'>
                <AuthorAvatar />
                <Typography>
                    {content}
                </Typography>
                <EventIcons />
            </Box>
        </Paper>
    )
    }
}

export default Feed