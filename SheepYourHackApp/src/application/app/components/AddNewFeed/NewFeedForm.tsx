'use client'
import React, { useEffect, useState } from 'react'
import Box from '@mui/material/Box'
import { Avatar, Button, Checkbox, Divider, FormControlLabel, Icon, SvgIcon, Typography } from '@mui/material'
import TextField from '@mui/material/TextField';
import { LocalizationProvider } from '@mui/x-date-pickers';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs'
import { DateTimePicker } from '@mui/x-date-pickers/DateTimePicker'
import teamsIcon from '../../../public/microsoft-teams-1.svg';
import slackIcon from '../../../public/slack-new-logo.svg';
import Image from 'next/image';
import dayjs, { Dayjs } from 'dayjs';
import { Start } from '@mui/icons-material';
import RadioButtonUncheckedIcon from '@mui/icons-material/RadioButtonUnchecked';

interface Props {
    type: string,
    visibility: string,
    close: () => void
}

interface User {
    id: number,
    firstname: string,
    lastname: string,
    nickname: string,
    groupRole: number,
    groupId: number
  }

const NewFeedForm = ({type, visibility, close}: Props) => {

    const [context, setContext] = useState<string>('')
    const [date, setDate] = useState<any>()
    const [teams, setTeams] = useState<boolean>(false)
    const [slack, setSlack] = useState<boolean>(false)
    const [user, setUser] = useState<User>()
    const [option1, setOption1] = useState<string>('')
    const [option2, setOption2] = useState<string>('')
    const [option3, setOption3] = useState<string>('')

    const API = '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';
    
    const [userPrompt, setUserPrompt] = useState('');

    const [isTyping, setIsTyping] = useState(false);

    const handleSendRequest = async () => {
        setIsTyping(true);

        try {
            const response = await processMessageToChatGPT(userPrompt);

            const content = response.choices[0]?.message?.content;
            if (content) {
                setContext(content);
                console.log(content);
            }
        } catch (error) {
            console.error("Error processing message:", error);
        } finally {
            setIsTyping(false);
        }
    };

    async function processMessageToChatGPT(message: string) {
        const prompt = {role: "user", content: message};

        const apiRequestBody = {
          "model": "gpt-3.5-turbo",
          "messages": [
            { role: "system", content: "Jesteś pomocnym asystentem który pomaga tworzyć wydarzenia dla HR w firmie. Odpowiadaj po polsku, twórz krótkie 3 zdaniowe odpowiedzi." },
            prompt,
          ],
        };
        const response = await fetch("https://api.openai.com/v1/chat/completions", {
          method: "POST",
          headers: {
            "Authorization": "Bearer " + API,
            "Content-Type": "application/json",
          },
          body: JSON.stringify(apiRequestBody),
        });
    
        return response.json();
    }

    const handleSubmit = async () => {
        const date = new Date()
        clearForm()
        if(type=="POST") {
            const newFeed = {
                Message: context,
                UserNickname: user?.nickname,
                UserId: user?.id,
                CreationDate: date,
                FeedType: 0
            }
            const res = await fetch('http://localhost:5002/api/Feeds', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            if(teams) {
                await fetch('http://localhost:5002/api/Feeds/teams', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            } 
            if(slack) {
                await fetch('http://localhost:5002/api/Feeds/slack', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            } 
        }
        if(type=="EVENT") {
            const newFeed = {
                Message: context,
                UserNickname: user?.nickname,
                UserId: user?.id,
                event:{
                    name: context,
                    StartTime: date,
                    EndTime: date?.setHours(date.getHours() + 3),
                    organizator: 'Some Rich Daddy',
                    type: 1
                },
                CreationDate: new Date(),
                FeedType: 1
            }
            await fetch('http://localhost:5002/api/Feeds', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            if(teams) {
                await fetch('http://localhost:5002/api/Feeds/teams', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            } 
            if(slack) {
                await fetch('http://localhost:5002/api/Feeds/slack', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            } 
        }
        if(type=="FORM") {
            const options = [
                {
                    id: 0,
                    name: option1
                },
                {
                    id: 1,
                    name: option2
                },
                {
                    id: 2,
                    name: option3
                }
            ]
            const newFeed = {
                Message: context,
                UserNickname: user?.nickname,
                UserId: user?.id,
                poll:{
                    name: context,
                    options
                },
                CreationDate: Date.now(),
                FeedType: 2
            }
            await fetch('http://localhost:5002/api/Feeds', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            if(teams) {
                await fetch('http://localhost:5002/api/Feeds/teams', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            } 
            if(slack) {
                await fetch('http://localhost:5002/api/Feeds/slack', {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(newFeed), 
                })
            } 
        }
    }

    const fetchUser = async () => {
        const res =await fetch('https://localhost:5003/api/user/1')
        const user = await res.json()
        setUser(user)
    }

    useEffect(() => {
        fetchUser()
    },[])


    const clearForm = () => {
        setContext('')
        close()
    }

    const handleTeamsChange = (e: any) => {
        setTeams(!teams)
    }

    const handleSlackChange = (e: any) => {
        setSlack(!slack)
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
                    <TextField sx={{width: "90%"}} value={userPrompt} onChange={(e) => setUserPrompt(e.target.value)}></TextField>
                    <Button variant="outlined" onClick={handleSendRequest}>Ask GPT</Button>
                    

                    {type == "FORM" ? 
                        <Box sx={{width: '90%'}}>
                            <Typography>Dodaj ankiete</Typography>
                            <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
                                <RadioButtonUncheckedIcon sx={{ color: 'action.active', mr: 1, my: 0.5 }} />
                                <TextField value={option1} onChange={(e) => setOption1(e.target.value)} id="input-with-sx" label="Pytanie nr 1" variant="standard" />
                            </Box>
                            <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
                                <RadioButtonUncheckedIcon sx={{ color: 'action.active', mr: 1, my: 0.5 }} />
                                <TextField value={option2} onChange={(e) => setOption2(e.target.value)} id="input-with-sx" label="Pytanie nr 2" variant="standard" />
                            </Box>
                            <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
                                <RadioButtonUncheckedIcon sx={{ color: 'action.active', mr: 1, my: 0.5 }} />
                                <TextField value={option3} onChange={(e) => setOption3(e.target.value)} id="input-with-sx" label="Pytanie nr 3" variant="standard" />
                            </Box>
                        </Box>
                    
                    : <></>}

                    <Box display='flex' justifyContent='end' sx={{width: '90%'}}>
                            <Box display='flex' justifyContent="center" alignItems="center" gap={3} sx={{mr: 'auto'}}>
                                <Typography sx={{fontWeight: 'bold'}}>Wyślij na:</Typography>
                                <Box display='flex' justifyContent="center" alignItems="center" gap={1}>
                                    <Checkbox value={teams} onChange={handleTeamsChange}/>
                                    <Image
                                            src={teamsIcon}
                                            alt="LOGO"
                                            width={0}
                                            height={0}
                                            style={{ width: '25px', height: 'auto', marginLeft: '-8px' }}
                                    />
                                    <Typography>Teams</Typography>
                                </Box>
                                <Box display='flex' justifyContent="center" alignItems="center" gap={1}>
                                    <Checkbox value={slack} onChange={handleSlackChange}/>
                                    <Image
                                            src={slackIcon}
                                            alt="LOGO"
                                            width={0}
                                            height={0}
                                            style={{ width: '20px', height: 'auto', marginLeft: '-8px' }}
                                    />
                                    <Typography >Slack</Typography>
                                </Box>
                            </Box>
                            <Box display="flex" gap={5}>
                                <Button variant="contained" color="primary" onClick={close} >Anuluj</Button>
                                <Button variant="contained" color="primary" onClick={handleSubmit} >Zapisz</Button>
                            </Box>
                    </Box>
                </Box>
            </Box>
          )
}
export default NewFeedForm

function moment() {
    throw new Error('Function not implemented.');
}
