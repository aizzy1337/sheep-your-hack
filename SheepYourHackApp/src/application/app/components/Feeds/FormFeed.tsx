import { Box, FormControl, FormControlLabel, FormLabel, Paper, Radio, RadioGroup, Typography } from '@mui/material'
import React from 'react'

interface Props {
    content: string,
}

const FormFeed = ({content}: Props) => {
  return (
    <Box width="100%" display="flex" flexDirection="column" justifyContent="center" alignItems="center" sx={{mt: '1rem', mb: '1rem', gap: "2rem"}} >
        <Typography textAlign="justify" sx={{width: "90%"}} variant="body1">{content}</Typography>
        <Box sx={{width: "90%"}}>
            <FormControl>
                <FormLabel>Na jaką kuchnie masz dziś ochote?</FormLabel>
                <RadioGroup
                    defaultValue="Tajskie"
                    name="radio-buttons-group"
                >
                    <FormControlLabel value="Tajskie" control={<Radio />} label="Tajskie" />
                    <FormControlLabel value="Chińskie" control={<Radio />} label="Chińskie" />
                    <FormControlLabel value="Indyjskie" control={<Radio />} label="Indyjskie" />
                </RadioGroup>
            </FormControl>
        </Box>

    </Box>
  )
}

export default FormFeed
