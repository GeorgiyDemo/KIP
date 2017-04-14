program Unic;
uses graphABC;
var flag,i:integer;

procedure Gruzovik(x:integer);
begin

  SetPenWidth(4);

  {*Кабина авто*}
  line(x+400,350,x+400,300);
  lineto(x+430,240);
  lineto(x+490,240);
  lineto(x+490,350);
  lineto(x+400,350);
  circle(x+450,360,25);
  circle(x+450,360,15);

  {*Кузов авто*}
  line(x+450,200,x+500,250);
  lineto(x+500,310);
  lineto(x+620,310);
  lineto(x+680,250);
  lineto(x+500,250);
  lineto(x+500,200);
  lineto(x+450,200);

  {*Рама авто*}
  line(x+490,314,x+540,314);
  lineto(x+540,365);
  lineto(x+490,365);
  lineto(x+490,350);
  line(x+540,340,x+570,310);
  line(x+590,310,x+620,340);
  lineto(x+620,365);
  lineto(x+540,365);
  circle(x+555,360,25);
  circle(x+555,360,15);
  circle(x+610,360,25);
  circle(x+610,360,15);
  SetPenWidth(2);
  line(x+430,240,x+430,350);
  line(x+400,300,x+440,300);
  lineto(x+460,330);
  lineto(x+490,330);
  line(x+450,250,x+440,290);
  lineto(x+480,290);
  lineto(x+480,250);
  lineto(x+450,250);
  line(x+490,350,x+530,350);
  line(x+578,350,x+588,350);
  line(x+560,250,x+560,310);
  line(x+620,250,x+620,310);
  arc(x+590,320,100,45,135);

end;

{*Облачная процедура*}
procedure cloud(x,y:integer);
begin
  setbrushcolor(clwhite);
  circle(x+25,y,15);
  circle(x+50,y,19);
  circle(x+75,y,15);
end;

{*Процедура декораций*}
procedure decorations();
var i:integer;
begin
    line(0,385,940,385);
    for i:=386 to 800 do
      line(0,i,940,385);
    lineto(940,385);
    floodfill(451,386,clblack);
    setbrushcolor(clwhite);
end;

{*Основная программа*}
begin
flag:=0;
lockdrawing;
while true do
  begin
    clearwindow(clwhite);
    decorations();
    Gruzovik(flag);
    for i:=1 to 3 do
      cloud(i*100-50,i*50);
    for i:=1 to 2 do
      cloud(round(500/i),round(50/i));
    flag:=flag-5;
    sleep(5);
    redraw;
    if (flag<-700) then
      flag:=500;
  end;
end.
