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
                   $query = "SELECT `shift_id` FROM `assignedworkshifts` WHERE Employee_ID = $id";
                   $stmt = $this -> connect() -> query($query);

                   while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
                   {
                       $_SESSION['sess_shift'] = $row['shift_id'];
                   }
               }
               catch (PDOException $e) 
               {
                echo "Error : ".$e->getMessage();
               }
           }
    }
}
?>