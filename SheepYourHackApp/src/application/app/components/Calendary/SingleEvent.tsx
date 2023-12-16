import React from 'react'
import Box from '@mui/material/Box';
import { Grid, Paper, Stack, Typography } from '@mui/material';
import AccessTimeIcon from '@mui/icons-material/AccessTime';

interface Props {
    title: string,
    place: string,
    hour: string
}

const SingleEvent = ({title, place, hour}: Props) => {
  return (
    <Paper elevation={4} square={false} sx={{p: '1rem', width: '80%', mb: '2rem'}}>
      <Box>
          <Typography sx={{ fontWeight: 'bold' }} variant='body1'>{title}</Typography>
          <Typography sx={{color: 'grey', mt: '-8px'}} variant='body2'>{place}</Typography>
      </Box>
      <Box sx={{display: 'flex', alignItems: "start", justifyContent: "start"}} >
          <AccessTimeIcon></AccessTimeIcon>
          <Typography variant='body1'>{hour}</Typography>
      </Box >
    </Paper>
  )
}

export default SingleEvent