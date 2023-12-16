export type Feeds  = {
    id: number,
    message: string,
    type: number,
    userId: number,
    userNickname: string,
    creationDate: string,
    event: Event | null,
    poll: Poll | null
}

export type Event = {
    id: number,
    name: string,
    startDate: Date,
    endDate: Date,
    organization: string,
    type: number
}

export type Poll = {
    id: number,
    name: string,
    options: Option[]
}

export type Option = {
    id: number,
    name: string
}