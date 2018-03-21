 <?php
 //Displays errors
ini_set('display_errors', 1);
ini_set('display_startup_errors',1);
error_reporting(E_ALL);
//Server information
$server = 'localhost';
$user = 'tha7556';
$pass = '082096';
$dbname = 'CSC455SP18CustomPCs';
//Connects to the server
$con = mysqli_connect($server,$user,$pass) or die('Error:\n' .mysql_error());
mysqli_select_db($con,$dbname);
//Error handling
if(!$con) {
	die('Error:\m'.mysqli_error()); 
}
//Get Data from C#
$qry = $_POST['query'];
echo $qry."\n\n";
//SQL queries
$result = mysqli_query($con,$qry);
//Displaying results
if(mysqli_num_rows($result) > 0) {
	$keys = mysqli_fetch_fields($result);
	while($row = mysqli_fetch_assoc($result)) {
		foreach($keys as $key) {
			echo $row[$key->name]."\0";
		}
		echo "\n";
	}
}
//Close connection
mysqli_close($con);
?> 
