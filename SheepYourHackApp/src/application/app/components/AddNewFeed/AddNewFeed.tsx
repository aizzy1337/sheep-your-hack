'use client'
import React, { useState } from 'react'
import Box from '@mui/material/Box'
import NewFeedButton from './NewFeedButton'
import NewFeedSelect from './NewFeedSelect'

const AddNewFeed = () => {

    const [visibility, setVisibility] = useState<boolean>(true)


    const handleClick = () => {
        setVisibility(!visibility)
    }
    
  return (
    <Box>
      <NewFeedSelect visibility='visible'></NewFeedSelect>
    </Box>
  )
}

export default AddNewFeed