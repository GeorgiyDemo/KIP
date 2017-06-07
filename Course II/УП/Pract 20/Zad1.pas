program graph;
uses graphABC; 

var y,x : real;
    b,h : integer; 

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
    y:=-x*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+150,20*b+250); 
    
    repeat 
        x:=x+0.1; 
        y:=-x*power(sin(1/x),2);
        b:=round(y); 
        h:=round(x); 
        setpencolor(clred); 
        lineto(10*h+150,20*b+250); 
    until(x>10); 
    
    x:=0.1;
    y:=(x+1)*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+250,20*b+50); 
    
    repeat 
        x:=x+0.1;
        y:=(x+1)*power(sin(1/x),2); 
        b:=round(y); 
        h:=round(x); 
        setpencolor(clblue); 
        lineto(10*h+250,20*b+50); 
    until(x>10); 
    
    x:=0.1; 
    y:=(x+1)*power(sin(1/x),2);
    b:=round(y); 
    h:=round(x); 
    moveto(10*h+150,20*b+250); 
    
    repeat 
        x:=x+0.1;
        y:=(x+1)*power(sin(1/x),2);
        b:=round(y); 
        h:=round(x); 
        setpencolor(clblue); 
        lineto(10*h+150,20*b+250); 
    until(x>10); 
    
end.