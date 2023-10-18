import { Route, Routes } from 'react-router-dom';
import Login from '../auth/Login';
import Register from '../auth/Register';

const CustomerView = ({ loggedInUser, setLoggedInUser }) => {
    return (
        <Routes>
            <Route path="/">
                <Route
                    index
                    element={
                        <>home</>
                    }
                />
                <Route
                    path="login"
                    element={<Login setLoggedInUser={setLoggedInUser} />}
                />
                <Route
                    path="register"
                    element={<Register setLoggedInUser={setLoggedInUser} />}
                />
            </Route>
            <Route path="*" element={<p>Whoops, nothing here...</p>} />
        </Routes>
    )
}

export default CustomerView; 