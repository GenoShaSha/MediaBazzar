<?php 
class workShift extends dbConnection
{
    public function GetShifts()
    {
           if(isset($_SESSION['sess_user_id']))
           {          
               try
               {
                   $id = $_SESSION['sess_user_id'];

                   $query1 = "SELECT `shift_id` FROM `assignedworkshifts` WHERE Employee_ID = $id";
                   $stmt1 = $this -> connect() -> query($query1);

                   $query2 = "SELECT * FROM `shifts` WHERE `shift_id` = 3";
                   $stmt2 = $this -> connect() -> query($query2);

                   
                   while ($row = $stmt2->fetch(PDO::FETCH_ASSOC))
                   {
                       $_SESSION['sess_shift'] = $row['type'];
                   }
               }
               catch (PDOException $e) 
               {
                echo "Error : ".$e->getMessage();
               }
           }
    }
    public function UpdatePreference()
    {
           if(isset($_POST['UpdatePreference']))
           {          
               try
               {
                   $id = $_SESSION['sess_user_id'];
                   $preferenceNumber = $_POST['PreferenceValue'];

                   $query = "UPDATE `employees` SET `Preference` = $preferenceNumber WHERE Employee_ID = $id";
                   $stmt = $this -> connect() -> query($query);
                   $stmt ->execute();
                }
               catch (PDOException $e) 
               {
                echo "Error : ".$e->getMessage();
               }
           }
    }
}
?>