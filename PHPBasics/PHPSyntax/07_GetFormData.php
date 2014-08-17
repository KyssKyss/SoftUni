<?php
/* Write a PHP script GetFormData.php which retrieves the input data from an HTML form, and displays it as string.
The input fields should hold name, age and gender (radio buttons). The returned string should be a message
containing the information submitted by the form. 100% accuracy is NOT required. Semantic HTML is required.
 */
?>

<!-- Create a HTML Form -->

<html>
    <head>
        <title>Get Form Data</title>
    </head>
    <body>
        <form action="07_GetFormData.php" method="post">
            <input type="text" name="name" placeholder="Name..." tabindex="1"><br />
            <input type="number" name="age" placeholder="Age..." tabindex="2"><br />
            <input type="radio" name="gender" value="Male" > Male <br />
            <input type="radio" name="gender" value="Female" > Female <br />
            <input type="submit">
        </form>
    </body>
</html>

<!-- Create php -->

<?php
    if(!empty($_POST)){
        $userName = $_POST["name"];
        $userAge =  $_POST["age"];
        if($_POST["gender"] == "Male")
            $userGender = "male";
        else
            $userGender = "female";
       echo "My name is $userName. I am $userAge old. I am $userGender.";
    }
?>