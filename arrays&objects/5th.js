const persons=[];
persons[0]={firstName:"Irada", lastName:"Gulaliyeva",salary:450};
persons[1]={firstName:"Nuray",lastName:"Baxishli",salary:520};
persons[2]={firstName:"Fidan",lastName:"Baratli",salary:480}
persons[3]={firstName:"Lale",lastName:"Aliyeva",salary:550};
for(let i=0;i<persons.length;i++){
    if(persons[i].salary>500){

        console.log(persons[i].firstName, persons[i].lastName);
 }
}
