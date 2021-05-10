<?php
class dbConnection 
{
    private $host = "studmysql01.fhict.local";
    private $user = "dbi450080";
    private $pass = "WortelSoulution";
    private $dbName = "dbi450080";

    protected function connect()
    {
        $dsn = 'mysql:host=' . $this->host .';dbname=' . $this->dbName;
        try 
        {
            $pdo = new PDO($dsn, $this->user, $this->pass);
            $pdo -> setAttribute(PDO::ATTR_ERRMODE, pDO::ERRMODE_EXCEPTION);
        }
        catch (PDOException $e)
        {
            echo $e->GetMessage();
        }
       

        return $pdo;
    }
}
?>