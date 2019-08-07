<!DOCTYPE html>
<html>

<head>
    <title>Bio Data Web App</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <div class="wrapper">
        <header>
            <h1>Bio Data Web App | MH Hamza &copy;</h1>
            <?php
                    $serverName = ""; //Server Name 
                    $connectionInfo = array( "Database"=>"BioData_DB");
                    $conn = sqlsrv_connect( $serverName, $connectionInfo);
                    if(isset($_GET['s'])) { $s = $_GET['s']; }
                    $query = "SELECT * FROM BioData_Table WHERE name LIKE '%".$s."%' ";
                    $stmt = sqlsrv_query($conn,$query,array(), array( "Scrollable" => SQLSRV_CURSOR_KEYSET ));

                    $row_count = sqlsrv_num_rows( $stmt );  
                    echo "<h3>Total Records ".$row_count."</h3>";
  
                ?>
        </header>
        
        <div class="content">
            <div class="inner">
                <table border="1">
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>DOB</th>
                        <th>Height</th>
                        <th>Blood Group</th>
                        <th>Qualification</th>
                        <th>City</th>
                        <th>Postral Code</th>
                        <th>Gender</th>
                    </tr>
                <?php
                    while($row = sqlsrv_fetch_Array($stmt, SQLSRV_FETCH_ASSOC)) {
                        echo "<tr>";
                        echo "<td>".$row['id']."</td>";
                        echo "<td>".$row['name']."</td>"; 

                        $dob = date_format($row['dob'],'d-M-Y');

                        echo "<td>".$dob."</td>";
                        echo "<td>".$row['height']."</td>";
                        echo "<td>".$row['bloodgroup']."</td>";
                        echo "<td>".$row['qualification']."</td>";
                        echo "<td>".$row['city']."</td>";
                        echo "<td>".$row['postralcode']."</td>";
                        echo "<td>".$row['gender']."</td>";
                        echo "</tr>";
                    }
                ?>
                </table>
            </div>
        </div>
    </div>
</body>
</html>