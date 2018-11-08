var canvas = document.getElementById('maze');
var ctx = canvas.getContext('2d');

var grid = [];
var MAZE_WIDTH = 25;
var MAZE_HEIGHT = 25;
var BLOCK_SIZE = 20;

var KEYCODE_LEFT = 37;
var KEYCODE_UP = 38;
var KEYCODE_RIGHT = 39;
var KEYCODE_DOWN = 40;

function drawSquare(x, y, r, g, b) {
  ctx.fillStyle = 'rgb('+r+','+g+','+b+')';
  ctx.fillRect(x, y, BLOCK_SIZE-1, BLOCK_SIZE-1);
}

for(var i = 0; i<MAZE_WIDTH; i++){
  grid[i] = [];
  for(var j=0; j<MAZE_HEIGHT; j++){
    grid[i][j] = 0;
  }
}

function drawMaze(){
  for(var y=0; y<MAZE_HEIGHT; y++){
    for(var x=0; x<MAZE_WIDTH; x++){
      if(grid[x][y] == 1){
        drawSquare(x*BLOCK_SIZE, y*BLOCK_SIZE, x*10, 0, y*10);
      }
      if(grid[x][y] == 2){
        drawSquare(x*BLOCK_SIZE, y*BLOCK_SIZE, 0, 0, 0);
      }
    }
  }
}

grid[10][10] = 1;
grid[11][10] = 1;
grid[12][10] = 1;
grid[13][11] = 1;
playerX = 15;
playerY = 9;


function loop(){
  ctx.clearRect(0,0,500,500);
  if(leftkey && grid[playerX-1][playerY]!=1){
    grid[playerX][playerY]=0;
    playerX -= 1;
  }
  if(rightkey && grid[playerX+1][playerY]!=1){
    grid[playerX][playerY]=0;
    playerX += 1;
  }
  if(upkey && grid[playerX][playerY-1]!=1){
    grid[playerX][playerY]=0;
    playerY -= 1;
  }
  if(downkey && grid[playerX][playerY+1]!=1){
    grid[playerX][playerY]=0;
    playerY += 1;
  }

  grid[playerX][playerY] = 2;


  drawMaze();
  
}

setInterval(loop, 100);



var upkey = false;
var downkey = false;
var leftkey = false;
var rightkey = false;

function handleKeyDown(evt) {
  if(!evt){ var evt = window.event; }  //browser compatibility
  switch(evt.keyCode) {
    case KEYCODE_LEFT:  
      leftkey = true;
      return false;
    case KEYCODE_RIGHT: 
      rightkey = true;
      return false;
    case KEYCODE_UP:  
      upkey = true;
      return false;
    case KEYCODE_DOWN:  
      downkey = true;
      return false;
  }
}
 
function handleKeyUp(evt) {
  if(!evt){ var evt = window.event; }  //browser compatibility
  switch(evt.keyCode) {
    case KEYCODE_LEFT:  
      leftkey=false;
      break;
    case KEYCODE_RIGHT:
      rightkey=false;
      break;
    case KEYCODE_UP:
      upkey=false;
      break;
    case KEYCODE_DOWN:  
      downkey=false;
      break;
  }
}
 
document.onkeydown = handleKeyDown;
document.onkeyup = handleKeyUp;

