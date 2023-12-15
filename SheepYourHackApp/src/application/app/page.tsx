import Image from 'next/image'

export default async function Home() {

  const res = await fetch('http://localhost:5002/api/echo');
  

 

  return (
    <div>Hej</div>
  )
}
