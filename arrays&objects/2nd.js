let numbers = [ 22, 15, 512, 61, 821 ]
let sum = 0;
 for (let i = 0; i < numbers.length; i++)
   {
 if (numbers[i] > 99)
 { 
  sum += numbers[i];
 }
}
console.log(sum);
