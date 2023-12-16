'use client'
import React, {useEffect, useState} from 'react'
import Box from '@mui/material/Box';
import CalendaryHeader from '../components/Calendary/CalendaryHeader';
import EventsBox from '../components/Calendary/EventsBox';
import { groupEventsByDay } from '../utils/calendaryEvents';

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
    console.log('parent:', counter)
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
                    display='flex'
                    flexDirection='column'
                    alignItems='center'
                    sx={{
                        width: '70%',
                        height: '80%',
                        border: 'solid 2px #9CC69B',
                        borderRadius: '20px'
                    }}>
                        <CalendaryHeader header={header} rightArrClick={handleRight} leftArrClick={handleLeft}/>
                        <EventsBox counter={counter} data={events} />
                </Box>
        </Box>
  )
}

export default CalendaryPage