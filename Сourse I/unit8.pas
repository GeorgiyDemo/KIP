unit Unit8;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm8 }

  TForm8 = class(TForm)
    Button1: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    ScrollBar1: TScrollBar;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure ScrollBar1Change(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form8: TForm8;

implementation
        uses Unit5,Unit6,Unit7,Unit9;
{$R *.lfm}

        { TForm8 }

procedure TForm8.Button1Click(Sender: TObject);
begin
     if (ScrollBar1.Position=8) then
        begin
           q3:=1;
           n:=n+1;
            MessageDlg('Ответ верен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
            ScrollBar1.Enabled:= false;
            Form9.Show;
            Form8.Hide;
        end
        else
        begin
            MessageDlg('Ответ неверен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
            ScrollBar1.Enabled:= false;
            Form9.Show;
            Form8.Hide;
        end;
end;

procedure TForm8.FormCreate(Sender: TObject);
begin
 ScrollBar1.Min := 0 ;
 ScrollBar1.Max := 20 ;
 ScrollBar1.LargeChange := 5 ;
 ScrollBar1.Position := 10 ;
end;

procedure TForm8.ScrollBar1Change(Sender: TObject);
begin
  Label1.Caption := inttostr(ScrollBar1.Position) + ' бит' ;
end;

end.

