let names=["Aydan", "Fidan", "Nuray","Aysel"];
let counter=0;
for(let i=0; i<names.length;i++){
    if(names[i].startsWith("A")){
        counter+=1
    }
}
console.log(counter);