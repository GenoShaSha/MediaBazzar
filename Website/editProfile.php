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
        <a href="floorEmployees.php?signedIn">HOME</a>
            <a href="schedule.php">SCHEDULE</a>
            <input type="text" placeholder="Search...">
            <a href="viewProfile.php">PERSONAL INFO</a>
        </div>
        <div class="centerProfile" style = "position: absolute; top: 800px">
            <h1>Profile</h1>
            <form method = "POST">
                <div class="txt_field">
                    <input type="First Name" name = "first_name" id = "first_name" value="<?php echo $_SESSION['sess_first_name'] ?>" required>
                    <label>First Name</label>
                </div>
                <div class="txt_field">
                    <input type="Last Name" name = "last_name" id = "last_name" value="<?php echo $_SESSION['sess_last_name'] ?>" required>
                    <label>Last Name</label>
                </div>
                <div class="txt_field">
                    <input type="Date of Birth" name = "date_of_birth" id = "date_of_birth" value="<?php echo $_SESSION['sess_date_of_birth'] ?>" required>
                    <label>Date of Birth</label>
                </div>
                <div class="txt_field">
                    <input type="BSN" name = "bsn" id = "bsn" value="<?php echo $_SESSION['sess_BSN'] ?>" required>
                    <label>BSN</label>
                </div>
                <div class="txt_field">
                    <input type="Gender" name = "gender" id = "gender" value="<?php echo $_SESSION['sess_gender'] ?>" required>
                    <label>Gender</label>
                </div>
                <div class="txt_field">
                    <input type="Relationsip" name = "relationship" id = "relationship" value="<?php echo $_SESSION['sess_relationship'] ?>" required>
                    <label>Relationship</label>
                </div>
                <div class="txt_field">
                    <input type="Email" name = "email" id = "email" value="<?php echo $_SESSION['sess_email'] ?>" required>
                    <label>Email</label>
                </div>
                <div class="txt_field">
                    <input type="Password" name = "password" id = "password" required>
                    <label>Password</label>
                </div>
                <div class="txt_field">
                    <input type="Phone Number" name = "phone_number" id = "phone_number" value="<?php echo $_SESSION['sess_phone_number'] ?>" required>
                    <label>Phone Number</label>
                </div>
                <div class="txt_field">
                    <input type="Address" name = "address" id = "address" value="<?php echo $_SESSION['sess_address'] ?>" required>
                    <label>Address</label>
                </div>
                <div class="txt_field">
                    <input type="Postal Code" name = "postal_code" id = "postal_code" value="<?php echo $_SESSION['sess_postal_code'] ?>" required>
                    <label>Postal Code</label>
                </div>
                <div class="txt_field">
                    <input type="City" name = "city" id = "city" value="<?php echo $_SESSION['sess_city'] ?>" required>
                    <label>City</label>
                </div>
                <div class="txt_field">
                    <input type="Country" name = "country" id = "country" value="<?php echo $_SESSION['sess_country'] ?>" required>
                    <label>Country</label>
                </div>
                <input type="submit" name = "updateBtn" id = "updateBtn" value = "Submit">
            </form>
            <div> <a href = "viewProfile.php">Back:</a> </div>
        </div>
    </body>
</html>     


