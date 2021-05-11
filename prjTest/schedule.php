<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
include 'classes/employeeList.class.php';
$employeeList = new employeeList();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=<device-width>, initial-scale=1.0">
    <title>TagsPage</title>
    <link rel="stylesheet" href="styles\mainstyles.css">
    <link href="helpers/v2/main.css?v=2021.1.248" type="text/css" rel="stylesheet"/>

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
    <div id="dp"></div>
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

    <?php 
    if( $_SESSION['sess_role'] == "Administrator")
    {
        echo "<h1>Employee List</h1>";
        $employeeList ->ShowEmployees();
    }
    ?>
 </body>
 </html>
 <script src="js/daypilot-all.min.js"></script>
    <script src="js/main.js" type="text/javascript"></script>