'use client'
import React, { useState } from 'react'
import Box from '@mui/material/Box'
import { Button, Divider, Icon, Typography } from '@mui/material'
import TextField from '@mui/material/TextField';
import { LocalizationProvider } from '@mui/x-date-pickers';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs'
import { DateTimePicker } from '@mui/x-date-pickers/DateTimePicker'
import RadioButtonUncheckedIcon from '@mui/icons-material/RadioButtonUnchecked';
import teamsIcon from '../../../public/microsoft-teams-1.svg';
import slackIcon from '../../../public/slack-new-logo.svg';
interface Props {
    type: string,
    visibility: string,
    close: () => void
}

const NewFeedForm = ({type, visibility, close}: Props) => {

    const [context, setContext] = useState<string>('')
    console.log(context)

    const clearForm = () => {
        setContext('')
        close()
    }

    const handleSubmit = () => {
        clearForm()
        //fetch('http..', {POST})
    }
        return (
            <Box 
                sx={{
                    position: 'fixed',
                    bgcolor: ' rgba(52,52,50,0.3)',
                    width: '100vw',
                    height: '100vh',
                    left: '0',
                    top: '0',
                    zIndex: '1'
                }}
                display={visibility}
                justifyContent='center'
                alignItems='center'
            >
                <Box 
                    sx={{
                        width: '50%',
                        height: '70%',
                        bgcolor: '#fff',
                        borderRadius: '10px'
                    }}
                    display='flex'
                    flexDirection='column'
                    justifyContent='space-around'
                    alignItems='center'
                    >
                    <Typography width="90%" variant='h5' textAlign="start" >{type == 'POST' ? "Dodaj post" : type == "FORM" ? "Dodaj ankiete" : "Dodaj wydarzenie"}</Typography>
                    <Box width="90%">
                        <LocalizationProvider dateAdapter={AdapterDayjs}>
                            <DateTimePicker
                                label="Wybierz date"
                            />
                        </LocalizationProvider>
                    </Box>
                    <TextField
                        id="outlined-multiline-flexible"
                        label={type == 'POST' ? 'Dodaj opis postu....' : type == "FORM" ? "Dodaj opis ankiety..." : "Dodaj opis wydarzenia..."}
                        multiline
                        rows={type == "FORM" ? 4 : 16}
                        value={context}
                        onChange={(e) => setContext(e.target.value)}
                        sx={{
                            width: '90%',
                            
                        }}
                    />
                    

                    {type == "FORM" ? 
                        <Box sx={{width: '90%'}}>
                            <Typography>Dodaj ankiete</Typography>
                            <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
                                <RadioButtonUncheckedIcon sx={{ color: 'action.active', mr: 1, my: 0.5 }} />
                                <TextField id="input-with-sx" label="Pytanie nr 1" variant="standard" />
                            </Box>
                            <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
                                <RadioButtonUncheckedIcon sx={{ color: 'action.active', mr: 1, my: 0.5 }} />
                                <TextField id="input-with-sx" label="Pytanie nr 2" variant="standard" />
                            </Box>
                            <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
                                <RadioButtonUncheckedIcon sx={{ color: 'action.active', mr: 1, my: 0.5 }} />
                                <TextField id="input-with-sx" label="Pytanie nr 3" variant="standard" />
                            </Box>
                        </Box>
                    
                    : <></>}

                    <Box display='flex' justifyContent='end' sx={{width: '90%'}}>
                        <Box display='flex' gap={5}>
                            <Button variant="contained" color="primary" onClick={close} >Anuluj</Button>
                            <Button variant="contained" color="primary" onClick={handleSubmit} >Zapisz</Button>
                        </Box>
                    </Box>
                </Box>
            </Box>
          )
    }

export default NewFeedForm