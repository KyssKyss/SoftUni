function findYoungestPerson(persons) {
    var minAge = Number.MAX_VALUE;
    var youngestPerson = '';
    for (var age in persons) {
        while (persons[age].age < minAge) {
            minAge = persons[age].age;
            youngestPerson = persons[age];
        }
    }
    return console.log("The youngest person is " + youngestPerson.firstname + " " + youngestPerson.lastname);
}
var persons = [
 { firstname: 'George', lastname: 'Kolev', age: 32 },

 { firstname: 'Bay', lastname: 'Ivan', age: 81 },

 { firstname: 'Baba', lastname: 'Ginka', age: 40 }];
findYoungestPerson(persons);