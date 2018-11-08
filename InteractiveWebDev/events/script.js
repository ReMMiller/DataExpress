var buttonholder = document.getElementById("ButtonHolder");
var btn = [];
var temp = "";

for(var i = 0; i<10 ; i++){
    temp = '<div id="btn' + i + ' class="btn">';
    temp+= "Whatever" + i;
    temp += "</div>";

    btn.push(temp);
}

var buttons = "";
for(var i = 0; i< btn.length; i++){
    buttons += btn[i];
}

buttonholder.innerHTML = buttons;
buttonholder.innerHTML = temp;

for(var i = 0; i<10 ; i++){
    var tempButton = document.getElementById("btn" + i);
}

var btn1 = document.getElementById("btn1")
btn1.addEventListener('click', function(){
    console.log("CLICK!!");
});