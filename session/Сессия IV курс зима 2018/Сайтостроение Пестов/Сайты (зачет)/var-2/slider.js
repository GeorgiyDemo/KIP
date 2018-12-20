var slideWidth=700;
var slideAutoTime=3000;
var sliderTime;
var currentSlide=parseInt($('.slidewrapper').data('current'));

// Автопрокрутка
$('.slidewrapper').width($('.slidewrapper').children().size()*slideWidth);
sliderTimer=setInterval(nextSlide, slideAutoTime);

// Кнопки переключения между слайдами
$('.control-slide').click(function(){
  MoveSlideTo(parseInt($(this).text()));
});

// Переключение слайда
function MoveSlideTo(num) {
  currentSlide = num;

  $(".control-slide.active").removeClass("active");
  $('.control-slide').eq(currentSlide).addClass('active');

  $('.slidewrapper').animate({left: -currentSlide*slideWidth},200).data('current',(currentSlide));
}

// Перелистывание вперёд
function nextSlide() {
  // Если слайдер в конце, обнуляем
  if (currentSlide==$('.slidewrapper').children().size()-1) {
    currentSlide=0;
  } else {
    currentSlide++;
  }
  MoveSlideTo(currentSlide);
}

// Перелистывание вперёд
function backSlide() {
  // Если слайдер не в начале, то возвращаемся на предыдущий слайд
  if (currentSlide!==0) {
    currentSlide--;
    MoveSlideTo(currentSlide);
  } else {
    MoveSlideTo($('.slidewrapper').children().size()-1);
  }
}
