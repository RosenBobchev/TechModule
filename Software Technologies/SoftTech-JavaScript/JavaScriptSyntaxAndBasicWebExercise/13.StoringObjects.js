function StoringObjects(arr) {
    for(let i = 0; i < arr.length; i++){
        let personInfo = arr[i].split(" -> ");
        let name = personInfo[0];
        let age = personInfo[1];
        let grade = personInfo[2];

        console.log(`Name: ${name}`);
        console.log(`Age: ${age}`);
        console.log(`Grade: ${grade}`);
    }
}