<?php
//Write a PHP script CVGenerator.php which generates an HTML form like in the example below. When the
//information is submitted (via Generate CV), the script should print out a simple table-like CV. Semantic HTML is
//required. Styling is not required.
?>
<html>
    <head>
        <title>CV Generator</title>
    </head>
    <body>
        <form method="post" id="main" action="">
            <fieldset id="personalInfo">
                <legend>Personal Information</legend>
                <input type="text" name="firstName" placeholder="First Name"><br />
                <input type="text" name="lastName" placeholder="Last Name"><br />
                <input type="email" name="mail" placeholder="Email"><br />
                <input type="tel" name="phone" placeholder="Phone Number"><br />
                Female <input type="radio" name="gender" value="female">Male <input type="radio" name="gender" value="male"><br />
                <label for="bdate">Birth Date</label><br />
                <input type="date" name="bdate" id="bdate" placeholder="Birth Date"><br />
                <label for="nation">Nationality</label><br />
                <select name="nation" id="nation">
                    <option value="bulgarian">Bulgarian</option>
                    <option value="american">American</option>
                    <option value="macedonian">Macedonian</option>
                    <option value="italian">Italian</option>
                </select>
            </fieldset>
            <fieldset id="workInfo">
                <legend>Last Work Position</legend>
                <label for="compName">Company Name</label>
                <input type="text" name="companyName" id="compName"><br />
                <label for="startPeriod">From</label>
                <input type="date" name="startPeriod" id="startPeriod"><br />
                <label for="compName">Company Name</label>
                <input type="date" name="endPeriod" id="endPeriod"><br />
            </fieldset>
            <fieldset id="profSkills">
                <legend>Computer Skills</legend>
                <label>Programming Languages</label><br />
                <input type="text" name="progLang">
                <select name="progLvl">
                    <option value="beginner">Beginner</option>
                    <option value="programmer">Programmer</option>
                    <option value="ninja">Ninja</option>
                </select><br />
                <input type="button" name="remove" value="Remove Language">
                <input type="button" name="add" value="Add Language">
            </fieldset>
            <fieldset id="otherSkills">
                <legend>Other Skills</legend>
                <label for="lang">Languages</label>
                <input type="text" name="lang" id="lang">
                <select name="compr">
                    <option>-Comprehension-</option>
                    <option value="beginner">beginner</option>
                    <option value="intermediate">intermediate</option>
                    <option value="advance">advance</option>
                </select>
                <select name="reading">
                    <option>-Reading-</option>
                    <option value="beginner">beginner</option>
                    <option value="intermediate">intermediate</option>
                    <option value="advance">advance</option>
                </select>
                <select name="writing">
                    <option>-Writing-</option>
                    <option value="beginner">beginner</option>
                    <option value="intermediate">intermediate</option>
                    <option value="advance">advance</option>
                </select><br />
                <input type="button" name="removeLang" value="Remove Language">
                <input type="button" name="addLang" value="Add Language"><br />
                <label>Driver Licence</label><br />
                B <input type="checkbox" name="licence">
                A <input type="checkbox" name="licence">
                C <input type="checkbox" name="licence">
            </fieldset>
            <input type="submit" value="Generate CV">
        </form>
    </body>
</html>
<?php
session_start();
        function personalInfo(){
            if(isset($_POST["firstName"], $_POST["lastName"], $_POST["mail"], $_POST["phone"], $_POST["gender"], $_POST["bdate"], $_POST["nation"])){
            $firstName = $_POST["firstName"];
            $lastName = $_POST["lastName"];
            $email= $_POST["mail"];
            $phone = $_POST["phone"];
            $gender = $_POST["gender"];
            $birthDate = $_POST["bdate"];
            $nationality = $_POST["nation"];
            echo  "<div><table id=\"pInfo\">
                        <thead>
                        <tr>
                            <th>Personal Information</th>
                        </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>First Name</td>
                                <td>$firstName</td>
                            </tr>
                            <tr>
                                <td>Last Name</td>
                                <td>$lastName</td>
                            </tr>
                            <tr>
                                <td>Email</td>
                                <td>$email</td>
                            </tr>
                            <tr>
                                <td>Phone Number</td>
                                <td>$phone</td>
                            </tr>
                            <tr>
                                <td>Gender</td>
                                <td>$gender</td>
                            </tr>
                            <tr>
                                <td>Birth Date</td>
                                <td>$birthDate</td>
                            </tr>
                            <tr>
                                <td>Nationality</td>
                                <td>$nationality</td>
                            </tr>
                        </tbody>
                    </table></div>";
        }
    }
        function lastWork(){
            if(isset($_POST["companyName"], $_POST["startPeriod"], $_POST["endPeriod"])){
                $companyName = $_POST["companyName"];
                $startPeriod = $_POST["startPeriod"];
                $endPeriod = $_POST["endPeriod"];
                echo    "<div><table>
                            <thead>
                                <tr><th>Last Work Position</th></tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Company Name</td>
                                    <td>$companyName</td>
                                </tr>
                                <tr>
                                    <td>From</td>
                                    <td>$startPeriod</td>
                                </tr>
                                <tr>
                                    <td>To</td>
                                    <td>$endPeriod</td>
                                </tr>
                            </tbody>
                        </table></div>";
            }
        }
        function compSkills(){
            if(isset($_POST["progLvl"], $_POST["progLang"])){

            }
        }
personalInfo();
lastWork();
?>