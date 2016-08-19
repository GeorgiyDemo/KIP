unit Unit2;

{$mode objfpc}{$H+}

interface

uses
  Math, Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm2 }

  TForm2 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image1Click(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure Label2Click(Sender: TObject);
    procedure Label3Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form2: TForm2;

implementation
           uses Unit1;
{$R *.lfm}

{ TForm2 }

procedure TForm2.Button1Click(Sender: TObject);
begin
  Form1.Show;
  Form2.Hide;
end;

procedure TForm2.Button2Click(Sender: TObject);
var z,x,y:extended;
begin
   val(inputbox('Ввод','Введите значение X',''),x);
   val(inputbox('Ввод','Введите значение Y',''),y);
   z:=(3.14/2-sqrt(2*x))-((x+(power(y,2)))/((sin(0.75)/cos(0.75))*abs(x+y)));
   MessageDlg('Результат вычисления выражения: ' + FloatToStrf(z,ffFixed,4,4),mtWarning,[mbOk],0);
end;

procedure TForm2.FormCreate(Sender: TObject);
begin

end;

procedure TForm2.Image1Click(Sender: TObject);
begin

end;

procedure TForm2.Label1Click(Sender: TObject);
begin

end;

procedure TForm2.Label2Click(Sender: TObject);
begin

end;

procedure TForm2.Label3Click(Sender: TObject);
begin

end;

end.

