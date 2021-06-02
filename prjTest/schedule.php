<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
include 'classes/workShift.Class.php';
$workShift = new workShift();
$workShift -> GetShifts();
$workShift -> UpdatePreference();
$db = new dbConnection();

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=<device-width>, initial-scale=1.0">
    <title>TagsPage</title>
    <link rel="stylesheet" href="styles\mainstyles.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
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
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning1">Morning</td>
                <input id="Morning1Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning2">Morning</td>
                <input id="Morning2Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning3">Morning</td>
                <input id="Morning3Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning4">Morning</td>
                <input id="Morning4Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning5">Morning</td>
                <input id="Morning5Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning6">Morning</td>
                <input id="Morning6Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Morning7">Morning</td>
                <input id="Morning7Value" type="hidden" value="0">
        </tr>
        <tr>
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening1">Evening</td>
                <input id="Evening1Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening2">Evening</td>
                <input id="Evening2Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening3">Evening</td>
                <input id="Evening3Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening4">Evening</td>
                <input id="Evening4Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening5">Evening</td>
                <input id="Evening5Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening6">Evening</td>
                <input id="Evening6Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Evening7">Evening</td>
                <input id="Evening7Value" type="hidden" value="0">
        </tr>
        <tr>
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon1">Afternoon</td>
                <input id="Afternoon1Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon2">Afternoon</td>
                <input id="Afternoon2Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon3">Afternoon</td>
                <input id="Afternoon3Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon4">Afternoon</td>
                <input id="Afternoon4Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon5">Afternoon</td>
                <input id="Afternoon5Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon6">Afternoon</td>
                <input id="Afternoon6Value" type="hidden" value="0">
                <td onclick="changeColor(this,this.id)" class="DayTime" id="Afternoon7">Afternoon</td>
                <input id="Afternoon7Value" type="hidden" value="0">
        </tr>   
    </tbody>
</table>
<br>

<form  method="POST">
<input id="PreferenceValue" name="PreferenceValue" type="hidden">
<button type="submit" name="UpdatePreference" class="btn">Update your Preference!</button>
</form>

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