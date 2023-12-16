import { Box, Paper, Typography } from '@mui/material'
import React from 'react'

interface Props {
    content: string,
}

const PostFeed = ({content}: Props) => {
  return (
    <Box width="100%" display="flex" justifyContent="center" sx={{mt: '1rem', mb: '1rem'}}>
        <Typography textAlign="justify" sx={{width: "90%"}} variant="body1">{content}</Typography>
    </Box>
  )
}

export default PostFeed
