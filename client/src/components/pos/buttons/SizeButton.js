import { Button } from 'react-bootstrap'
import Utility from '../../../utility';

const utility = new Utility();
const SizeButton = ({ size, setItemBuilder, itemBuilder }) => {
    const handleClick = () => {
        const copy = { ...itemBuilder }
        copy.sizeId = size.id;
        setItemBuilder(copy);
    }

    return (
        <Button onClick={() => { handleClick() }}>
            {utility.capitalizeEveryFirstLetter(size.name)}
        </Button>
    )
}

export default SizeButton; 