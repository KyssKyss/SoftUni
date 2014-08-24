<?php
/* Write a PHP script PrintTags.php which generates an HTML input text field and a submit button. In the text field
the user must enter different tags, separated by a comma and a space (", "). When the information is submitted, the
script should split the tags, put them in an array and print out the array. Semantic HTML is required. Styling is not
required. */
?>
<html>
    <head>
        <title>Most Freq tag</title>
        <meta charset="UTF-8">
    </head>
    <body>
        <form method="post" action="PrintTags.php">
            <label for="tagsInserted" >Enter Tags:</label><br />
            <input type="text" name="insertTag" id="tagsInserted">
            <input type="submit" name="submitBtn" value="Submit">
        </form>
    </body>
</html>
<?php
function populateArray(){
    $tagText = $_POST["insertTag"];
    $tagArray = explode(", ", $tagText);
    return $tagArray;
}
function printStringArray($arr){

    foreach ($arr as $key=>$val) {
        echo htmlentities($key." : ".$val)."<br />";
    }
}
if (!empty($_POST)){
printStringArray(populateArray());
}
?>