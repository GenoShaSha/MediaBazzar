<?php
session_start();
include 'classes/dbConnection.Class.php';
require_once 'classes/user.Class.php';
$user = new user();
$user -> RetrieveEmployeeInfo();
?>