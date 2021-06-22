let active = true;
var MorningOutput = 9;
var EveningOutput = 9;
var AfternoonOutput = 9;

function changeColor(domObj,clickedID) {
    domObj.classList.toggle("onClick");
    MorningOutput = 9;
    EveningOutput = 9;
    AfternoonOutput = 9;

    active = !active;

    if(document.getElementById(clickedID+"Value").value == 1)
    {
        document.getElementById(clickedID+"Value").value = 0; 
    }
    else{
        document.getElementById(clickedID+"Value").value = 1;       
    }   
    for (i = 1; i <= 7; i++) 
    {
        MorningOutput += document.getElementById("Morning"+i+"Value").value;
        EveningOutput += document.getElementById("Evening"+i+"Value").value;
        AfternoonOutput += document.getElementById("Afternoon"+i+"Value").value;
    }

    document.getElementById("PreferenceValue").value = MorningOutput + EveningOutput + AfternoonOutput;       

}