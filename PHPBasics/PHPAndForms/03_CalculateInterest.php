<?php
//Write a PHP script CalculateInterest.php which generates an HTML page that contains:
//• An input text field to hold the amount of money
//• Radio buttons to choose the currency
//• An input text field to enter the compound annual interest amount
//• A dropdown menu to choose the period of time
//• A submit button
//When the information is submitted, the script should print out the amount of money you will have after the
//selected period, rounded to 2 decimal places. Semantic HTML is required. Styling is not required.
?>
<html>
    <head>
        <title>Calculate Interest</title>
    </head>
    <body>
        <form method="post">
            <label for="amount">Enter Amount </label><input type="text" name="amount" id="amount"><br />
            <input type="radio" name="currency" value="usd">USD
            <input type="radio" name="currency" value="eur">EUR
            <input type="radio" name="currency" value="bgn">BGN<br />
            <label for="compound">Compound Interest Amount</label><input type="number" name="compound" id="compound"><br />
            <select name="periodOfTime">
                <option value="6">6 Months</option>
                <option value="12">1 Year</option>
                <option value="24">2 Years</option>
                <option value="60">5 Years</option>
            </select>
            <input type="submit" value="Calculate">
        </form>
    </body>
</html>
<?php
if(isset($_POST["amount"]) && isset($_POST["compound"]) && isset($_POST["periodOfTime"])){
    $end = false;
    $amount = $_POST["amount"];
    $compound = $_POST["compound"];
    $period = $_POST["periodOfTime"];
    $valueSign = '';
    switch($_POST["currency"]){
        case "usd" : $valueSign = chr(36);
        break;
        case "eur" : $valueSign = chr(128);
            break;
        case "bgn" : $valueSign = "лв.";
                     $end = true;
            break;
    }
    $result = round($amount * pow(1 + (($compound / 100) / 12), $period / 12 * 12), 2);
    if($end)
        echo round($result, 2)." ".$valueSign;
    else{
        echo $valueSign." ".round($result, 2);
    }
}
?>