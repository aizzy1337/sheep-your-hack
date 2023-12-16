'use client'
import React, { useState } from 'react'
import Box from '@mui/material/Box'
import { Button } from '@mui/material'
import NewFeedForm from './NewFeedForm'

interface Props {
    visibility: string
}

const NewFeedSelect = ({visibility}: Props) => {

    const [openForm, setOpenForm] = useState<boolean>(false)
    const [type, setType] = useState<string>()

    const handleOpen = (formType: string) => {
        setOpenForm(true)
        setType(formType)
    }

    const handleClose = () => {
        setOpenForm(false)
    }


  return (
    <Box 
    sx={{
        height: '200px',
        width: '250px',
        bgcolor: '#343432',
        position: 'fixed',
        bottom: '100px',
        right: '30px',
        borderRadius: '10px',
        visibility: visibility
    }}
    display='flex'
    flexDirection='column'
    justifyContent='space-around'
    alignItems='center'
    >
        <Button 
            variant="contained" 
            color="secondary" 
            sx={{width: '80%', height: '20%'}}
            onClick={() => handleOpen('POST')}
            >
                Post
        </Button>
        <Button 
            variant="contained" 
            color="secondary" 
            sx={{width: '80%', height: '20%'}}
            onClick={() => handleOpen('EVENT')}
            >
                Wydarzenie
        </Button>
        <Button 
            variant="contained" 
            color="secondary" 
            sx={{width: '80%', height: '20%'}}
            onClick={() => handleOpen('FORM')}
            >
                Ankieta
        </Button>
        {openForm ?
        <NewFeedForm type={type!} visibility='flex' close={handleClose} /> 
        : <NewFeedForm type={type!} visibility='none' close={handleClose}/>}
    </Box>
  )
}

export default NewFeedSelect