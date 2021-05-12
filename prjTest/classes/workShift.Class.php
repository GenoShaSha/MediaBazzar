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
                   $queryGetShiftID = "SELECT `shift_id` FROM `assignedworkshifts` WHERE Employee_ID = $id";
                   $stmt1 = $this -> connect() -> prepare($queryGetShiftID);
                   $stmt1 -> execute();
                   $resultShiftID = $stmt1 -> fetch(PDO::FETCH_ASSOC);
             

                   //$shiftID = $resultShiftID['shift_id'];
                   $queryGetShift = "SELECT * FROM `shifts` WHERE `shift_id` = 3";
                   $stmt2 = $this -> connect() -> prepare($queryGetShift);
                   $stmt2 -> execute();
                   $resultShift = $stmt2 -> fetch(PDO::FETCH_ASSOC);

                   $_SESSION['sess_date'] = $resultShift['date'];
                   $_SESSION['sess_type'] = $resultShift['type'];
                   $_SESSION['sess_shift_id'] = $resultShift['shift_id'];

               }

               catch (PDOException $e) 
               {
                echo "Error : ".$e->getMessage();
               }
           }
    }
}
?>