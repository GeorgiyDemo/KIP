var s
var scl = 20; // масштаб
var food; //элемент еды

var randomColor = "#"+((1<<24)*Math.random()|0).toString(16);

//Функция настройки
function setup(){
  bg = loadImage("https://pp.userapi.com/c845523/v845523714/111b6c/HUIz6HGFEGg.jpg");
  var w = window.innerWidth-((window.innerWidth/100)*10);
  var h = window.innerHeight-((window.innerHeight/100)*10);
  createCanvas(w,h).style("border", "5px solid "+randomColor);
  s = new Snake();
  //Задержка во время работы
  frameRate(10);
  //Фигачим локацию
  pickLocation();
}

//Выбор локации
function pickLocation() {
  var cols = floor(width/scl);
  var rows = floor(height/scl);
  food = createVector(floor(random(cols)), floor(random(rows)));
  food.mult(scl);
}

//Функция отрисовки
function draw() {

  background(bg);
  s.smertnost();
  s.update();
  s.show();
  
  if (s.eat(food)) { 
   pickLocation();
  }
  
  // То, что змея есть
  fill(randomColor);
  rect(food.x, food.y, scl, scl);
}

//Нажание кнопки
function keyPressed() {
  if ((keyCode === 38) || (keyCode == 87)) { //вверх
    s.dir(0, -1);
  } else if ((keyCode === 40) || (keyCode == 83)){ //вниз
    s.dir(0, 1);
  } else if ((keyCode === 39) || (keyCode == 68)){ //право
    s.dir(1, 0);
  } else if ((keyCode === 37) || (keyCode == 65)){ //лево
    s.dir(-1, 0);
  }
}

class Snake {

  constructor() {
    this.x = 0;
    this.y = 0;
    this.xspeed = 1;
    this.yspeed = 0;
    this.total = 0;
    this.tail = [];
    this.dir = function (x, y) {
      this.xspeed = x;
      this.yspeed = y;
    };

    this.eat = function (pos) {

      var d = dist(this.x, this.y, pos.x, pos.y);
      if (d < 4) {
        var score_audio = new Audio();
        score_audio.src = "./audio/score.mp3";
        score_audio.play();
        this.total++;
        return true;
      }
      else {
        return false;
      }
    };

    this.smertnost = function () {
      for (var i = 0; i < this.tail.length; i++) {
        var pos = this.tail[i];
        var d = dist(this.x, this.y, pos.x, pos.y);

        if (d < 1) {
          
          let promise = new Promise((resolve, reject) => {
                  var score_audio = new Audio();
                  score_audio.src = "./audio/snake_death.wav";
                  score_audio.play();

                  this.total = 0;
                  this.tail = [];
                  resolve('result');
                });
          promise
              .then(
                result => {
                    setTimeout(function() {
                          alert("Вы проиграли 🐍")
                          location.reload();
                    }, 2500);
                },
                error => {
                  console.log("Промис не сработал, боль тлен")
                }
              );
        }
      }
    };

    this.update = function () {
      for (var i = 0; i < this.tail.length - 1; i++) {
        this.tail[i] = this.tail[i + 1];
      }
      this.tail[this.total - 1] = createVector(this.x, this.y);
      this.x = this.x + this.xspeed * scl;
      this.y = this.y + this.yspeed * scl;

      //Чтоб змея не вышла за пределы канваса-канзаса
      this.x = constrain(this.x, 0, width - scl);
      this.y = constrain(this.y, 0, height - scl);
    };

    this.show = function () {
      fill(randomColor);
      for (var i = 0; i < this.total; i++) {
        rect(this.tail[i].x, this.tail[i].y, scl, scl);
      }
      rect(this.x, this.y, scl, scl);
    };
  }
}