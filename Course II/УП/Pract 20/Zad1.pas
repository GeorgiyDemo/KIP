program Graph;
uses graphABC; 

var x, y : real;
    k, b, h : integer; 

procedure GraphOne();
begin
    
    clearwindow;
    setpencolor(clBlack); 
    moveto(50,0); 
    lineto(50,100); 
    moveto(0,50); 
    lineto(100,50);
    
    x:=0.1; 
    y:=-x*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+50,20*b+50); 
    
    repeat 
        x:=x+0.1; 
        y:=-x*power(sin(1/x),2);
        b:=round(y); 
        h:=round(x); 
        setpencolor(clred); 
        lineto(10*h+50,20*b+50); 
    until(x>10);
    read();
end;

procedure GraphTwo();
begin

    clearwindow;
    setpencolor(clBlack); 
    moveto(50,0); 
    lineto(50,100); 
    moveto(0,50); 
    lineto(100,50);
    
    x:=0.1;
    y:=(x+1)*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+50,20*b+50); 
    
    repeat 
        x:=x+0.1;
        y:=(x+1)*power(sin(1/x),2); 
        b:=round(y); 
        h:=round(x); 
        setpencolor(clblue); 
        lineto(10*h+50,20*b+50); 
    until(x>10); 
end;

procedure DoubleGraph();
begin
    
    clearwindow;
    setpencolor(clBlack); 
    moveto(50,0); 
    lineto(50,100); 
    moveto(0,50); 
    lineto(100,50);
    
    x:=0.1; 
    y:=-x*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+50,20*b+50);
    
    repeat 
        x:=x+0.1; 
        y:=-x*power(sin(1/x),2);
        b:=round(y); 
        h:=round(x); 
        setpencolor(clred); 
        lineto(10*h+50,20*b+50); 
    until(x>10); 

    x:=0.1; 
    y:=(x+1)*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+50,20*b+50);
    
    repeat 
        x:=x+0.1;
        y:=(x+1)*power(sin(1/x),2);
        b:=round(y); 
        h:=round(x); 
        setpencolor(clblue); 
        lineto(10*h+50,20*b+50); 
    until(x>10);
end;

begin

    clearwindow;
    writeln('1. Построение графика №1');
    writeln('2.  Построение графика №2');
    writeln('3. Построение двух графиков на одной плоскости');
    writeln('0. Выход из программы');
    write('=> '); readln(k);
  
     case k of
       1 : GraphOne();
       2 : GraphTwo();
       3 : DoubleGraph();
     end;
     
end.