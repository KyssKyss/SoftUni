<?php
//Write a PHP script HTMLTagsCounter.php which generates an HTML form like in the example below. It should
//contain a label, an input text field and a submit button. The user enters HTML tag in the input field. If the tag is
//valid, the script should print “Valid HTML tag!”, and if it is invalid – “Invalid HTML Tag!”. On the second line, there
//should be a score counter. For every valid tag entered, the score should increase by 1.
//Hint: You may use sessions. Use an array to store all valid HTML5 tags.
?>
<html>
    <head>
        <title>HTML Tag Counter</title>
    </head>
    <body>
        <form method="post">
            <label>Enter HTML Tags:</label><br />
            <input type="text" name="tagCheck">
            <input type="submit">
        </form>
    </body>
</html>
<?php
$counter = 0;
session_start();
$tagArr = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
    'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
    'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
    'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
    'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
    'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
    'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
    'tt', 'u', 'ul', 'var');
    if(!isset($_SESSION["counter"]))
    $_SESSION["counter"] = 0;
    if(isset($_POST["tagCheck"])){
        $tagString = $_POST["tagCheck"];
        if(in_array($tagString, $tagArr)){
            echo("Valid HTML Tag! <br />");
            $_SESSION["counter"]++;
        }
        else {
            echo "Invalid HTML Tag <br />";
        }
        echo "Score: ".$_SESSION["counter"];
    }
    else if(!isset($_POST["tagCheck"])){
        unset($_SESSION["counter"]);
    }
?>