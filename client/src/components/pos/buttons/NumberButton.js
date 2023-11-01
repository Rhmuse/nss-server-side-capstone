import { Button } from 'react-bootstrap'

const NumberButton = ({ value, setItemBuilder, itemBuilder }) => {
    const handleClick = () => {
        const copy = { ...itemBuilder };
        copy.quantity += value;
        setItemBuilder(copy);
    }

    return (
        <Button className="posButton" onClick={() => handleClick()}>
            {value}
        </Button>
    )
}

export default NumberButton;