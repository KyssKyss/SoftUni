<?php
/* Write a PHP script AnnualExpenses.php that receives n years from an input HTML form and creates a table (like the
one shown below) with random expenses by months and the corresponding years (n years back). For example, if N
is 10, create a table that shows the expenses for each month for the last 10 years. Add a "Total" column at the end,
showing the total expenses for the same year. The random expenses in the table should be in the range [0…999].
Styling the page is optional. */
?>
<!DOCTYPE html>
<htlm>
    <head>
        <title>Annual Expenses</title>
        <meta charset="UTF-8">
        <style>
            table, td, tr, th {
                border: 1px solid black;
            }
            th {
                padding-left: 5px;
                padding-right: 5px;
            }
            table {
                margin-top: 20px;
            }
        </style>
    </head>
    <body>
        <form method="post">
            <label for="nYears">Enter number of years:</label>
            <input type="text" name="numYears" id="nYears">
            <input type="submit" value="Show costs">
        </form>
        <?=annualExpenses()?>
    </body>
</htlm>

<?php
function annualExpenses(){
    if(isset($_POST["numYears"])){
        $numberOfYears = $_POST["numYears"];
        $currentYear = date("Y");
        $sum = 0;
        $months = ["January","February","March","April","June","July","August","September","October","December"];
        echo "<table><thead><tr><th>Year</th>";
        for($el = 0; $el < sizeof($months); $el++){
            echo "<th>$months[$el]</th>";
        }
        echo "<th>Total:</th></tr></thead><tbody>";
        for($i = 0; $i < $numberOfYears; $i++){
            echo "<tr><td>".($currentYear-$i)."</td>";
            for($el = 0; $el < sizeof($months); $el++){
                $randNumber = rand(1,999);
                echo "<td>$randNumber</td>";
                $sum += $randNumber;
            }
            echo "<td>$sum</td></tr>";
            $sum = 0;
        }
        echo "</tbody></table>";
    }
}
?>