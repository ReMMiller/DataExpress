var express = require('express');
var pug = require('pug');
var path = require('path');

var app= express();

app.set('view engine', 'pug');
app.set('views', __dirname+'/views');

app.use(express.static(path.join(__dirname+'/public')));

app.get('/', function(req, res){
  res.render('title', {
    "title":"Home"
  });
});

app.get('/:name', function(req, res) {
  res.render('random', {
    "title":req.params.name
  });
});


app.listen(3000);