<?php
if(isset($_GET['students'])){
    class Student {
        public $id;
        public $name;
        public $mail;
        public $type;
        public $result;
    }
    $tempArr = preg_split('/\r\n/',$_GET['students'],-1);
    foreach ($tempArr as $key=>$value) {
        $tempArr[$key] = trim($value);
    }
// next all elements in tempArr in own specific array
    foreach ($tempArr as $key=>$value) {
        $explodeArr[$key] = explode(', ',$tempArr[$key]);
    }
    foreach ($explodeArr as $key=>$value) {
        $student[$key] = new Student();
        $student[$key]->id = $key + 1;
        $student[$key]->name = $explodeArr[$key][0];
        $student[$key]->mail = $explodeArr[$key][1];
        $student[$key]->type = $explodeArr[$key][2];
        $student[$key]->result = $explodeArr[$key][3];
        $studentArr[$key] = $student[$key];
    }
    if($_GET['order'] == 'ascending' && $_GET['column'] == 'result'){
        usort($studentArr, 'sort_result_by_ascending_by_result');
    } else if($_GET['order'] == 'descending' && $_GET['column'] == 'result'){
        usort($studentArr, 'sort_result_by_descending_by_result');
    }
    else if($_GET['order'] == 'ascending' && $_GET['column'] == 'id'){
        usort($studentArr, 'sort_result_by_ascending_by_id');
    }
    else if($_GET['order'] == 'descending' && $_GET['column'] == 'id'){
        usort($studentArr, 'sort_result_by_descending_by_id');
    }
    else if($_GET['order'] == 'ascending' && $_GET['column'] == 'username'){
        usort($studentArr, 'sort_result_by_ascending_by_username');
    }
    else if($_GET['order'] == 'descending' && $_GET['column'] == 'username'){
        usort($studentArr, 'sort_result_by_descending_by_username');
    }
    echo "<table><thead><tr><th>Id</th><th>Username</th><th>Email</th><th>Type</th><th>Result</th></tr></thead>";
    foreach ($studentArr as $key=>$value) {
        echo "<tr><td>".htmlspecialchars($studentArr[$key]->id)."</td>".
            "<td>".htmlspecialchars($studentArr[$key]->name)."</td>".
            "<td>".htmlspecialchars($studentArr[$key]->mail)."</td>".
            "<td>".htmlspecialchars($studentArr[$key]->type)."</td>".
            "<td>".htmlspecialchars($studentArr[$key]->result)."</td></tr>";
    }
    echo "</table>";
}

function sort_result_by_ascending_by_result($a, $b) {
    if($a->result == $b->result){ if($a->name == $b->name){ return 0 ; }
        return ($a->name < $b->name) ? -1 : 1; }
    return ($a->result < $b->result) ? -1 : 1;
}
function sort_result_by_descending_by_result($a, $b) {
    if($a->result == $b->result){ return 0 ; }
    return ($a->result > $b->result) ? -1 : 1;
}
function sort_result_by_ascending_by_id($a, $b) {
    if($a->id == $b->id){ return 0 ; }
    return ($a->id < $b->id) ? -1 : 1;
}
function sort_result_by_descending_by_id($a, $b) {
    if($a->id == $b->id){ return 0 ; }
    return ($a->id > $b->id) ? -1 : 1;
}
function sort_result_by_ascending_by_username($a, $b) {
    if($a->name == $b->name){ if($a->id == $b->id){ return 0 ; }
        return ($a->id < $b->id) ? -1 : 1; }
    return ($a->name < $b->name) ? -1 : 1;
}
function sort_result_by_descending_by_username($a, $b) {
    if($a->name == $b->name){ if($a->id == $b->id){ return 0 ; }
        return ($a->id > $b->id) ? -1 : 1; }
    return ($a->name > $b->name) ? -1 : 1;
}
?>