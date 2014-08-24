<?php
/* Write a PHP script SumOfDigits.php which receives a comma-separated list of integers from an input form and
creates a two-column table. The first column should contain each of the values from the input. The second column
should contain the sum of the digits of each value. If the value is not an integer number, print "I cannot sum that".
Styling the page is optional. */
?>
<!DOCTYPE html>
    <html>
        <head>
            <title>Sum sequence of digits</title>
            <meta charset="UTF-8">
            <style>
                table, tr, td {
                    border: 1px solid black;
                }
                td {
                    padding-left: 5px;
                    padding-right: 5px;
                }
            </style>
        </head>
        <body>
            <form method="post">
                <label for="input">Input string:</label>
                <input type="text" name="inputString" id="input">
                <input type="submit">
            </form>
        <?=sumOfDigits()?>
        </body>
    </html>
<?php
function sumOfDigits(){
    if(isset($_POST["inputString"])){
        $tempArr = explode(",", $_POST["inputString"]);
        $result = "<table>";
        for($i = 0; $i < sizeof($tempArr); $i++){
            $result .= "<tr><td>$tempArr[$i]</td>";
            if(intval($tempArr[$i])){
               $sum = array_sum(str_split($tempArr[$i]));
                $result .= "<td>".$sum."</td>";
            }
            else{
                $result .= "<td>I can not sum that</td>";
            }
            $result .= "</tr>";
        }
        $result .= "</table>";
        echo $result;
    }
}
?>