import { useEffect, useState } from 'react';

const date = new Date();

const Clock = () => {
    const [dateTime, setDateTime] = useState({
        hours: date.getHours(),
        minutes: date.getMinutes(),
        seconds: date.getSeconds()
    });

    useEffect(() => {
        const timer = setInterval(() => {
            const date = new Date();

            setDateTime({
                hours: date.getHours(),
                minutes: date.getMinutes(),
                seconds: date.getSeconds()
            });
        }, 1000);
        return () => clearInterval(timer);
    }, []);

    const appendZero = (n) => {
        if (`${n}`.length === 1) {
            return `0${n}`
        }
        return n;
    }

    return (
        <>
            {dateTime.hours}:{appendZero(dateTime.minutes)}:{appendZero(dateTime.seconds)}
        </>
    )
}

export default Clock; 