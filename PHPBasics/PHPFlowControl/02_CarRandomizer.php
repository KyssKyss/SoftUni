<?php
/* You are a very rich billionaire with an unhidden passion for cars. You like certain car manufacturers but you don’t
really care about anything else, and that’s why you need your own randomizing algorithm that helps you decide how
many and what color cars you should buy. Write a PHP script CarRandomizer.php that receives a string of cars from
an input HTML form, separated by a comma and space (“, “). It then prints each car, a random color and a random
quantity in a table like the one shown below. Use colors by your choice. Use as quantity a random number in range
[1...5]. Styling the page is optional. */
?>
<html>
    <head>
        <title>Rich People's Problems</title>
        <meta charset="UTF-8">
        <style>
            table,tr,td,th {
                border: 1px solid black;
            }
            td, th {
                padding-left: 5px;
                padding-right: 5px;
            }
        </style>
    </head>
    <body>
        <form method="post">
            <label for="cars">Enter Cars:</label>
            <input type="text" name="carString" id="cars">
            <input type="submit" value="Show Results">
        </form>
    <?=carRandomize()?>
    </body>
</html>
<?php
function carRandomize(){
    if(isset($_POST["carString"])){
        $colors = ["Yellow","Green","Black","Red","White","Gray"];
        $carString = $_POST["carString"];
        $carArr = explode(", ", $carString);
        echo    "<table>
                    <thead>
                        <tr>
                        <th>Car</th><th>Color</th><th>Count</th>
                        </tr>
                    </thead>
                    <tbody>";
                    foreach($carArr as $key => $value){
                    $randColor = array_rand($colors);
                     echo "<tr>
                     <td>$value</td>
                     <td>$colors[$randColor]</td>
                     <td>".rand(1,5)."</td>
                        </tr>";
                    }
                    "</tbody>
                </table>";
    }
}
?>