'use client'
import React from 'react';
import Box from '@mui/material/Box';
import Feed from '../components/Feeds/Feed';
import { styled } from '@mui/system';
import AddNewFeed from '../components/AddNewFeed/AddNewFeed';

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

  let context1 = 'Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker'
  let context2 = 'Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMakerLorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker'
  let context3 = 'Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle '



  return (
    // <Box display='flex' maxHeight='90vh' width='100vw'>
    //   <StyledBox
    //     display='flex'
    //     justifyContent='center'
    //     width='100%'
    //     padding='10px'
    //   >
    //     <Box display={'flex'}
    //       flexDirection='column'
    //       style={{ gap: 20 }}
    //       margin="30px"
    //     >
    //       <Feed content={context1} type="POST" />
    //       <Feed content={context3} type="EVENT" />
    //       <Feed content={context2} type="POST" />
    //       <Feed content={context1} type="POST" />
    //       <Feed content={context3} type="EVENT" />
    //     </Box>
    //     <Box display={'flex'}
    //       flexDirection='column'
    //       style={{ gap: 20 }}
    //       margin="30px"
    //     >
    //       <Feed content={context2} type="EVENT" />
    //       <Feed content={context1} type="POST" />
    //       <Feed content={context3} type="POST" />
    //       <Feed content={context3} type="EVENT" />
    //       <Feed content={context1} type="POST" />
    //     </Box>
    //   </StyledBox>
    //   <AddNewFeed />
    // </Box>
    <Box width="100%" display="flex" alignItems="center" flexDirection="column" gap="2rem" sx={{mt: '2rem'}}>
      <Feed content={context1} type="POST" />
      <Feed content={context3} type="EVENT" />
      <Feed content={context3} type="POST" />
      <Feed content={context3} type="POST" />
      <Feed content={context3} type="EVENT" />
      <Feed content={context3} type="FORM" />
      <AddNewFeed></AddNewFeed>
    </Box>
  )
}

export default MyGroupPage