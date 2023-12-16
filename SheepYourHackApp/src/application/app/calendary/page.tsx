'use client'
import React, {useEffect, useState} from 'react'
import Box from '@mui/material/Box';
import CalendaryHeader from '../components/Calendary/CalendaryHeader';
import EventsBox from '../components/Calendary/EventsBox';
import { groupEventsByDay } from '../utils/calendaryEvents';
import { Divider, Paper } from '@mui/material';

interface Event {
    title: string,
    place: string,
    day: string,
    hour: string,
    workTime: string
}

const CalendaryPage = () => {

    const [counter, setCounter] = useState<number>(0)
    const [header, setHeader] = useState<string>('')
    const events: Event[] = [
        {
            title: "Title",
            place: 'remote',
            day: '14.11.2023',
            hour: '10:30 - 12:00',
            workTime: 'work'
        },
        {
            title: "Title",
            place: 'remote',
            day: '14.11.2023',
            hour: '10:30 - 12:00',
            workTime: 'work'
        },
        {
            title: "Title",
            place: 'remote',
            day: '10.12.2023',
            hour: '10:30 - 12:00',
            workTime: 'work'
        },
        {
            title: "Title",
            place: 'remote',
            day: '14.01.2023',
            hour: '10:30 - 12:00',
            workTime: 'free'
        },
        {
            title: "Title",
            place: 'remote',
            day: '16.12.2023',
            hour: '10:30 - 12:00',
            workTime: 'work'
        },
        {
            title: "Title",
            place: 'remote',
            day: '14.12.2023',
            hour: '10:30 - 12:00',
            workTime: 'free'
        },
        {
            title: "Title",
            place: 'remote',
            day: '18.12.2023',
            hour: '10:30 - 12:00',
            workTime: 'work'
        },
        {
            title: "Title",
            place: 'remote',
            day: '14.12.2023',
            hour: '10:30 - 12:00',
            workTime: 'work'
        },
        {
            title: "Title",
            place: 'remote',
            day: '21.12.2023',
            hour: '10:30 - 12:00',
            workTime: 'free'
        }
    ]

    const days = groupEventsByDay(events)

    useEffect(()=> {
        setHeader(days[counter])
    },[counter])

    const handleRight = () => {
        if(counter<days.length-1)
            setCounter(counter+1)
        else   
            setCounter(0)

    }

    const handleLeft = () => {
        if(counter>0)
            setCounter(counter-1)
        else   
            setCounter(days.length-1)

    }

  return (
        <Box 
            display='flex'
            justifyContent='center'
            alignItems='center'
            sx={{
                width: '100vw',
                height: '90vh',
                
            }}
            >
                <Box
                    component={Paper}
                    display='flex'
                    flexDirection='column'
                    alignItems='center'
                    sx={{
                        width: '70%',
                        height: '80%',
                        borderRadius: '20px'
                    }}>
                        <CalendaryHeader header={header} rightArrClick={handleRight} leftArrClick={handleLeft}/>
                        <Divider sx={{width: '100%', mt: '1rem', mb: '1rem'}}></Divider>
                        <EventsBox counter={counter} data={events} />
                </Box>
        </Box>
  )
}

export default CalendaryPage