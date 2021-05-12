<?php
session_start();
include 'classes/dbConnection.Class.php';
include 'classes/user.Class.php';
include 'classes/workShift.Class.php';
$user = new user();
$workShift = new workShift();
$workShift -> GetShifts();
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

    <div class="header">
        <h1> MediaBazaar </h1>
    </div>

    <br>
    <div id="dp"></div>
    <br>

    <input id="userName" type="hidden" value="<?php echo "".$_SESSION["sess_email"]?>">
    <input id="userShiftDate" type="hidden" value="<?php echo "".$_SESSION["sess_date"]?>">
    <input id="userShiftType" type="hidden" value="<?php echo "".$_SESSION["sess_type"]?>">


 </body>
 </html>
     <script src="js/daypilot-all.min.js"></script>
    <script src="js/main.js" type="text/javascript"></script>