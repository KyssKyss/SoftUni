<?php
/* Write a PHP script InformationTable.php which generates an HTML table by given information about a person
(name, phone number, age, address). Styling the table is optional. Semantic HTML is required.
 */

function createHTMLTable($name, $phone, $age, $address){
    $userName = $name;
    $phoneNumber = $phone;
    $userAge = $age;
    $userAddress = $address;

    // Create HTML table

    echo "<html><head><title>HTML Table</title></head><body>";
    echo "<table>
            <tr>
                <th>Name</th>
                <td>$userName</td>
            </tr>
            <tr>
                <th>Phone Number</th>
                <td>$phoneNumber</td>
            </tr>
             <tr>
                <th>Age</th>
                <td>$userAge</td>
            </tr>
             <tr>
                <th>Address</th>
                <td>$userAddress</td>
            </tr>
        </table>";
    echo "</body></html>";
}

createHTMLTable("Gosho","0882-321-423",24,"Hadji Dimitar");
echo "<br />";
createHTMLTable("Pesho","0884-888-888",67,"Suhata Reka");
?>

<!-- Style table -->

<style>
    table,td,th {
        border: 1px solid black;
        border-collapse: collapse;
        width: 25%;
    }
    th {
        background-color: orange;
        padding-left: 5px;
        text-align: left;
    }
    td {
        padding-right: 5px;
        text-align: right;
    }
</style>