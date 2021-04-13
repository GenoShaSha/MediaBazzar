<?php
class user extends dbConnection
{
    public function SubmitCredentials()
    {
        if (isset ($_POST['addBtn']))
        {
            $username = trim($_POST['usrName']);
            $password = trim($_POST['password']);
            try
            {
                $query = "SELECT * FROM `signin` WHERE `Username` = :username AND `Password` = :password";
                $stmt = $this -> connect() -> prepare($query);
                $stmt -> bindParam(':username', $username, PDO::PARAM_STR);
                $stmt -> bindValue(':password', $password, PDO::PARAM_STR);
                $stmt ->execute();
                $count = $stmt -> rowCount();
                $row = $stmt -> fetch(PDO::FETCH_ASSOC);
                if($count == 1 && !empty($row))
                {
                    $_SESSION['sess_user_id'] = $row['EmployeeID'];
                    $_SESSION['sess_user_name'] = $row['Username'];
                    $_SESSION['sess_password'] = $row['Password'];
                    $_SESSION['sess_role'] = $row['EmployeeType'];
                    if($_SESSION['sess_role'] == "admin" )
                    {
                        header('location:floorEmployees.php?signedIn');
                    }
                    else
                    {
                        header('location:floorEmployees.php?signedIn');
                    }
                    
                }
                else
                {
                    header('location:signIn.php?error');
                }

            }
            catch (PDOException $e) {
                echo "Error : ".$e->getMessage();
              }
        }
    }
}
?>