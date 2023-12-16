import  Paper  from '@mui/material/Paper'
import Box from '@mui/material/Box'
import React, { useState } from 'react'
import {Avatar, Button, Divider, Typography}  from '@mui/material';
import PostFeed from './PostFeed';
import EventFeed from './EventFeed';
import FormFeed from './FormFeed';
import ThumbUpIcon from '@mui/icons-material/ThumbUp';
import Image from 'next/image';
import { Poll } from '@/app/types';
import { ThumbDown } from '@mui/icons-material';
import campFire from "../../../public/campfire.jpg";
import meditation from "../../../public/meditation.jpeg";
import running from "../../../public/running.jpg";
import lunch from "../../../public/lunch.jpg";
import { green } from '@mui/material/colors';
import { Poll } from '@/app/types';

interface Props {
    content: string,
    type: string,
    hashtagId: number,
    formData: Poll | null
}

const hashtags = [
    ['#food', '#eathealth', '#quicklunch'],
    ['#jog', '#lifestyle', '#fitwork'],
    ['#joinus', '#meditation', '#peace'],
    ['#campfire', '#greatfood', '#timetomeet'],
]

const photos = [
    lunch, running, meditation, campFire,
]


const Feed = ({content, type, hashtagId, formData}: Props) => {
    const [clickedInt, setClickedInt] = useState(false);
    const [clickedNotInt, setClickedNotInt] = useState(false);

    return (
        <Box width="60%">
            <Paper elevation={3}>
                <Box display="flex" justifyContent="start" alignItems="center">
                    <Box display="flex" justifyContent="center" alignItems="start" gap="1rem" sx={{m: '1rem'}}>
                        <Avatar sx={{ bgcolor: green[300] }}>K</Avatar>
                        <Box>
                            <Typography sx={{ fontWeight: 'bold' }} variant='body2'>Kamil Salamonczyk</Typography>
                            <Typography sx={{color: 'grey'}} variant='body2'>Manager</Typography>
                        </Box>
                    </Box>
                </Box>
                {type == "POST" ? 
                    <PostFeed content={content}></PostFeed> 
                    : 
                    type == "EVENT" 
                    ? 
                    <EventFeed content={content}></EventFeed> 
                    : 
                    <FormFeed content={content} formData={formData!}></FormFeed>}
                <Box width="100%" display="flex" justifyContent="center" alignItems="center">
                    <Box width="90%">
                        <Image
                        src={photos[hashtagId]}
                        alt="LOGO"
                        width={0}
                        height={0}
                        style={{ width: '50%', height: 'auto', borderRadius: "5px" }}
                        />
                    </Box>
                </Box>
                <Box sx={{width: '100%', display: 'flex', justifyContent: 'center', mb: '0.5rem'}}>
                    <Box sx={{display: 'flex', width: '90%', gap: '1rem', color: 'grey'}}>
                        <Typography>{hashtags[hashtagId][0]}</Typography>
                        <Typography>{hashtags[hashtagId][1]}</Typography>
                        <Typography>{hashtags[hashtagId][2]}</Typography>
                    </Box>
                </Box>
                <Divider sx={{width: '100%'}}></Divider>
                <Box sx={{width: '100%', display: 'flex', justifyContent: 'center'}}>
                    <Button sx={{width: '100%'}} onClick={() => {setClickedInt(!clickedInt)}} color={clickedInt ? "success" : "primary"} startIcon={<ThumbUpIcon />}>Jestem zainteresowany!</Button>
                    <Button sx={{width: '100%'}} onClick={() => {setClickedNotInt(!clickedNotInt)}} color={clickedNotInt ? "error" : "primary"} startIcon={<ThumbDown />}>{"Nie jestem zainteresowany"}</Button>
                </Box>
            </Paper>
        </Box>
    )
}

export default Feed;