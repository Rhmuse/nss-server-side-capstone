import { Button } from 'react-bootstrap'
import { capitalizeEveryFirstLetter } from '../../../utility';

const SizeButton = ({ size, setItemBuilder, itemBuilder }) => {
    const handleClick = () => {
        const copy = { ...itemBuilder }
        copy.sizeId = size.id;
        setItemBuilder(copy);
    }

    return (
        <Button className='posButton' onClick={() => { handleClick() }}>
            {capitalizeEveryFirstLetter(size.name)}
        </Button>
    )
}

export default SizeButton; 