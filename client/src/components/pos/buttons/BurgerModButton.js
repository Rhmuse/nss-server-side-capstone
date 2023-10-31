import { Button } from 'react-bootstrap'
import { capitalizeEveryFirstLetter } from '../../../utility';

const BurgerModButton = ({ topping }) => {
    return (
        <Button className='posButton'>{capitalizeEveryFirstLetter(topping.name)}</Button>
    )
}

export default BurgerModButton;