//ПРИМЕР 1.Построить графики функций y1(x)=cos(x-1)+abs(x), y2(x)=sin(x)-abs(x+1) на отрезке [-5; 5]
//a) каждую функцию в отдельной области экрана
//б) обе функции в одной области экрана

//y:=x*power(sin(1/x),2);

program graph;
uses graphABC;
var i,y:real; var x,b:integer;
begin
    moveto(50,0);
    lineto(50,100);
    moveto(0,50);
    lineto(100,50);
    moveto(250,0);
    lineto(250,100);
    moveto(200,50);
    lineto(300,50);
    moveto(150,200);
    lineto(150,300);
    moveto(100,250);
    lineto(200,250);
    x:=-5;
    y:=x*power(-sin(1/x),2);
    b:=round(y);
    moveto(3*x+50,6*b+50);
    
    for x:=1 to 50 do
    begin
        i:=x/10;
        y:=i*power(-sin(1/i),2);
        b:=round(y);
        setpencolor(clred);
        lineto(3*round(i)+50,6*b+50);
    end;
    
   { x:=-5;
    y:=-cos(x-1)-abs(x);
    b:=round(y);
    moveto(3*x+150,6*b+250);
    
    for x:=-5 to 5 do begin
        y:=-cos(x-1)-abs(x); b:=round(y);
        setpencolor(clred);
        lineto(3*x+150,6*b+250);
    end;
    
    x:=-5;
    y:=-sin(x)+abs(x+1);
    b:=round(y);
    moveto(3*x+250,6*b+50);
    
    for x:=-5 to 5 do begin
        y:=-sin(x)+abs(x+1); b:=round(y);
        setpencolor(clblue);
        lineto(3*x+250,6*b+50);
    end;
    
    x:=-5;
    y:=-sin(x)+abs(x+1);
    b:=round(y);
    moveto(3*x+150,6*b+250);
    
    for x:=-5 to 5 do begin
        y:=-sin(x)+abs(x+1); b:=round(y);
        setpencolor(clblue);
        lineto(3*x+150,6*b+250);
    end;
    }
end.
