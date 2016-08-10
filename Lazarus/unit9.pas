unit Unit9;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Buttons;

type

  { TForm9 }

  TForm9 = class(TForm)
    BitBtn1: TBitBtn;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    ComboBox3: TComboBox;
    Memo1: TMemo;
    Memo2: TMemo;
    Memo3: TMemo;
    procedure BitBtn1Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Memo1Change(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form9: TForm9;
implementation
        uses Unit5,Unit6,Unit7,Unit8,Unit10;
{$R *.lfm}

{ TForm9 }

procedure TForm9.Button1Click(Sender: TObject);
begin
end;


procedure TForm9.BitBtn1Click(Sender: TObject);
begin
     if (ComboBox1.ItemIndex=-1) or (ComboBox2.ItemIndex=-1) or (ComboBox3.ItemIndex=-1) then
         MessageDlg('Увы, необходимо ответить на вопрос №4',mtWarning,[mbOk],0)
    else if (ComboBox1.ItemIndex=2) and (ComboBox2.ItemIndex=2) and (ComboBox3.ItemIndex=1) then
         begin
               MessageDlg('Ответ верен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
               n:=n+1;
               q4:=1;
               ComboBox1.Enabled:= false;
               ComboBox2.Enabled:= false;
               ComboBox3.Enabled:= false;
               Form10.Show;
               Form9.Hide;
         end
     else
     begin
         MessageDlg('Ответ неверен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
               ComboBox1.Enabled:= false;
               ComboBox2.Enabled:= false;
               ComboBox3.Enabled:= false;
               Form10.Show;
               Form9.Hide;
     end;
end;

procedure TForm9.ComboBox1Change(Sender: TObject);
begin

end;

procedure TForm9.FormCreate(Sender: TObject);
begin

end;

procedure TForm9.Memo1Change(Sender: TObject);
begin

end;

end.

