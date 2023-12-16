'use client'
import React, { useState } from 'react'
import Box from '@mui/material/Box'
import NewFeedButton from './NewFeedButton'
import NewFeedSelect from './NewFeedSelect'

const AddNewFeed = () => {

    const [visibility, setVisibility] = useState<boolean>(false)


    const handleClick = () => {
        setVisibility(!visibility)
    }
    
  return (
    <Box>
        <NewFeedButton handleClick={handleClick}/>
        {visibility ? <NewFeedSelect visibility='visible'/> : <NewFeedSelect visibility='hidden'/>}
    </Box>
  )
}

export default AddNewFeed