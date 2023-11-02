import currency from 'currency.js';
import { Col, Container, Row } from 'react-bootstrap';
import "./PreviousOrdersList.css";
import { useEffect, useState } from 'react';

const PreviousOrdersList = ({ orders }) => {
    const [previousOrders, setPreviousOrders] = useState([]);

    const renderOrders = () => {
        let previousOrdersTemp = [];
        for (let i = 0; i < 2; i++) {
            const o = orders[i];
            if (o) {
                let [date, time] = o.orderTime.split("T")
                let [formatedTime,] = time.split(".")
                previousOrdersTemp.push(
                    <Container key={`order-${o.id}`}>
                        <Row className='orderListId'>&#x2022;{o.id}</Row>
                        <Row className='orderListDetails'>
                            <Col>{date}</Col>
                            <Col>{formatedTime}</Col>
                            <Col>{currency(o.total).format()}</Col>
                        </Row>
                    </ Container>
                )
            }
        }
        setPreviousOrders(previousOrdersTemp);
    }

    useEffect(() => {
        renderOrders()
    }, [orders])
    return (
        <Container id="previousOrdersContainer">
            <h3>Previous Orders</h3>
            <Row>
                <Col>
                    {previousOrders}
                </Col>
            </Row>
        </ Container>
    )
}

export default PreviousOrdersList;