<?php 
class employeeList extends dbConnection
{
    public function ShowEmployees()
    {
       try
       {
           $query = "SELECT * FROM `employees`";
           $stmt = $this -> connect() -> query($query);
           echo "<table border = '1' class='styled-table-employee'>
                <tr>
                <th>ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Date of Birth</th>
                <th>BSN</th>
                <th>Email</th>
                <th>Phone Number</th>
                <th>City</th>
                <th>Country</th>
                <th>Date of Join</th>
                <th>Employee Role</th>
                <th>Contract Type</th>
                </tr>";
           while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
           {
               echo "<tr>";
               echo "<td>".$row['Employee_ID']."</td>";
               echo "<td>".$row['FirstName']."</td>";
               echo "<td>".$row['LastName']."</td>";
               echo "<td>".$row['DateOfBirth']."</td>";
               echo "<td>".$row['BSN']."</td>";
               echo "<td>".$row['Email']."</td>";
               echo "<td>".$row['PhoneNumber']."</td>";
               echo "<td>".$row['City']."</td>";
               echo "<td>".$row['Country']."</td>";
               echo "<td>".$row['DateOfJoin']."</td>";
               echo "<td>".$row['EmployeeType']."</td>";
               echo "<td>".$row['ContractType']."</td>";
               echo "</tr>";
           }
           echo "</table>";
       }
       catch (PDOException $e) 
       {
        echo "Error : ".$e->getMessage();
       }
    }
    public function ShowFiredEmployees()
    {
       try
       {
           $query = "SELECT * FROM `firedemployees`";
           $stmt = $this -> connect() -> query($query);
           echo "<table border = '1' class='styled-table-employee'>
                <tr>
                <th>ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Employee Role</th>
                <th>Contract Type</th>
                <th>Date of Resignation</th>

                </tr>";
           while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
           {
               echo "<tr>";
               echo "<td>".$row['ID']."</td>";
               echo "<td>".$row['FirstName']."</td>";
               echo "<td>".$row['LastName']."</td>";
               echo "<td>".$row['EmpType']."</td>";
               echo "<td>".$row['ContractType']."</td>";
               echo "<td>".$row['DateOfResign']."</td>";

               echo "</tr>";
           }
           echo "</table>";
       }
       catch (PDOException $e) 
       {
        echo "Error : ".$e->getMessage();
       }
    }
}
?>