import EmployeeView from './EmployeeView';
import CustomerView from './CustomerView';
import NavBar from '../NavBar';

export default function ApplicationViews({ loggedInUser, setLoggedInUser }) {
  if (loggedInUser?.roles?.includes("Employee") || loggedInUser?.roles?.includes("Admin")) {
    return (
      <EmployeeView loggedInUser={loggedInUser} />
    )
  }
  return (
    <>
      <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
      <CustomerView loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
    </>
  );
}
