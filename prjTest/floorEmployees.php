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
</head>

<body>
    <?php 
    if (isset($_GET['signedIn'])) { 
    ?>
    <div class="topnav">
        <a href="signOut.php">Sign Out</a>
        <a><?php echo "WELCOME ".$_SESSION["sess_email"]?></a>
    </div>               
    <?php } ?>
 
    <div class="header">
        <h1> MediaBazaar </h1>
    </div>

    <?php 
    if (isset($_GET['signedIn'])) { 
    ?>
    <div class="navigation">
        <a href="#">HOME</a>
        <a href="schedule.php">SCHEDULE</a>
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