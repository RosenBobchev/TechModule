function SetValues(text){
    "use strict";
    let count = Number(text[0]);
    let newArr = [];
    for(let i = 1; i < text.length; i++){
        let temp = text[i].split(' - ');
        let index = temp[0];
        let value = temp[1];
        newArr[index] = value;
    }
    for(let j = 0; j < count; j++){
        if(newArr[j] == undefined){
            console.log(0);
        }
        else{
            console.log(newArr[j]);
        }
    }
}