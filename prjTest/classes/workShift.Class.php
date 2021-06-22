<?php 
class workShift extends dbConnection
{
    public function GetShifts()
    {
           if(isset($_SESSION['sess_user_id']))
           {          
            try
               {                           
                $monday = strtotime("last monday");
                $id = $_SESSION['sess_user_id'];

                if(isset($_POST['PreviousWeek']))
                {
                    $monday = strtotime("last monday -1 week");
                }
                if(isset($_POST['CurrentWeek']))
                {
                    $monday = strtotime("last monday");
                }
                if(isset($_POST['NextWeek']))
                {
                    $monday = strtotime("next monday");
                }
                $monday = date('w', $monday)==date('w') ? $monday+7*86400 : $monday;
                $sunday = strtotime(date("Y-m-d",$monday)." +6days");
                $this_week_sd = date("Y-m-d",$monday);
                $this_week_ed = date("Y-m-d",$sunday);
       
                $query = "SELECT * FROM `shifts` WHERE `shift_id` IN 
                (SELECT `shift_id` FROM `assignedworkshifts` WHERE Employee_ID = $id AND `date` BETWEEN '".$this_week_sd."' AND '".$this_week_ed."')";               
                $stmt = $this -> connect() -> query($query);

                echo "<h5> Current week range from $this_week_sd to $this_week_ed </h5>";
                echo "<thead>";
                echo "<tr>";
                for ($i = 0; $i < 7; $i++) {
                    $mondayWeek = strtotime(date("Y-m-d",$monday)." +".$i."days");
                    $dayWeek = date("Y-m-d",$mondayWeek);
                    echo "<th>".$dayWeek."</th>";
                }
                echo "</tr>";
                echo "</thead>";

                $rows = $stmt->fetchAll();

                echo "<tbody>"; 

                $this->GetRow("Morning", $rows, $monday);
                $this->GetRow("Afternoon", $rows, $monday);
                $this->GetRow("Night", $rows, $monday);
                echo "</tbody>";
               }
               catch (PDOException $e) 
               {
                echo "Error : ".$e->getMessage();
               }
           }
    }
    public function GetRow($input, $row, $monday)
    {
        echo "<tr>";                
                    for ($i = 0; $i < 7; $i++) {
                        echo "<td>";
                        $mondayWeek = strtotime(date("Y-m-d",$monday)." +".$i."days");
                        $dayWeek = date("Y-m-d",$mondayWeek); 
                        $count = 0;
                        foreach ($row as $shift)
                        {             
                            if($shift['date'] == $dayWeek && $shift['type'] == $input)
                            {       
                                echo $shift['type'];    
                            }   
                        }
                        echo "</td>";   
                        }
                    echo "</tr>";
    }
    
    public function UpdatePreference()
    {
           if(isset($_POST['UpdatePreference']))
           {          
               try
               {
                   $id = $_SESSION['sess_user_id'];
                   $preferenceNumber = $_POST['PreferenceValue'];

                   $query = "UPDATE `employees` SET `Preference` = :preference WHERE Employee_ID = $id";
                   $stmt = $this -> connect() -> prepare($query);
                   $stmt -> bindValue(':preference', $preferenceNumber, PDO::PARAM_STR);

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