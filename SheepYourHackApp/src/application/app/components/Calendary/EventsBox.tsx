'use client'
import React, { useEffect, useState } from 'react'
import Box from '@mui/material/Box';
import { groupEventsByDay } from '@/app/utils/calendaryEvents';
import CircularProgress from '@mui/material/CircularProgress';
import SingleEvent from './SingleEvent';
import { Divider, Paper, Typography } from '@mui/material';
import { green } from '@mui/material/colors';

interface Event {
    title: string,
    place: string,
    day: string,
    hour: string,
    workTime: string
}

interface Props {
    counter: number
    data: Event[]
}

const EventsBox = ({counter, data}: Props, ) => {

    const [day, setDay] = useState<string>('')
    const [daysEvents, setDaysEvents] = useState<Event[]>()

    console.log('children:', counter)

    const uniqueDays = groupEventsByDay(data)
    
    useEffect(() => {
        setDay(uniqueDays[counter])
        const currentDayEvents = data.filter(e => e.day === day) 
        console.log(currentDayEvents.length)
        setDaysEvents(currentDayEvents)
    }, [counter])
    
    console.log(day, daysEvents?.length)

    const workTimeEvents = daysEvents?.filter(e => e.workTime === 'work')
    const freeTimeEvents = daysEvents?.filter(e => e.workTime === 'free')

    if(!day.length){
        return (
        <Box sx={{ display: 'flex' }}>
            <CircularProgress />
        </Box>
        )
    }
    
  return (
    <Box display='flex' gap={10} sx={{width: '100%', height: '80%', justifyContent: 'center'}}>
        {workTimeEvents?.length!>0 && 
        <Box component={Paper} elevation={2} square={false} display='flex' alignItems="center" flexDirection='column' sx={{width: '30%'}}>
            <Box sx={{backgroundColor: '#e6d0bc', width: "100%"}}>
                <Typography sx={{mt: '0.5rem', mb: '0.5rem'}} textAlign='center' variant='h4'>W pracy</Typography>
            </Box>
            <Divider sx={{width: '100%', mb: '1rem'}}></Divider>
            {workTimeEvents!.map(e => <SingleEvent title={e.title} hour={e.hour} place={e.place} />)}
        </Box>
        }
        {freeTimeEvents?.length!>0 && 
        <Box component={Paper} elevation={2} square={false} display='flex' alignItems="center" flexDirection='column'  sx={{width: '30%'}}>
            <Box sx={{backgroundColor: '#c4e3c3', width: "100%"}}>
                <Typography sx={{mt: '0.5rem', mb: '0.5rem'}} textAlign='center' variant='h4'>Po pracy</Typography>
            </Box>
            <Divider sx={{width: '100%', mb: '1rem'}}></Divider>
            {freeTimeEvents!.map(e => <SingleEvent title={e.title} hour={e.hour} place={e.place} />)}
        </Box>
        }
    </Box>
  )
}

export default EventsBox