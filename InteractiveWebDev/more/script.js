var visitedArr = [{x:13,y:10},{x:11,y:10},{x:11,y:8}];
var temp = {
    x: 15,
    y: 10
};
visitedArr.push(temp);
console.log(visitedArr[0].x);

//////////////////////////////////////

var possDir = [{x:11,y:8}, {x:13,y:8}, {x:13,y:10}];

for(var i = 0; i<visitedArr.length;i++){
    for(var j = 0; j<possDir.length;j++){
        if(visitedArr[i].x == possDir[j].x && visitedArr[i].y == possDir[j].y){
            console.log(visitedArr[i].x + "," + visitedArr[i].y);
        }
    }
}
