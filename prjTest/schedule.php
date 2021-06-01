<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
include 'classes/workShift.Class.php';
$workShift = new workShift();
$workShift -> GetShifts();
$db = new dbConnection();

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=<device-width>, initial-scale=1.0">
    <title>TagsPage</title>
    <link rel="stylesheet" href="styles\mainstyles.css">

</head>
<div class="navigation">
        <a href="floorEmployees.php?signedIn">HOME</a>
        <input type="text" placeholder="Search...">
        <a href="RetrieveInfo.php">PERSONAL INFO</a>             
    </div>
<body>
    <?php 
    if (isset($_GET['signedIn'])) { 
    ?>
    <div class="topnav">
        <a href="signOut.php">Sign Out</a>
        <a><?php echo "WELCOME ".$_SESSION["sess_user_name"]?></a>
    </div>               
    <?php } ?>
 
    <div class="header">
        <h1> MediaBazaar </h1>
    </div>
    <br>
    <h1> Your Workweek </h1>
    <table class="styled-table">
    <thead>
        <tr>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
            <th>Thursday</th>
            <th>Friday</th>
            <th>Saturday</th>
            <th>Sunday</th>
        </tr>
    </thead>
    <tbody>
        <tr>
		        <td><?php echo $_SESSION['sess_shift']; ?></td>
                <td><?php echo $_SESSION['sess_shift']; ?></td>
		        <td><?php echo $_SESSION['sess_shift']; ?></td>
		        <td><?php echo $_SESSION['sess_shift']; ?></td>
		        <td><?php echo $_SESSION['sess_shift']; ?></td>
		        <td><?php echo $_SESSION['sess_shift']; ?></td>
		        <td><?php echo $_SESSION['sess_shift']; ?></td>

        </tr>
    </tbody>
</table>
<br>
<hr>
<br>
<h1>Set Your Prefference </h1>
<table class="styled-table">
    <thead>
        <tr>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
            <th>Thursday</th>
            <th>Friday</th>
            <th>Saturday</th>
            <th>Sunday</th>
        </tr>
    </thead>
    <tbody>
        <tr>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
                <td onclick="changeColor(this)" id="DayTime">Morning</td>
        </tr>
        <tr>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
                <td onclick="changeColor(this)" id="DayTime">Evening</td>
        </tr>
        <tr>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
                <td onclick="changeColor(this)" id="DayTime">Afternoon</td>
        </tr>   
    </tbody>
</table>
<br>
<button type="submit" name="updatePrefference" class="btn">Update your Prefference!</button>

    <br>

    <?php 
    if (isset($_GET['signedIn'])) { 
    ?>
    <div class="navigation">
        <a href="#">HOME</a>
        <a href="#">SCHEDULE</a>
        <input type="text" placeholder="Search...">
        <a href="RetrieveInfo.php">PERSONAL INFO</a>             
    </div>
    <?php } ?>
    
    <!-- <input id="userName" type="hidden" name="name" value="<?php echo "".$_SESSION["sess_user_name"]?>"> -->

    <?php 
    if( $_SESSION['sess_role'] == "Administrator")
    {
        echo "<h1>Employee List</h1>";
        $employeeList ->ShowEmployees();
    }
    ?>
 </body>
 </html>
    <script src="js/main.js" type="text/javascript"></script>