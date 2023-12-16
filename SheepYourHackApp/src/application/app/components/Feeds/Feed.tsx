import  Paper  from '@mui/material/Paper'
import Box from '@mui/material/Box'
import React from 'react'
import {Avatar, Button, ButtonGroup, Divider, Rating, Typography}  from '@mui/material';
import AuthorAvatar from './AuthorAvatar';
import EventIcons from './EventIcons';
import PostFeed from './PostFeed';
import EventFeed from './EventFeed';
import FormFeed from './FormFeed';
import { blueGrey, deepOrange, deepPurple, green } from '@mui/material/colors';
import { styled } from '@mui/material/styles';
import FavoriteIcon from '@mui/icons-material/Favorite';
import ThumbUpIcon from '@mui/icons-material/ThumbUp';
import ShareIcon from '@mui/icons-material/Share';

interface Props {
    content: string,
    type: string
}

const StyledRating = styled(Rating)({
    '& .MuiRating-iconFilled': {
      color: '#ff6d75',
    },
    '& .MuiRating-iconHover': {
      color: '#ff3d47',
    },
  });

const Feed = ({content, type}: Props) => {
    return (
        <Box width="60%">
            <Paper>
                <Box display="flex" justifyContent="start" alignItems="center">
                    <Box display="flex" justifyContent="center" alignItems="start" gap="1rem" sx={{m: '1rem'}}>
                        <Avatar sx={{ bgcolor: green[300] }}>K</Avatar>
                        <Box>
                            <Typography sx={{ fontWeight: 'bold' }} variant='body2'>Kamil Salamonczyk</Typography>
                            <Typography sx={{color: 'grey'}} variant='body2'>Manager</Typography>
                        </Box>
                    </Box>
                </Box>
                {type == "POST" ? <PostFeed content={content}></PostFeed> : type == "EVENT" ? <EventFeed content={content}></EventFeed> : <FormFeed content={content}></FormFeed>}
                <Box sx={{width: '100%', display: 'flex', justifyContent: 'center', mb: '0.5rem'}}>
                    <Box sx={{display: 'flex', width: '90%', gap: '1rem', color: 'grey'}}>
                        <Typography>#food</Typography>
                        <Typography>#quicklunch</Typography>
                        <Typography>#eathealthy</Typography>
                    </Box>
                    
                </Box>
                <Divider sx={{width: '100%'}}></Divider>
                <Box sx={{width: '100%', display: 'flex', justifyContent: 'center'}}>
                    <Button sx={{width: '100%'}} endIcon={<ThumbUpIcon />}>Jestem zainteresowany!</Button>
                    <Button sx={{width: '100%'}}  endIcon={<ShareIcon />}>Udostepnij</Button>
                </Box>
            </Paper>
        </Box>
    )
}

export default Feed;