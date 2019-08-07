<!DOCTYPE html>
<html>
<head>
    <title>Bio Data Web App</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="wrapper">
        <header>
        <form action="search.php">
                    <input type="text" name="s" placeholder="Search Here">
                    <input type="submit" name="submit">
                </form>
            <h1>Bio Data Web App</h1>
            <h1 class="head">MH Hamza &copy;</h1>
        </header>

        <div class="content">
            <div class="inner">
                <?php
                    $serverName = ""; //Server Name
                    $connectionInfo = array( "Database"=>"BioData_DB");
                    $conn = sqlsrv_connect( $serverName, $connectionInfo);
                    $query = "SELECT * FROM BioData_Table";
                    $stmt = sqlsrv_query($conn,$query);
                ?>

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
                    while($row = sqlsrv_fetch_Array($stmt,SQLSRV_FETCH_ASSOC)) {
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