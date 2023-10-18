import { Table } from 'react-bootstrap';
import Clock from '../Clock';

const LoggedInUserDetails = ({ loggedInUser }) => {


    return (
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
    )
}

export default LoggedInUserDetails;