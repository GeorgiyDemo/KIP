var var1 = 7
var var2 = 10
var var3 = 8
var var4 = 25
var var5 = 30

var second="2";
var first="1";
var third="3";
var forth="4";

var name = ["К", "О", "Т", "И", "К", "И"];

document.write("<br>");
var string = "";

for (var i = 0; i < name.length; i++)
    string+=name[i];

string = string.replace(/,/g, "");
document.write(string);

document.write("<br>Данный текст был выведен на страницу с момощью js с внешнего файла");

var x=3
var y=20
document.write("<br>"+(35*y+25*x)/5+232+"<br>")

x=16
y=20
document.write("<br>"+(188*y/8+25*x/5-435)*6+"<br>")


for (var x = 0; x < 1000; x++)
{
	for (var y = 0; y < 1000; y++)
	{
		if ((x/8==y)&&(x>16)&&(y<5)&&(y!=3)){
			document.write(x+" "+y)
			break
		}
	}
}


