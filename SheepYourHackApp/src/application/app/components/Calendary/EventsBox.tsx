'use client'
import React, { useEffect, useState } from 'react'
import Box from '@mui/material/Box';
import { groupEventsByDay } from '@/app/utils/calendaryEvents';
import CircularProgress from '@mui/material/CircularProgress';
import SingleEvent from './SingleEvent';

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
    <Box display='flex' gap={10}>
        {workTimeEvents?.length!>0 && 
        <Box display='flex' flexDirection='column' gap={3}>
            <h3>W pracy</h3>
            {workTimeEvents!.map(e => <SingleEvent title={e.title} hour={e.hour} place={e.place} />)}
        </Box>
        }
        {freeTimeEvents?.length!>0 && 
        <Box display='flex' flexDirection='column'>
            <h3>Po pracy</h3>
            {freeTimeEvents!.map(e => <SingleEvent title={e.title} hour={e.hour} place={e.place} />)}
        </Box>
        }
    </Box>
  )
}

export default EventsBox