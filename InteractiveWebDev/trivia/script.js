var data;

var request = new XMLHttpRequest();


var answers = [];
var correct_answer;
var highScore;
var sorted = false;
var streak = 0;
var going = true;


loadData();

function loadData() {

    
    request.open('GET', 'https://opentdb.com/api.php?amount=10');
    request.onload = loadComplete;
    request.send();

}

function loadComplete(evt){
    data = JSON.parse(request.responseText);
    getCookie();

    do{
        singleGame();
    }while(going);
   
}

function shuffleArray(array) {
    for (var i = array.length - 1; i > 0; i--) {
        var j = Math.floor(Math.random() * (i + 1));
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

function singleGame(){
    correct_answer = data.results[0].correct_answer;
    sorted = false;

    for(var i = 0; i< data.results[0].incorrect_answers.length; i++){
        answers[i] = data.results[0].incorrect_answers[i];
    }
    answers[answers.length] = data.results[0].correct_answer;

    shuffleArray(answers);



    document.getElementById('question').innerHTML = data.results[0].question;
    document.getElementById('a0').innerHTML = answers[0];
    document.getElementById('a1').innerHTML = answers[1];
    document.getElementById('a2').innerHTML = answers[2];
    document.getElementById('a3').innerHTML = answers[3];

    

    going = false;
}

function checkSelected(id){
    if(document.getElementById(id).innerHTML !== correct_answer){
        console.log("incorrect");
        cooky = document.cookie;
        var arr = cooky.split("=");
        highScore = parseInt(arr[1]);
        console.log("cooky=" + cooky);

        if(highScore < streak || cooky ===null || cooky===""){
            document.cookie = "highScore="+streak;
            console.log("cooky2='" + cooky + "'");
        }
        streak = 0;

    } else{
        console.log("correct");
        streak += 1;
    }
    
}

function getCookie() {
    cooky = document.cookie;
    if(cooky !== null && cooky !==""){
        console.log("full" +cooky);
        document.cookie = "highScore=35";
        
    } else{
        console.log("enpty" +cooky);
        document.cookie = "highScore=35";
    }
} 

