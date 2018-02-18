function MultipyOrDivide(arr) {
    let n = Number(arr[0]);
    let x = Number(arr[1]);
    if (n <= x)
        console.log(n * x);
    if (n > x)
        console.log(n / x);
}