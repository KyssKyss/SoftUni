function variablesTypes(arg) {
    var name = arg[0];
    var age = arg[1];
    var isMale = arg[2];
    var foodArr = arg[3];
    name = '';
    age = 0;
    isMale = false;
    foodArr = new Array();
    console.log("My name: " + name + " //type is " + typeof (name));
    console.log("My age: " + age + " //type is " + typeof (age));
    console.log("I am male: " + isMale + "// type is " + typeof (isMale));
    console.log("My favorite foods are: " + arg[3].toString() + " //type is " + typeof (foodArr));
}