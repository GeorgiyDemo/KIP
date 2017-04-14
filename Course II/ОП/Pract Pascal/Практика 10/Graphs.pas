uses graphABC;
const W = 800; H = 500;

function F1(x: real): real;
begin
    F1:=power(x,4);
end;

function F2(x: real): real;
begin
    F2:=4;
end;

var XCopy,x0,y0,x,y,xLeft,yLeft,xRight,yRight,n:integer;
    a,b,fmin,fmax,x1,y1,mx,my,dx,dy,num:real;
    i:byte;
    s:string;

begin
  writeln('¬ведите X =>'); Readln(XCopy);
  SetWindowSize(W, H);
  
  xLeft:=50; yLeft:=50;
  xRight:=W-50; yRight:=H-50;
  a:=-2; b:=6; dx:=0.5;
  fmin:=-10; fmax:=20; dy:=2;
  
  mx:=(xRight-xLeft)/(b-a);
  my:=(yRight-yLeft)/(fmax-fmin);
  
  x0:=trunc(abs(a)*mx)+xLeft;
  y0:=yRight-trunc(abs(fmin)*my);
  
  line(xLeft,y0,xRight+10,y0);
  line(x0,yLeft-10,x0,yRight);
  
  SetFontSize(12);
  SetFontColor(clBlack);
  TextOut(xRight+20,y0-15,'x');
  TextOut(x0-10,yLeft-30,'y');
  SetFontSize(8);
  SetFontColor(clBlack);
  
  n:=round((b-a)/dx)+1;
  for i:=1 to n do
  begin
  
    num:=a+(i-1)*dx;
    x:=xLeft+trunc(mx*(num-a));
    Line(x,y0-3,x,y0+3);
    str(Num:0:1,s);
    
    if (abs(num) > 1E-15) then
      TextOut(x-TextWidth(s) div 2, y0+10, s)
  end;
  
  n:=round((fmax-fmin)/dy)+1;
  for i:=1 to n do
  begin
  
    num:=fMin+(i-1)*dy;
    y:=yRight-trunc(my*(num-fmin));
    Line(x0-3,y,x0+3,y);
    str(num:0:0,s);
    
    if (abs(num) > 1E-15) then
      TextOut(x0+7, y-TextHeight(s) div 2, s)
  end;
  
  TextOut(x0-10,y0+10,'0');
  x1:=a;
  
  while (x1 <= b) do
    begin
      if (XCopy <= 3) and (XCopy >= 0) then
        y1:=F1(x1)
      else
        y1:=F2(x1);
      x:=x0+round(x1*mx);
      y:=y0-round(y1*my);
      if (y >= yLeft) and (y <= yRight) then
        SetPixel(x,y,clGreen);
      x1:=x1+0.0001
  end
  
end.