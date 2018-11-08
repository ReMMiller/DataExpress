var canvas = document.getElementById('maze');
var ctx = canvas.getContext('2d');

var grid = [];
var MAZE_WIDTH = 250; //All caps is considered a constant.
var MAZE_HEIGHT = 510;
var BLOCK_SIZE = 20;



function drawSquare(x, y){
    ctx.fillStyle = 'rgb(255,100,255)';
    ctx.fillRect(x, y, BLOCK_SIZE, BLOCK_SIZE);

}

// for(var i = 0; i<=MAZE_WIDTH; i++){
//     grid[i] = [];
//     for(var j = 0; j<=MAZE_HEIGHT; j++){
//         grid[i][j] = 1;
//     }
// }

function drawMaze(){
    for(var x = 0; x<MAZE_WIDTH; x++){
        for(var y = 0; y<MAZE_HEIGHT; y++){
            if(grid[x][y] == 1){
                drawSquare(x*BLOCK_SIZE, y*BLOCK_SIZE).;
            }
        }
    }
}


drawMaze();