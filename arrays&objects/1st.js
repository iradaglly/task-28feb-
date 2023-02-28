let numbers =[2, 3, 6, 7, 9]
let sum = 0;
let counter = 0;
 for (let i = 0; i < numbers.length; i++)
 {
  if (numbers[i] % 3 == 0)
 {
 counter += 1;
 sum += numbers[i];
 }
}

 console.log(sum/counter);