import { Button, Col, Row, Table } from 'react-bootstrap';
import Clock from '../Clock';
import { logout } from '../../managers/authManager';

import './LoggedInUserDetail.css';

const LoggedInUserDetails = ({ loggedInUser, setLoggedInUser }) => {


    return (
        <Row id='userDetailsRow'>
            <Col sm md lg xl="2">
                <Button
                    className='posButton'
                    color="primary"
                    onClick={(e) => {
                        e.preventDefault();
                        logout().then(() => {
                            setLoggedInUser(null);
                        });
                    }}
                >
                    Logout
                </Button>
            </Col>
            <Col id="detailsCol">
                <Row>
                    <Col>
                        <Row>Name: {loggedInUser.firstName} {loggedInUser.lastName}</Row>
                        <Row>Time: <Clock /></Row>
                    </Col>
                    <Col>
                        <Row>Id: {loggedInUser.id}</Row>
                        <Row>Role: {loggedInUser.roles[0]}</Row>
                    </Col>
                </Row>
            </Col>
        </Row>
    )
}

export default LoggedInUserDetails;