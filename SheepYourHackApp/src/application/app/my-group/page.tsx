'use client'
import React, {useState, useEffect} from 'react';
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

const MyGroupPage = () => {
  const [feeds, setFeeds] = useState<Feeds[]>()

  const fetchFeeds = async () => {
    const res = await fetch('https://localhost:5003/api/Feeds/1')
    const data = await res.json()
    setFeeds(data)
  }
  useEffect(()=> {
    fetchFeeds()
  },[])

  const events = feeds ? feeds.filter(f => f.event) : null
  const polls = feeds ? feeds.filter(f => f.poll) : null
  const posts = feeds ? feeds.filter(f => !f.poll && !f.event) : null


  return (
    <Box width="100%" display="flex" alignItems="center" flexDirection="column" gap="2rem" sx={{mt: '2rem'}}>
      {events && events.map(e => <Feed content={e.event?.name!} type="EVENT" formData={null}/>)}
      {polls && polls.map(p => <Feed content={p.poll?.name!} type="FORM" formData={p.poll}/>)}
      {posts && posts.map(p => <Feed content={p.message} type="POST" formData={null}/>)}
      <AddNewFeed></AddNewFeed>
    </Box>
  )
}

export default MyGroupPage