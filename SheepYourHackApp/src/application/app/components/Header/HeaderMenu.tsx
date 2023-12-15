import { Button} from '@mui/material'
import Grid from '@mui/material/Grid'; 
import React from 'react'
import Container from '@mui/material/Container';


const HeaderMenu = () => {
  return (
      <Grid container spacing={2}>
        <Grid item>
          <Button variant="contained">Moja grupa</Button>
        </Grid>
        <Grid item>
        <Button variant="contained">Kalendarz</Button>
        </Grid>
      </Grid>
  )
}

export default HeaderMenu