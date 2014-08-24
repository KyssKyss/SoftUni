<?php

?>
<html>
<head>
    <title>Print tag</title>
    <meta charset="UTF-8">
</head>
<body>
<form method="post" action="">
    <label for="tagsInserted" >Enter Tags:</label><br />
    <input type="text" name="insertTag" id="tagsInserted">
    <input type="submit" name="submitBtn" value="Submit">
</form>
</body>
</html>
<?php
if(isset($_POST["insertTag"])){
$tags = explode(", ", $_POST['insertTag']);
$count = array_count_values($tags);
$val = array_search(max($count), $count);
arsort($count);
foreach ($count as $key => $value) {
    echo "$key : $value times <br>";
}
echo "<p>Most Frequent Tag is: $val </p>";
}
?>