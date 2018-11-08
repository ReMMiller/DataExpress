var canvas = document.getElementById('maze');
var ctx = canvas.getContext('2d');
var canvas = document.getElementById('maze');
var ctx = canvas.getContext('2d');

var grid = [];
var MAZE_WIDTH = 231;
var MAZE_HEIGHT = 231;
var BLOCK_SIZE = 20;
var MAZE_SIZE = ((MAZE_WIDTH-1)/2) * ((MAZE_HEIGHT-1)/2);

var startPoint = {
  x: 0,
  y: 0
}
var endPoint = {
  x: 0,
  y: 0
}
var botPath = [];
var longestRun = 0;

var middle = [];
var middleX = 0;
var middleY = 0;

var visited = [];
var traceback = [];
var possibleDir = [];
var currentPlace = [];

var newX = 0;
var newY = 0;

var oldX = 0;
var oldX = 0;

var boxX;
var boxY;

var currentStop = 0;
var completed = false;
var celeb = true;
var aaa = 0;
var time  = 0;
var inter = setInterval(interv, 1000);

var temp = {
  x: 0,
  y: 0
};

function interv(){
  time+=1;
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function buildGrid(){
  //debugger;
  for(var y=0; y<MAZE_HEIGHT; y++){
    for(var x=0; x<MAZE_WIDTH; x++){
      if(isEven(x) || isEven(y)){
        grid[x][y] = 1;
      }
      else{grid[x][y] = 0;}
    }
  }
}

function drawSquare(x, y) {
  ctx.fillStyle = 'rgb(100,100,100)';
  ctx.fillRect(x, y, BLOCK_SIZE, BLOCK_SIZE);
}

function drawStartSquare() {
  ctx.fillStyle = 'rgb(200,30,100)';
  ctx.fillRect((startPoint.x)*BLOCK_SIZE, (startPoint.y)*BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
}

function drawEndSquare() {
  ctx.fillStyle = 'rgb(50,130,150)';
  ctx.fillRect((endPoint.x)*BLOCK_SIZE, (endPoint.y)*BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
}

function drawMaze(){
  for(var y=0; y<MAZE_HEIGHT; y++){
    for(var x=0; x<MAZE_WIDTH; x++){
      if(grid[x][y] === 1){
        drawSquare(x*BLOCK_SIZE, y*BLOCK_SIZE);
      } 
    }
  }
  drawStartSquare();
  drawEndSquare();
}

function generateFirstBlock(){
  do{
    newX = (Math.floor(((Math.random()*((MAZE_WIDTH-1)/2))))*2)+1;
    newY = (Math.floor(((Math.random()*((MAZE_HEIGHT-1)/2))))*2)+1;
    
    temp = {
      x: newX,
      y: newY
    };
  }while(!isValid(temp.x, temp.y));

  currentPlace = [JSON.parse(JSON.stringify(temp))];

  visited.push(temp);
  traceback.push(temp);

  startPoint = {
    x: newX,
    y: newY
  };


};

function move(){
  checkMove();
  
  if(possibleDir.length == 0){
    do{
      if(traceback.length > longestRun){
        botPath = JSON.parse(JSON.stringify(traceback));
        longestRun = JSON.parse(JSON.stringify(traceback.length));
        endPoint= JSON.parse(JSON.stringify(traceback[traceback.length-1]));
      }
        traceback.pop();
        currentPlace = [];
        currentPlace[0] = JSON.parse(JSON.stringify(traceback[traceback.length-1]));
        checkMove();
        for(var sss = 0; sss < traceback.length; sss++){
          var ttt = sss+1;
        }
    }while(possibleDir.length == 0);
  }

  rando = Math.floor(Math.random()*(possibleDir.length));

  visited.push(possibleDir[rando]);
  traceback.push(possibleDir[rando]);

  temp = {
    x: possibleDir[rando].x,
    y: possibleDir[rando].y
  };
  currentPlace = [JSON.parse(JSON.stringify(temp))];

  
  newX = JSON.parse(JSON.stringify(currentPlace[0].x));
  newY = JSON.parse(JSON.stringify(currentPlace[0].y));
  
  middleX = ((newX+oldX)/2);
  middleY = ((newY+oldY)/2);
  temp ={
    x: middleX,
    y: middleY
  };
  middle = [JSON.parse(JSON.stringify(temp))];

  grid[middle[0].x][middle[0].y] = 0;

  possibleDir = [];


}

function checkMove(){
  oldX = JSON.parse(JSON.stringify(currentPlace[0].x));
  oldY = JSON.parse(JSON.stringify(currentPlace[0].y));

  var v = false;

  newX = oldX+2;
  newY = oldY+0;
  v = isValid(newX, newY);
  if(v){
    temp = {
      x: newX,
      y: newY
    };
    possibleDir.push(temp);
  }
  
  newX = oldX-2;
  newY = oldY+0;
  v = isValid(newX, newY);
  if(v){
    temp = {
      x: newX,
      y: newY
    };
    possibleDir.push(temp);
  }

  newX = oldX+0;
  newY = oldY+2;
  v = isValid(newX, newY);
  if(v){
    temp = {
      x: newX,
      y: newY
    };
    possibleDir.push(temp);
  }

  newX = oldX+0;
  newY = oldY-2;
  v = isValid(newX, newY);
  if(v){
    temp = {
      x: newX,
      y: newY
    };
    possibleDir.push(temp);
  }

  for(var i = visited.length-1; i >= 0; i--){
    for(var j = possibleDir.length-1; j >=0; j--){
      if(possibleDir[j].x === visited[i].x && possibleDir[j].y === visited[i].y){
        possibleDir.splice(j, 1);
      }
    }
  }

};

function isValid(x, y){

  if(x <= 0 || x >= MAZE_WIDTH-1){
    return false;
  } else if(y <= 0 || y >= MAZE_HEIGHT-1){
    return false;
  } else if(isEven(x) || isEven(y)){
    return false;
  } else{
    return true;
  }

};

function isEven(x){
  return (x%2) == 0;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////
function drawBot(x, y){
  ctx.fillStyle = "#251";
  ctx.fillRect(x, y, BLOCK_SIZE, BLOCK_SIZE);
}

function celebrations(){
  colors = [
    'rgb(161, 198, 196)',
    'rgb(101, 188, 182)',
    'rgb(72, 160, 154)',
    'rgb(56, 140, 134)',
    'rgb(19, 86, 82)'
  ];
  
  ctx.clearRect(0,0,500,500);

  for(var y=0; y<MAZE_HEIGHT; y++){
    for(var x=0; x<MAZE_WIDTH; x++){
      if(grid[x][y] === 1){
        ctx.fillStyle = colors[aaa];
        ctx.fillRect(x*BLOCK_SIZE, y*BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
      } 
      else{
        ctx.fillStyle = 'rgb(0,0,0)';
        ctx.fillRect(x*BLOCK_SIZE, y*BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
      }
    }
  }

  if(aaa == colors.length-1){
    aaa = 0;
  } else{
    aaa++
  }



}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function play(){
  buildGrid();
  generateFirstBlock();
  
  do{
    move();
  }while(visited.length !== MAZE_SIZE);
  drawMaze();
  
}

function celbr(){
  var uhg = setInterval(celebrations,100);
  console.log("Completed in " + time + " seconds.");
  clearInterval(interv);
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

var KEYCODE_LEFT = 37;
var KEYCODE_UP = 38;
var KEYCODE_RIGHT = 39;
var KEYCODE_DOWN = 40;

function handleKeyDown(evt) {
  if(!evt){ var evt = window.event; }  //browser compatibility
    temp = {
      x: boxX,
      y: boxY
    };
  switch(evt.keyCode) {
    case KEYCODE_LEFT:  
      if(grid[(temp.x/BLOCK_SIZE) - 1][temp.y/BLOCK_SIZE] === 0 ){
        boxX -= BLOCK_SIZE;
      }
      break;
    case KEYCODE_RIGHT: 
      if(grid[(temp.x/BLOCK_SIZE) + 1][temp.y/BLOCK_SIZE] === 0){
        boxX +=BLOCK_SIZE;
      }
      break;
    case KEYCODE_UP: 
      if(grid[temp.x/BLOCK_SIZE][(temp.y/BLOCK_SIZE) - 1] === 0){
        boxY -=BLOCK_SIZE;
      }
      break;
    case KEYCODE_DOWN: 
      if(grid[temp.x/BLOCK_SIZE][(temp.y/BLOCK_SIZE) + 1] === 0){
        boxY +=BLOCK_SIZE;
      }
      break;
    default:
  }
  console.log("End: " + endPoint.x, endPoint.y);
  if(boxX/BLOCK_SIZE === endPoint.x && boxY/BLOCK_SIZE === endPoint.y){
    celbr();
  }
}
 
function handleKeyUp(evt) {
  if(!evt){ var evt = window.event; }  //browser compatibility
  switch(evt.keyCode) {
    case KEYCODE_LEFT:  console.log(evt.keyCode+" up"); break;
    case KEYCODE_RIGHT:   console.log(evt.keyCode+" up"); break;
    case KEYCODE_UP:    console.log(evt.keyCode+" up"); break;
    case KEYCODE_DOWN:  console.log(evt.keyCode+" up"); break;
  }

  ctx.clearRect(0,0,500,500);
  drawMaze();
  drawBot(boxX, boxY);
  console.log(boxX, boxY);
}

document.onkeydown = handleKeyDown;
document.onkeyup = handleKeyUp;


////////////////////////////////////////////////////////////////////////////////////////////////////////////////

for(var i = 0; i<MAZE_WIDTH; i++){
  grid[i] = [];
  for(var j=0; j<MAZE_HEIGHT; j++){
    grid[i][j] = 1;
  }
}

play();

boxX=botPath[currentStop].x*BLOCK_SIZE;
boxY=botPath[currentStop].y*BLOCK_SIZE;

function player(event){
  temp = {

  };
}





