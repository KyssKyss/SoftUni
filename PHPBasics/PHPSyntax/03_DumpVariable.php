<?php
/* Write a PHP script DumpVariable.php that declares a variable. If the variable is numeric, print it by the built-in
function var_dump(). If the variable is not numeric, print its type at the input. Examples:
        "hello"         string
        15              int(15)
        1.234           double(1.234)
        array(1,2,3)    array
        (object)[2,34]  object
*/

function variableCheck($var){
    if (is_numeric($var)) {
        var_dump($var);
    }
    else {
        echo gettype($var);
    }
    // break to a new line depends where we debug
    echo "<br />\n";
}
variableCheck("hello");
variableCheck(15);
variableCheck(1.234);
variableCheck(array(1,2,3));
variableCheck((object)[2,34]);
?>