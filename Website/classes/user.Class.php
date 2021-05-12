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
                $query = "SELECT * FROM `employees` WHERE `Email` = :username AND `Password` = :password";
                $stmt = $this -> connect() -> prepare($query);
                $stmt -> bindParam(':username', $username, PDO::PARAM_STR);
                $stmt -> bindValue(':password', $password, PDO::PARAM_STR);
                $stmt ->execute();
                $count = $stmt -> rowCount();
                $row = $stmt -> fetch(PDO::FETCH_ASSOC);
                if($count == 1 && !empty($row))
                {
                    $_SESSION['sess_user_id'] = $row['Employee_ID'];
                    $_SESSION['sess_email'] = $row['Email'];
                    $_SESSION['sess_password'] = $row['Password'];
                    $_SESSION['sess_role'] = $row['EmployeeType'];
                    if($_SESSION['sess_role'] == "Administrator" )
                    {
                        header('location:retrieveInfo.php');
                    }
                    else
                    {
                        header('location:retrieveInfo.php');
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
    public function RetrieveEmployeeInfo()
    {
        if(isset($_SESSION['sess_user_id']))
        {
            try
            {
                $id = $_SESSION['sess_user_id'];
                $query = "SELECT * from `employees` where Employee_ID = $id limit 1";
                $stmt = $this -> connect() -> prepare($query);
                $stmt -> execute();
                $result = $stmt -> fetch(PDO::FETCH_ASSOC);
                $_SESSION['sess_user_id'] = $result['Employee_ID'];
                $_SESSION['sess_first_name'] = $result['FirstName'];
                $_SESSION['sess_last_name'] = $result['LastName'];
                $_SESSION['sess_date_of_birth'] = $result['DateOfBirth'];
                $_SESSION['sess_BSN'] = $result['BSN'];
                $_SESSION['sess_gender'] = $result['Gender'];
                $_SESSION['sess_relationship'] = $result['Relationship'];
                $_SESSION['sess_email'] = $result['Email'];
                $_SESSION['sess_pass'] = $result['Password'];
                $_SESSION['sess_phone_number'] = $result['PhoneNumber'];
                $_SESSION['sess_address'] = $result['Address'];
                $_SESSION['sess_postal_code'] = $result['PostalCode'];
                $_SESSION['sess_city'] = $result['City'];
                $_SESSION['sess_country'] = $result['Country'];

            }
            catch (PDOException $e) 
            {
                echo "Error : ".$e->getMessage();
            }
           
        }
        header('location:floorEmployees.php?signedIn');
    }

public function UpdateInformation()
{
    if(isset($_POST['updateBtn']))
    {
        $firstName = $_POST['first_name'];
        $lastName = $_POST['last_name'];
        $bsn = $_POST['bsn'];
        $gender = $_POST['gender'];
        $relationship = $_POST['relationship'];
        $email = $_POST['email'];
        $pswd = $_POST['password'];
        $pNumber = $_POST['phone_number'];
        $address = $_POST['address'];
        $pCode = $_POST['postal_code'];
        $city = $_POST['city'];
        $country = $_POST['country'];

       
        if($firstName == "")
        {
            $firstName = $_SESSION['sess_first_name'];
        }
        if($lastName == "")
        {
            $lastName = $_SESSION['sess_last_name'];
        }
        if($bsn == "")
        {
            $bsn = $_SESSION['sess_BSN'];
        }
        if($gender == "")
        {
            $gender = $_SESSION['sess_gender'];
        }
        if($relationship == "")
        {
            $relationship = $_SESSION['sess_relationship'];
        }
        if($email == "")
        {
            $email = $_SESSION['sess_email'];
        }
        if($pswd == "")
        {
            $pswd = $_SESSION['sess_pass'];
        }
        if($pNumber == "")
        {
            $pNumber = $_SESSION['sess_phone_number'];
        }
        if($address == "")
        {
            $address = $_SESSION['sess_address'];
        }
        if($pCode == "")
        {
            $pCode =$_SESSION['sess_postal_code'];
        }
        if($city == "")
        {
            $city = $_SESSION['sess_city'];
        }
        if($country == "")
        {
            $country =   $_SESSION['sess_country'];
        }
        try
        {
            $query = "UPDATE `employees` SET `FirstName`= ? ,`LastName`= ?,`BSN`= ?,`Gender`= ?,`Relationship`= ?,`Email`= ?,`Password`= ?,`PhoneNumber`= ?,`Address`= ?,`PostalCode`= ?,`City`= ?,`Country`= ? WHERE `Employee_ID` = $_SESSION[sess_user_id]";
            $stmt = $this -> connect() -> prepare($query);
            $stmt -> execute([$firstName,$lastName, $bsn, $gender, $relationship, $email, $pswd, $pNumber, $address, $pCode, $city, $country]);
            header('location:retrieveInfo.php');  
        }
        catch (PDOException $e)
        {
            echo "Error : ".$e->getMessage();
        }
    } 
}
}
?>