import React from 'react'
import Box from '@mui/material/Box';

interface Props {
    title: string,
    place: string,
    hour: string
}

const SingleEvent = ({title, place, hour}: Props) => {
  return (
    <Box sx={{borderBottom: '2px solid black'}}>
        <h4>{title}</h4>
        <Box><span>{place}</span></Box>
        <Box><p>{hour}</p></Box>
    </Box>
  )
}

export default SingleEvent