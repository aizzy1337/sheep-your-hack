'use client'
import React, {useState, useEffect} from 'react';
import Box from '@mui/material/Box';
import Feed from '../components/Feeds/Feed';
import { styled } from '@mui/system';
import AddNewFeed from '../components/AddNewFeed/AddNewFeed';
import { Feeds } from '../types';
import { pollName } from '../addText';

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
  const [feeds, setFeeds] = useState<Feeds[]>()

  const fetchFeeds = async () => {
    const res = await fetch('https://localhost:5003/api/Feeds/1', {next: {revalidate: 0}})
    const data = await res.json()
    setFeeds(data)
  }

  useEffect(()=> {
    fetchFeeds()
  },[])

  const events = feeds ? feeds.filter(f => f.event) : null
  const polls = feeds ? feeds.filter(f => f.poll) : null
  const posts = feeds ? feeds.filter(f => !f.poll && !f.event) : null

  var x = -1;

  return (
    <Box width="100%" display="flex" alignItems="center" flexDirection="column" gap={6} sx={{mt: '2rem'}}>
      <Box width="100%" display="flex" alignItems="center" flexDirection="column" gap="2rem" sx={{mt: '2rem'}}>
        {events && events.map(e => {
          x += 1;
        return <Feed hashtagId={x % 3} content={e.message!} type="EVENT" formData={null}/>
        })}
        {polls && polls.map(p => {
          x += 1;
        return <Feed hashtagId={x % 4} content={pollName} type="FORM" formData={p.poll}/>
        })}
        {posts && posts.map(p => {
          x += 1;
        return <Feed hashtagId={x % 4} content={p.message} type="POST" formData={null}/>
        })}
        <AddNewFeed></AddNewFeed>
      </Box>
    </Box>
  )
}
export default MyGroupPage;