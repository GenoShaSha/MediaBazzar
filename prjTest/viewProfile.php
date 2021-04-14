<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
$user = new user();
?>

<!DOCTYPE html>
<html lang="en" > 
    <head>
        <meta charset="utf-8">
        <title>Profile</title>
        <link rel="stylesheet" href="styles\profile_authentication_styles.css">
    </head> 
    <body>
        <div class="topnav">
        <a href="retrieveInfo.php">PERSONAL INFO</a>
        <a href="signOut.php">SIGN OUT</a>
        </div>
        <div class="header">
            <h1> MediaBazaar </h1>
        </div>
        <div class="navigation">
            <a href="floorEmployees.php?signedIn">HOME</a>
            <a href="#">SCHEDULE</a>
            <input type="text" placeholder="Search...">
            <a href="viewProfile.php">PERSONAL INFO</a>
        </div>
        <div class="centerProfile" style = "position: absolute; top: 600px">
            <h1><?php echo  $_SESSION['sess_first_name'] ?> (<?php echo  $_SESSION['sess_role'] ?>) </h1>
            <div class = "txt_field"> 
                <p> First Name: <?php echo $_SESSION['sess_first_name'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Last Name: <?php echo $_SESSION['sess_last_name'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Date of Birth: <?php echo $_SESSION['sess_date_of_birth'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> BSN: <?php echo $_SESSION['sess_BSN'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Gender: <?php echo $_SESSION['sess_gender'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Relationship: <?php echo $_SESSION['sess_relationship'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Email: <?php echo $_SESSION['sess_email'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Phone Number: <?php echo $_SESSION['sess_phone_number'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Address: <?php echo $_SESSION['sess_address'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <p> Postal Code: <?php echo $_SESSION['sess_postal_code'] ?></p> 
            </div>
            <div class = "txt_field"> 
            <p> City: <?php echo $_SESSION['sess_city'] ?></p> 
            </div>
            <div class = "txt_field"> 
                <p> Country: <?php echo $_SESSION['sess_country'] ?> </p> 
            </div>
            <div class = "txt_field"> 
                <a href = "editProfile.php"> Edit profile</a>
            </div>
        </div>
    </body>
</html>     
