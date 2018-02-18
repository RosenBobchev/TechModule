function ProductOfNumbers(nums) {
    let x = Number(nums[0]);
    let y = Number(nums[1]);
    let z = Number(nums[2]);

    let sum = x * y * z;
    if (sum < 0)
        return "Negative";
    if (sum >= 0)
        return "Positive";
}