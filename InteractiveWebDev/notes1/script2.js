var canvas = document.getElementById('demo');
var ctx = canvas.getContext('2d');

var blockSize = 20;

var traceback = [{x: 21, y:11}, {x: 13, y:11}, {x: 13, y: 5}];

function drawSquare(x,y){
    ctx.fillStyle = "#639";
    ctx.fillRect(x, y, blockSize, blockSize);
    console.log("---------");
}

var boxX;
var boxY;

var currentStop = 0;
boxX = traceback[currentStop].x*blockSize;
boxY = traceback[currentStop].y*blockSize;

function moveBox(){
    if(boxX < traceback[currentStop+1].x*blockSize){
        boxX +=5;
    }
    if(boxX > traceback[currentStop+1].x*blockSize){
        boxX-=5;
    }
    if(boxY < traceback[currentStop+1].y*blockSize){
        boxY +=5;
    }
    if(boxY > traceback[currentStop+1].y*blockSize){
        boxY-=5;
    }

    ctx.clearRect(0,0,500,500);
    drawSquare(boxX. boxY);
}

setInterval(moveBox, 100);



