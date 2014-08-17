<?php
/* Write a PHP script LazySundays.php which prints the dates of all Sundays in the current month. Example:
        3rd August, 2014
        10th August, 2014
        17th August, 2014
        24th August, 2014
        31th August, 2014
*/

function lazySunday($month){
    $daysInMonth = cal_days_in_month(CAL_GREGORIAN,$month, 2014);
    $now = new DateTime();
    $monthNow = (int)$now->format("m");
    $month -=$monthNow;
    $startDate = new DateTime("first Sunday of $month month");
    $firstDay = (int)$startDate ->format("j");

   for ($i = $firstDay; $i <= $daysInMonth; $i += 7) {
       echo $startDate->format("jS F, Y")."\n";
       $startDate -> modify('+7 days');
   }
}
lazySunday(9);
?>