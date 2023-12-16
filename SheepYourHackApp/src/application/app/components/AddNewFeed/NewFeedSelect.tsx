'use client'
import React, { useState } from 'react'
import Box from '@mui/material/Box'
import { Button, SpeedDial, SpeedDialAction, SpeedDialIcon } from '@mui/material'
import PollIcon from '@mui/icons-material/Poll';
import FileCopyIcon from '@mui/icons-material/FileCopyOutlined';
import SaveIcon from '@mui/icons-material/Save';
import EventIcon from '@mui/icons-material/Event';
import PostAddIcon from '@mui/icons-material/PostAdd';
import NewFeedForm from './NewFeedForm';

interface Props {
    visibility: string
}

const NewFeedSelect = ({visibility}: Props) => {

    const [openForm, setOpenForm] = useState<boolean>(false)
    const [type, setType] = useState<string>()

    const handleOpen = (formType: string) => {
        console.log(formType)
        setOpenForm(true)
        setType(formType)
    }

    const handleClose = () => {
        setOpenForm(false)
    }

    const actions = [
        { icon: <PollIcon />, name: 'Ankieta', action: 'FORM' },
        { icon: <EventIcon />, name: 'Wydarzenie', action: 'EVENT' },
        { icon: <PostAddIcon />, name: 'Post', action: 'POST'},
      ];

  return (
    <>
        <SpeedDial ariaLabel="SpeedDial basic example" icon={<SpeedDialIcon />} sx={{ position: 'fixed', bottom: '16px', right: '16px' }}>
        {actions.map((action) => (
            <SpeedDialAction
            key={action.name}
            icon={action.icon}
            tooltipTitle={action.name}
            onClick={() => {
                handleOpen(action.action)
           }}
            />
  ))}
        </SpeedDial>
        {openForm ?
        <NewFeedForm type={type!} visibility='flex' close={handleClose} /> 
         : <NewFeedForm type={type!} visibility='none' close={handleClose}/>}
    </>
  )
}

export default NewFeedSelect