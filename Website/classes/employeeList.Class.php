<?php 
class employeeList extends dbConnection
{
    public function ShowEmployees()
    {
       try
       {
           $query = "SELECT * FROM `employees`";
           $stmt = $this -> connect() -> query($query);
           echo "<table border = '1'>
                <tr>
                <th>Employee ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Date of Birth</th>
                <th>BSN</th>
                <th>Gender</th>
                <th>Relationship</th>
                <th>Email</th>
                <th>Phone Number</th>
                <th>Address</th>
                <th>Postal Code</th>
                <th>City</th>
                <th>Country</th>
                <th>Date of Join</th>
                <th>Employee Role</th>
                </tr>";
           while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
           {
               echo "<tr>";
               echo "<td>" . $row['Employee_ID'] . "</td>";
               echo "<td>".$row['FirstName']."</td>";
               echo "<td>".$row['LastName']."</td>";
               echo "<td>".$row['DateOfBirth']."</td>";
               echo "<td>".$row['BSN']."</td>";
               echo "<td>".$row['Gender']."</td>";
               echo "<td>".$row['Relationship']."</td>";
               echo "<td>".$row['Email']."</td>";
               echo "<td>".$row['PhoneNumber']."</td>";
               echo "<td>".$row['Address']."</td>";
               echo "<td>".$row['PostalCode']."</td>";
               echo "<td>".$row['City']."</td>";
               echo "<td>".$row['Country']."</td>";
               echo "<td>".$row['DateOfJoin']."</td>";
               echo "<td>".$row['EmployeeType']."</td>";
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