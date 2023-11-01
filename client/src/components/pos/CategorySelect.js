import { Form } from 'react-bootstrap';
import { capitalizeEveryFirstLetter } from '../../utility';
import { useNavigate } from 'react-router-dom';

const CategorySelect = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    let categoryArr = [];
    for (const category in menuItems) {
        categoryArr.push(category);
    }
    return (
        <Form.Select size="lg" onChange={(e) => { setSelectedCategory(e.target.value); navigate("/admintools") }}>
            <option key={"default-option"} value={""}>Select a category...</option>
            {
                categoryArr.map(c => {
                    return (
                        <option key={`${c}-option`} value={c}>{capitalizeEveryFirstLetter(c)}</option>
                    )
                })
            }
        </Form.Select>
    )
}

export default CategorySelect; 