import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import HeaderIcons from './HeaderIcons';
import Image from 'next/image';
import logo from '../../../public/logo.png';
import Link from 'next/link';

const Header = () => {
  return (
    <Box sx={{ flexGrow: 1 }} >
      <AppBar position="static" color="secondary">
        <Toolbar>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            <Box sx={{display: 'flex'}}>
              <Link id="linklogo" href="/my-group">
                <Image
                  src={logo}
                  alt="LOGO"
                  width={0}
                  height={0}
                  style={{ width: '60px', height: 'auto' }}
                />
              </Link>
            </Box>
          </Typography>
          <HeaderIcons />
        </Toolbar>
      </AppBar>
    </Box>
  );
}

export default Header