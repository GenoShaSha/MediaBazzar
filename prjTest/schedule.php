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
    <script src="js/daypilot-all.min.js"></script>
    <script src="js/main.js"></script>
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

<script type="text/javascript">

    var dp = new DayPilot.Calendar("dp");

    // view
    dp.startDate = "2021-03-25";
    dp.viewType = "Week";

    // event creating
    dp.onTimeRangeSelected = function (args) {
        var name = prompt("New event name:", "Event");
        if (!name) return;
        var e = new DayPilot.Event({
            start: args.start,
            end: args.end,
            id: DayPilot.guid(),
            text: name
        });
        dp.events.add(e);
        dp.clearSelection();
    };

    dp.onEventClick = function (args) {
        alert("clicked: " + args.e.id());
    };

    dp.headerDateFormat = "dddd";
    dp.init();

    var e = new DayPilot.Event({
        start: new DayPilot.Date("2021-03-25T12:00:00"),
        end: new DayPilot.Date("2021-03-25T12:00:00").addHours(3).addMinutes(15),
        id: "1",
        text: "Special event"
    });
    dp.events.add(e);

</script>

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
 <script src="../helpers/v2/app.js?v=2021.1.248"></script>