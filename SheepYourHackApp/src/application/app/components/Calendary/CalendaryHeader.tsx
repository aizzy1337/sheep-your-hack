'use client'
import React from 'react'
import Box from '@mui/material/Box';
import ArrowBackIosIcon from '@mui/icons-material/ArrowBackIos';
import ArrowCircleRightOutlinedIcon from '@mui/icons-material/ArrowCircleRightOutlined';
import {IconButton, Typography}  from '@mui/material';

interface Props {
  rightArrClick: () => void,
  leftArrClick: () => void,
  header: string
}

const CalendaryHeader = ({rightArrClick, leftArrClick, header}: Props) => {
  
  return (
    <Box display='flex' sx={{marginTop: '16px'}} gap={5}>
      <IconButton size="large" color="primary">
        <ArrowBackIosIcon id="arrowicon" sx={{fontSize: '36px'}} onClick={leftArrClick}/>
      </IconButton>
      <Typography variant='h3' sx={{fontSize: '28px', alignSelf: 'center'}}>{header}</Typography>
      <IconButton size="large" color="primary">
        <ArrowBackIosIcon id="arrowicon" sx={{fontSize: '36px'}} className='icon-flipped' onClick={rightArrClick}/>
      </IconButton>
    </Box>
  )
}

export default CalendaryHeader