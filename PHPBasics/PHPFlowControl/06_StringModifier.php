<?php
/* Write a PHP script StringModifier.php which receives a string from an input form and modifies it according to the
selected option (radio button). You should support the following operations: palindrome check, reverse string, split
to extract leters only, hash the string with the default PHP hashing algorithm, shuffle the string characters randomly.
The result should be displayed right under the input field. Styling the page is optional. Think about which of the
modification can be achieved with already built-in functions in PHP. Where necessary, write your own algorithms to
modify the given string. Hint: Use the crypt() function for the "Hash String" modification. */
?>
<!DOCTYPE html>
    <html>
        <head>
            <title>Different modifications with string</title>
            <meta charset="UTF-8">
        </head>
        <body>
            <form method="post">
                <input type="text" name="inputField">
                <input type="radio" name="options" value="palindrome"> Check Palindrome
                <input type="radio" name="options" value="reverse"> Reverse String
                <input type="radio" name="options" value="split"> Split
                <input type="radio" name="options" value="hash"> Hash String
                <input type="radio" name="options" value="shuffle"> Shuffle String
                <input type="submit">
            </form>
        </body>
    <?=choise()?>
    </html>

<?php
    function choise(){
        if(isset($_POST['inputField'])){
            if($_POST['options'] == 'palindrome'){
                palindrome();
            }
            else if($_POST['options'] == 'reverse'){
                reverse();
            }
            else if($_POST['options'] == 'split'){
                splitString();
            }
            else if($_POST['options'] == 'hash'){
                hashString();
            }
            else if($_POST['options'] == 'shuffle'){
                shuffleString();
            }
        }
    }
    function palindrome(){
        $strToLower = $_POST['inputField'];
        $strArr = explode(' ',$strToLower);
        $result = [];
        $index = 0;
        for ($i = 0; $i < count($strArr); $i++) {
                    $len = count(preg_split('//',$strArr[$i],-1, PREG_SPLIT_NO_EMPTY));
            for ($j = 0; $j < $len ; $j++) {
                        if ($strArr[$i][$j] != $strArr[$i][$len - 1 - $j]) {
                            echo $strArr[$i]." is not a panindrome! <br />";
                            break;
                        }
                else {
                            $result[$index++] = $strArr[$i];
                    break;
                }
            }
        }
        foreach ($result as $el) {
            echo $el." is a polindrome! <br />";
        }
    }
    function reverse(){
            echo strrev($_POST['inputField'])."<br />";
    }
    function splitString(){
           $splitArr = preg_split('//',$_POST['inputField'],-1, PREG_SPLIT_NO_EMPTY);
            foreach ($splitArr as $el) {
                echo $el." ";
            }
    }
    function hashString(){
            $password = crypt('qwertyasdfghjklzxcvbnm');
            $result = crypt($_POST['inputField'],$password);
            echo $result;
    }
    function shuffleString(){
            echo str_shuffle($_POST['inputField']);
    }
?>