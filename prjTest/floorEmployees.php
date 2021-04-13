<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
include 'classes/employeeList.class.php';
$employeeList = new employeeList();
echo var_dump($_SESSION);
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
    <div class="topNavigation">
        <a href="signOut.php">Sign Out</a>
        <a><?php echo "WELCOME ".$_SESSION["sess_user_name"]?></a>
    </div>               
    <?php } ?>
 
    <div class="header">
        <h1> MediaBazaar </h1>
    </div>

    <?php 
    if (isset($_GET['signedIn'])) { 
    ?>
    <div class="Navigation">
        <a href="index.php">HOME</a>
        <a href="#">SCHEDULE</a>
        <input type="text" placeholder="Search...">
        <a href="RetrieveInfo.php">PERSONAL INFO</a>             
    </div>
    <?php } ?>

    <?php 
    if( $_SESSION['sess_role'] == "Admin")
    {
        echo "<h1>Employee List</h1>";
        $employeeList ->ShowEmployees();
    }
    ?>
 </body>
</html>