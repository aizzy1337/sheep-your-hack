'use client'
import React from 'react'
import Box from '@mui/material/Box';
import ArrowCircleLeftOutlinedIcon from '@mui/icons-material/ArrowCircleLeftOutlined';
import ArrowCircleRightOutlinedIcon from '@mui/icons-material/ArrowCircleRightOutlined';
import {Typography}  from '@mui/material';

interface Props {
  rightArrClick: () => void,
  leftArrClick: () => void,
  header: string
}

const CalendaryHeader = ({rightArrClick, leftArrClick, header}: Props) => {
  
  return (
    <Box display='flex' sx={{marginTop: '16px'}} gap={5}>
        <ArrowCircleLeftOutlinedIcon sx={{fontSize: '36px'}} onClick={leftArrClick}/>
        <Typography sx={{fontSize: '28px'}}>{header}</Typography>
        <ArrowCircleRightOutlinedIcon sx={{fontSize: '36px'}} onClick={rightArrClick}/>
    </Box>
  )
}

export default CalendaryHeader