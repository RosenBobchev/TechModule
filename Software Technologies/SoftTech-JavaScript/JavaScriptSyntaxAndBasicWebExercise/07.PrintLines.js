function PrintLines(arr) {
   for(let i = 0; i < arr.length; i++) {
       if (arr[i] == "Stop") {
           break;
       }
       console.log(arr[i]);
   }
}

PrintLines([
    3,
    6,
    5,
    4,
    "Stop",
    10,
    12
])