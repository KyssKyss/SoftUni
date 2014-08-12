<?php
/* Write a PHP script SumTwoNumbers.php that decleares two variables, firstNumber and secondNumber. They
should hold integer or floating-point numbers (hard-coded values). Print their sum in the output in the format
shown in the examples below. The numbers should be rounded to the second number after the decimal point. Find
in Internet how to round a given number in PHP. Examples:
        2           $firstNumber + $secondNumber = 2 + 5 = 7.00
        5

        1.567808    $firstNumber + $secondNumber = 1.567808 + 0.356 = 1.92
        0.356

        1234.5678   $firstNumber + $secondNumber = 1234.5678 + 333 = 1567.57
        333
*/

function sumTwoNumbers($fNumber, $sNumber){
    $firstNumber = $fNumber;
    $secondNumber = $sNumber;
    $result = number_format(($firstNumber + $secondNumber),2,'.','');
    echo ("\$firstNumber + \$secondNumber = ".$firstNumber." + ".$secondNumber." = ".$result." <br />"."\n");
}
sumTwoNumbers(2, 5);
sumTwoNumbers(1.567808, 0.356);
sumTwoNumbers(1234.5678, 333);
?>