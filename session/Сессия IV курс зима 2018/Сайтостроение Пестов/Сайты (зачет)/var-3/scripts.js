// Подсчёт баллов
function buttonTotal() {
  var total = 0;

  if (document.getElementById('html').checked) {total++;}
  if (document.getElementById('css').checked) {total++;}
  if (document.getElementById('bootstrap').checked) {total++;}

  if (document.getElementById('raskr').checked) {total = total+2;}
  if (document.getElementById('js').checked) {total = total+2;}
  if (document.getElementById('slider').checked) {total = total+3;}
  if (document.getElementById('php').checked) {total = total+3;}

  document.getElementById('total').innerHTML='<b>Количество баллов:</b> ' + total;
}

// Раскрывающийся список
function toggle() {
  var ul_spisok = document.getElementById("ul_spisok");
  ul_spisok.hidden = (ul_spisok.hidden == false) ? true : false;
}
