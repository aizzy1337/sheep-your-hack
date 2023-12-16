import { Poll } from '@/app/types'
import { Box, FormControl, FormControlLabel, FormLabel, Paper, Radio, RadioGroup, Typography } from '@mui/material'
import React from 'react'
import { Poll } from '@/app/types'

interface Props {
    content: string,
    formData: Poll
}

const FormFeed = ({content, formData}: Props) => {
  return (
    <Box width="100%" display="flex" flexDirection="column" justifyContent="center" alignItems="center" sx={{mt: '1rem', mb: '1rem', gap: "2rem"}} >
        <Typography textAlign="justify" sx={{width: "90%"}} variant="body1">{content}</Typography>
        <Box sx={{width: "90%"}}>
            <FormControl>
                <FormLabel>{formData.name}</FormLabel>
                <RadioGroup
                    defaultValue={formData.options[0]}
                    name="radio-buttons-group"
                >
                    {formData.options.map(o => <FormControlLabel key={o.id} value={o.name} control={<Radio />} label={o.name} />)}
                </RadioGroup>
            </FormControl>
        </Box>

    </Box>
  )
}

export default FormFeed
