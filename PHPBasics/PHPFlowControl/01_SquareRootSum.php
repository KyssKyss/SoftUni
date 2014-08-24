<?php
/*Write a PHP script SquareRootSum.php that displays a table in your browser with 2 columns. The first column
should contain a number (even numbers from 0 to 100) and the second column should contain the square root of
that number, rounded to the second digit after the decimal point. The last row of the table should contain the sum
of all values in the Square column. Styling the page is optional. */
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Square Root Sum</title>
        <meta charset="utf-8">
        <style>
            table, tr,td,th {
                border: 1px solid black;
            }
        </style>
    </head>
    <body>
        <table>
            <thead>
                <tr>
                    <th>Number</th>
                    <th>Square</th>
                </tr>
            </thead>
            <?=squareRootSum()?>
        </table>
    </body>
</html>

<?php
function squareRootSum(){
    $sum = 0;
    for($i = 0; $i <= 100; $i+=2){
        echo    "<tr>
                    <td>".$i."</td>
                    <td>".round(sqrt($i),2)."</td>
                </tr>";
        $sum += sqrt($i);
    }
    echo    "<tfoot>
                <tr>
                    <th>Total:</th>
                    <td>".round($sum, 2)."</td>
                </tr>
            </tfoot>";
}
?>