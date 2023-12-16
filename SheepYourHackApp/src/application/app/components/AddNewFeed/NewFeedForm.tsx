'use client'
import React, { useState } from 'react'
import Box from '@mui/material/Box'
import { Button } from '@mui/material'
import TextField from '@mui/material/TextField';

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

    if(type === 'POST' || type === "EVENT") {
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
                    <TextField
                        id="outlined-multiline-flexible"
                        label="Post context...."
                        multiline
                        rows={16}
                        value={context}
                        onChange={(e) => setContext(e.target.value)}
                        sx={{
                            width: '90%',
                            
                        }}
                    />
                    <Box display='flex' gap={5}>
                    <Button variant="contained" color="secondary" onClick={close} >Close</Button>
                    <Button variant="contained" color="secondary" onClick={handleSubmit} >Submit</Button>

                    </Box>
                </Box>
            </Box>
          )
    }
  
}

export default NewFeedForm