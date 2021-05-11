<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
$user = new user();
$user -> SubmitCredentials();
?>


<!DOCTYPE html> 
<html lang="en" dir="ltr"> 
    <head>
        <meta charset="utf-8">
        <title>SignIn Page</title>
        <link rel="stylesheet" href="styles\profile_authentication_styles.css">
    </head> 
    <body>
        <div class="center">
            <h1>Login</h1>
            <form method="post">
            
            <?php if (isset($_GET['error'])) 
            { ?>

            <p class = "error"> Error: wrong user credentials.</p> 
                
            <?php } ?>
                <div class="txt_field">
                    <input type="text" name = "usrName" id = "usrName" required>
                    <label>Username</label>
                </div>
                <div class="txt_field">
                    <input type="password" name = "password" id = "password" required>
                    <label>Password</label>
                </div>
                <div class="pass">Forgot Password?</div>
                <input type="submit" name = "addBtn" id = "addBtn" value="Sign In">
            </form>
        </div>
    </body>

</html>