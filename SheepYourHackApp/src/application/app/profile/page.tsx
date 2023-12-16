import { Avatar, Box, Paper, Typography } from '@mui/material'
import React from 'react'

const page = () => {
  return (
    <Box sx={{width: '100%', display: 'flex', justifyContent: 'center', alignItems: 'center'}}>
      <Paper sx={{width: '30%', height: '50%', display: 'flex', justifyContent: 'center', alignItems: 'center'}}>
        <Avatar>KS</Avatar>
        <Typography>Kamil</Typography>
      </Paper>
    </Box>
  )
}

export default page
