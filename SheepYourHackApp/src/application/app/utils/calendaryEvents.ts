interface Event {
    title: string,
    place: string,
    day: string,
    hour: string,
    workTime: string
}

export const groupEventsByDay = (tab: Event[]) => {
    const uniqueArray = [];

  for (let i = 0; i < tab.length; i++) {
    const currentValue = tab[i].day;
    if (uniqueArray.indexOf(currentValue) === -1) {
        uniqueArray.push(currentValue);
      }
    }
    return uniqueArray;
}
    