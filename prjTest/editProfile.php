<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
$user = new user();
$user -> UpdateInformation();
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
            <a href="RetrieveInfo.php">PERSONAL INFO</a>
            <a href="signOut.php">SIGN OUT</a>
        </div>
        <div class="header">
            <h1> MediaBazaar </h1>
        </div>
        <div class="navigation">
            <a href="index.php?loggedin">HOME</a>
            <a href="#">SCHEDULE</a>
            <input type="text" placeholder="Search...">
            <a href="viewProfile.php">PERSONAL INFO</a>
        </div>
        <div class="centerProfile" style = "position: absolute; top: 600px">
            <h1>Profile</h1>
            <form method = "POST">
                <div class="txt_field">
                    <input type="First Name" name = "first_name" id = "first_name" required>
                    <label>First Name</label>
                </div>
                <div class="txt_field">
                    <input type="Last Name" name = "last_name" id = "last_name" required>
                    <label>Last Name</label>
                </div>
                <div class="txt_field">
                    <input type="Date of Birth" name = "date_of_birth" id = "date_of_birth" required>
                    <label>Date of Birth</label>
                </div>
                <div class="txt_field">
                    <input type="BSN" name = "bsn" id = "bsn" required>
                    <label>BSN</label>
                </div>
                <div class="txt_field">
                    <input type="Gender" name = "gender" id = "gender" required>
                    <label>Gender</label>
                </div>
                <div class="txt_field">
                    <input type="Relationsip" name = "relationship" id = "relationship" required>
                    <label>Relationship</label>
                </div>
                <div class="txt_field">
                    <input type="Email" name = "email" id = "email" required>
                    <label>Email</label>
                </div>
                <div class="txt_field">
                    <input type="Password" name = "password" id = "password" required>
                    <label>Password</label>
                </div>
                <div class="txt_field">
                    <input type="Phone Number" name = "phone_number" id = "phone_number" required>
                    <label>Phone Number</label>
                </div>
                <div class="txt_field">
                    <input type="Address" name = "address" id = "address" required>
                    <label>Address</label>
                </div>
                <div class="txt_field">
                    <input type="Postal Code" name = "postal_code" id = "postal_code" required>
                    <label>Postal Code</label>
                </div>
                <div class="txt_field">
                    <input type="City" name = "city" id = "city" required>
                    <label>City</label>
                </div>
                <div class="txt_field">
                    <input type="Country" name = "country" id = "country" required>
                    <label>Country</label>
                </div>
                <input type="submit" name = "updateBtn" id = "updateBtn" value = "Submit">
            </form>
            <div> <a href = "viewProfile.php">Back:</a> </div>
        </div>
    </body>
</html>     


