import { Button, Col, Container, Row, Table } from 'react-bootstrap';
import { capitalizeEveryFirstLetter } from '../../../../utility';
import CategorySelect from '../../CategorySelect';
import { useNavigate } from 'react-router-dom';

const OrdersList = ({ orders, selectedCategory, setSelectedCategory, menuItems }) => {
    const navigate = useNavigate();

    return (
        <Container>
            <h1>Orders</h1>
            <Row id='adminToolsCategoryRow'>
                <Col>
                    <CategorySelect menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                </Col>
                <Col>
                </Col>
                <Col className='adminTools-col3'>
                    <Button className='posButton' onClick={() => { navigate("/") }}>Return to POS</Button>
                </Col>
            </Row>
            <Row>

                <Table bordered striped responsive className='adminToolsTable'>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Date</th>
                            <th>Employee</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            orders.map(o => {
                                let [date, time] = o.orderTime.split("T")
                                let [formatedTime,] = time.split(".")
                                return (
                                    <tr key={`adminToolsOrder-${o.id}`}>
                                        <td>{o.id}</td>
                                        <td>{date} at {formatedTime}</td>
                                        <td>{capitalizeEveryFirstLetter(o.employee.firstName + " " + o.employee.lastName)}</td>
                                        <td><Button className='posButton' onClick={() => navigate(o.id)}>Details</Button></td>
                                    </tr>
                                )
                            })
                        }
                    </tbody>
                </Table>
            </Row>
        </Container>
    )
}

export default OrdersList;