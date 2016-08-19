unit Unit3;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm3 }

  TForm3 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Image1: TImage;
    Image3: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Edit1Change(Sender: TObject);
    procedure Edit3Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image1Click(Sender: TObject);
    procedure Image3Click(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure Label6Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form3: TForm3;

implementation
    uses Unit1;
{$R *.lfm}

{ TForm3 }

procedure TForm3.Label1Click(Sender: TObject);
begin

end;

procedure TForm3.Label6Click(Sender: TObject);
begin

end;

procedure TForm3.FormCreate(Sender: TObject);
begin

end;

procedure TForm3.Image1Click(Sender: TObject);
begin

end;

procedure TForm3.Image3Click(Sender: TObject);
begin

end;

procedure TForm3.Button1Click(Sender: TObject);
begin
  Form1.Show;
  Edit1.Clear;
  Edit2.Clear;
  Edit3.Clear;
  Edit4.Clear;
  Form3.Close;
end;

procedure TForm3.Button2Click(Sender: TObject);
  var D,Q,b,x:real;
begin
  try  //Проверка на корректность переменной x
    x:=StrToFloat(Edit1.Text);
    except
      on EConvertError do
      begin
        MessageDlg('Некорректный ввод x',mtWarning,[mbOk],0);
        exit;
      end;
    end;
    try //Проверка на корректность переменной b
    b:=StrToFloat(Edit2.Text);
    except
      on EConvertError do
      begin
        MessageDlg('Некорректный ввод b',mtWarning,[mbOk],0);
        exit;
      end;
    end;
   x:=StrToFloat(Edit1.Text);
   b:=StrToFloat(Edit2.Text);
    if (b*x)<1 then
        begin
         D:=1;     //Ветвь №1
         Q:=(b*x)-ln(b*x)
        end
           else if (b*x)=1 then
             begin
                D:=2; //Ветвь №2
                Q:=1
             end
                else if (b*x)>1 then
                  begin
                    D:=3;    //Ветвь №3
                    Q:=(b*x)+ln((b*x))
                  end;
 Edit3.Text:=FloatToStr(D);
 Edit4.Text:=FloatToStrf(Q,ffFixed,5,5);
end;

procedure TForm3.Edit1Change(Sender: TObject);
begin

end;

procedure TForm3.Edit3Change(Sender: TObject);
begin

end;

end.

