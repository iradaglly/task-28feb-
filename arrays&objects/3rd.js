let numbers=[5, 6, 8, 12, 32, 2, 15];
let max= numbers[0];
let min=numbers[0];
let counter=0;
for(let i=0; i<numbers.length; i++){
    if(max<numbers[i]){
    max=numbers[i];
        
    }
    if(min>numbers[i]){
    min=numbers[i];
    }
}
console.log((max+min)/2);