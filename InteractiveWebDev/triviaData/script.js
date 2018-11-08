var data;
var request = new XMLHttpRequest();
 
loadData();
 
function loadData() {
  request.open('GET', 'https://opentdb.com/api.php?amount=10&difficulty=easy&type=multiple');
  request.onload = loadComplete;
  request.send();
}
 
function loadComplete(evt) {
  data = JSON.parse(request.responseText);
  console.log(data);
  document.getElementById('question').innerHTML = data.results[0].question;

}