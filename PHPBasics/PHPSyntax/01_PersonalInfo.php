<?php
/* Write a PHP script PersonalInfo.php. Declare a few variables. The first variable should hold your first name,
the second should hold your last name, the third - your age, and the last one should hold your full name (use
concatenation). The result should be printed. Sample output:
    My name is Mister DakMan and I am 21 years old.
    My name is Pesho Peshev and I am 55 years old.
*/

function personInfo($fName, $lName, $age){
   $firstName = $fName;
   $lastName = $lName;
   $personAge = $age;
   return printf("My name is %s %s and I am %d years old.", $firstName, $lastName, $personAge);
}
personInfo('Mister', 'DakMan', 21);
print("<br />");
personInfo('Pesho', 'Peshev', 55);
?>