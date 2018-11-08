var canvas = document.getElementById('demo');
var ctx = canvas.getContext('2d');

var BLOCK_SIZE = 20;

var path = [{x:21, y:11}, {x:13, y:11}, {x:13, y:5}, {x:3, y:5}];

function drawSquare(x, y){
  ctx.fillStyle = "#639";
  ctx.fillRect(x, y, BLOCK_SIZE, BLOCK_SIZE);
}

var boxX;
var boxY;

var currentStop = 0;

boxX=path[currentStop].x*BLOCK_SIZE;
boxY=path[currentStop].y*BLOCK_SIZE;

function moveBox(){
  temp = path[currentStop+1];
  if(boxX < temp.x*BLOCK_SIZE)boxX += 5;
  if(boxX > temp.x*BLOCK_SIZE) boxX -= 5;
  if(boxY < temp.y*BLOCK_SIZE)boxY += 5;
  if(boxY > temp.y*BLOCK_SIZE) boxY -= 5;
  if(boxX == temp.x*BLOCK_SIZE && boxY==temp.y*BLOCK_SIZE){
    currentStop++;
  }
  if(currentStop >= path.length-1) currentStop=0;
  ctx.clearRect(0,0,500,500);
  drawSquare(boxX, boxY);
}

setInterval(moveBox,50);
