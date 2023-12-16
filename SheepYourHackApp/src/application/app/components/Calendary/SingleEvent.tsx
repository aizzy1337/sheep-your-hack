import React from 'react'
import Box from '@mui/material/Box';
import { Paper, Typography } from '@mui/material';

interface Props {
    title: string,
    place: string,
    hour: string
}

const SingleEvent = ({title, place, hour}: Props) => {
  return (
    <Paper sx={{p: '1rem', width: '10rem'}}>
      <Box>
          <Typography sx={{ fontWeight: 'bold' }} variant='body1'>{title}</Typography>
          <Typography sx={{color: 'grey'}} variant='body2'>{place}</Typography>
      </Box>

      <Typography sx={{mt: '2rem'}} variant='body2'>{hour}</Typography>
    </Paper>
  )
}

export default SingleEvent