'use client'
import React, { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import Feed from '../components/Feeds/Feed';
import { styled } from '@mui/system';
import AddNewFeed from '../components/AddNewFeed/AddNewFeed';
import { Feeds } from '../types';

const StyledBox = styled(Box)({
  overflowY: 'scroll',
  '::-webkit-scrollbar': {
    width: '12px',
  },
  '::-webkit-scrollbar-thumb': {
    backgroundColor: '#888',
    borderRadius: '6px',
  },
  '::-webkit-scrollbar-thumb:hover': {
    backgroundColor: '#555',
  },
});

interface User {
  id: number,
  firstname: string,
  lastname: string,
  nickname: string,
  groupRole: number,
  groupId: number
}



const MyGroupPage = () => {

  const [data, setData] = useState<User>()
  const [feeds, setFeeds] = useState<Feeds[]>()

  let context1 = 'Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker'
  let context2 = 'Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMakerLorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker'
  let context3 = 'Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle '

  const fetchData = async () => {
    const res = await fetch("https://localhost:5003/api/User/1")
    const events: User = await res.json()
    setData(events)
  }

  const fetchFeeds = async () => {
    const res = await fetch('https://localhost:5003/api/Feeds/1')
    const data = await res.json()
    setFeeds(data)
  }
  useEffect(()=> {
    fetchData()
    fetchFeeds()
  },[])

  const events = feeds ? feeds.filter(f => f.event) : null
  const polls = feeds ? feeds.filter(f => f.poll) : null
  const posts = feeds ? feeds.filter(f => !f.poll && !f.event) : null


  return (
    <Box width="100%" display="flex" alignItems="center" flexDirection="column" gap="2rem" sx={{mt: '2rem'}}>
      {/* <Feed content={context1} type="POST" />
      <Feed content={context3} type="EVENT" />
      <Feed content={context3} type="POST" />
      <Feed content={context3} type="POST" />
      <Feed content={context3} type="EVENT" />
      <Feed content={context3} type="FORM" /> */}
      {events && events.map(e => <Feed content={e.event?.name!} type="EVENT" formData={null}/>)}
      {polls && polls.map(p => <Feed content={p.poll?.name!} type="FORM" formData={p.poll}/>)}
      {posts && posts.map(p => <Feed content={p.message} type="POST" formData={null}/>)}
      <AddNewFeed></AddNewFeed>
    </Box>
  )
}

export default MyGroupPage