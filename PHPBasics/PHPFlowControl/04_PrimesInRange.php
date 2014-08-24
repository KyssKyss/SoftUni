<?php
/* Write a PHP script PrimesInRange.php that receives two numbers – start and end – from an input field and displays
all numbers in that range as a comma-separated list. Prime numbers should be bolded. Styling the page is optional. */
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Find prime numbers in a range</title>
        <meta charset="UTF-8">
    </head>
    <body>
        <form method="post">
            <label for="start">Starting Index:</label>
            <input type="text" name="startPoint" id="start">
            <label for="end">End:</label>
            <input type="text" name="endPoint" id="end">
            <input type="submit">
        </form>
        <?=primesInRange()?>
    </body>
</html>

<?php
function primesInRange(){
    $result = [];
    if(isset($_POST["startPoint"]) && isset($_POST["endPoint"])){
        for($i = $_POST["startPoint"], $index = 0; $i <= $_POST["endPoint"]; $i++, $index++)
        {
            isPrime($i) ? $result[$index] ="<strong>".$i."</strong>" : $result[$index] = $i;
        }
       echo implode(", ", $result);
    }
    else {
        echo "A start and a end number required.";
    }
}
function isPrime($number){
if ($number == 2) {
        return true;
    } else if ($number % 2 == 0) {
        return false;
    } else {
        for ($i = 3; $i <= ceil(sqrt($number)); $i += 2) {
            if ($number % $i == 0) {
                return false;
            }
        }
        return true;
    }
}
?>