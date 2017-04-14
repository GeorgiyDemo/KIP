unit Matrix;

interface   { Public symbols }
  const nmax = 10;
  type matrica = array [1..nmax,1..nmax] of real;

  function summa(a,b:matrica; n: byte):matrica;
  function umnoz(a,b:matrica):matrica;
  function transp(a:matrica):matrica;
  function opred(a:matrica; step:byte):real;


implementation { Private symbols }

  function summa(a,b:matrica;n: byte):matrica;
  var i,j:integer;
      c:matrica;
  begin
    for i:=1 to n do
      begin
        for j:=1 to n do
          begin
            c[i,j]:=a[i,j]+b[i,j];
          end;
      end;
  summa:=c;
  end;

  function umnoz(a,b:matrica):matrica;
  var i,j,k:integer;
      c:matrica;
  begin
    for i:=1to nmax do
      begin
        for j:=1to nmax do
          begin
            c[i,j]:=0;
              for k:=1to nmax do
                begin
                  c[i,j]:=c[i,j]+a[i,k]*b[k,j];
                end;
          end;
      end;
  umnoz:=c;
  end;

  function transp(a:matrica):matrica;
  var i,j:integer;
      c:matrica;
  begin
    for i:=1to nmax do
      begin
        for j:=1 to nmax do
          begin
            c[i,j]:=a[j,i];
          end;
      end;
  transp:=c;
  end;

  function opred(a:matrica; step:byte):real;
  var k,buf:array[1..nmax] of real;
      return:real;
      i,j,n:integer;
  begin
    for n:=1 to step-2 do
      begin
        buf[n]:=a[1,1];
        for i:=2 to step+1-n do
          begin
            k[i]:=-(a[i,1]/a[1,1]);
          end;
        for i:=2 to step+1-n do
          for j:=2 to step+1-n do
            a[i,j]:=a[1, j]*k[i]+a[i,j];
            for i:=1 to step-n do
              begin
                for j:=1 to step-n do
                  begin
                    a[i,j]:=a[i+1,j+1];
                  end;
              end;
            return:=1;
            for i:=1 to step-2 do
              return:=return*buf[i];
              return:=return*(a[1,1]*a[2,2]-a[1,2]*a[2,1]);
      end;
    opred:=return;
  end;

begin    { Initialization }
end.
