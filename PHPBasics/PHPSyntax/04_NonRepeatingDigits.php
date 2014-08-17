<?php
/* Write a PHP script NonRepeatingDigits.php that declares an integer variable N, and then finds all 3-digit numbers
that are less or equal than N (<= N) and consist of unique digits. Print "no" if no such numbers exist. Examples:
        1234    102, 103, 104, 105, 106, 107, 108, 109, 120, 123, 124, 125, 126, 127, 128,
                129, 130, 132, 134, 135, …, 980, 981, 982, 983, 984, 985, 986, 987
        15      no
        145     102, 103, 104, 105, 106, 107, 108, 109, 120, 123, 124, 125, 126, 127, 128,
                129, 130, 132, 134, 135, 136, 137, 138, 139, 140, 142, 143, 145
*/

function noRepeatingThreeDigits($input){
    $hundredDigit = 9;
    $decimalDigit = 9;
    $digit = 9;
    if ($input > 101 && $input < 1000){
        $hundredDigit = $input / 100 % 10;
        $decimalDigit = $input / 10 % 10;
        $digit = $input % 10;
    } else if ($input < 101){
       echo "no";
       return;
    }
    for ($i = 1; $i <= $hundredDigit; $i++) {
        for ($j = 0; $j <= $decimalDigit; $j++ ) {
            if ($i != $j){
                for ($k = 0; $k <= $digit; $k++){
                    if ($j != $k && $k != $i){
                        $result = $i.$j.$k;
                        echo $result."\n";
                    }
                }
            }
        }
    }
}
//noRepeatingThreeDigits(1234);
//noRepeatingThreeDigits(145);
//noRepeatingThreeDigits(15);
noRepeatingThreeDigits(247);
?>