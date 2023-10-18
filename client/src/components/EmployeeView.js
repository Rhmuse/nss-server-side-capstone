import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from './auth/AuthorizedRoute';

const EmployeeView = ({ loggedInUser }) => {
    return (
        <Routes>
            <Route path="/">
                <Route
                    index
                    element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <>Employee View</>
                        </AuthorizedRoute>
                    }
                />
            </Route>
        </Routes>
    )
}

export default EmployeeView; 