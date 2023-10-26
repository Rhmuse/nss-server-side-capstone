import { Button, Row, Table } from 'react-bootstrap';
import Clock from '../Clock';
import { logout } from '../../managers/authManager';

const LoggedInUserDetails = ({ loggedInUser, setLoggedInUser }) => {


    return (
        <Row id='userDetailsRow'>
            <Button
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
            <Table bordered style={{ width: "80%" }}>
                <tbody>
                    <tr>
                        <td>Name: {loggedInUser.firstName} {loggedInUser.lastName}</td>
                        <td>Time: <Clock /></td>
                    </tr>
                    <tr>
                        <td>Id: {loggedInUser.id}</td>
                        <td>Role: {loggedInUser.roles[0]}</td>
                    </tr>
                </tbody>
            </Table>
        </Row>
    )
}

export default LoggedInUserDetails;