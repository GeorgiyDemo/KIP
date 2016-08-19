unit Unit7;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm7 }

  TForm7 = class(TForm)
    Button1: TButton;
    Memo1: TMemo;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    RadioButton3: TRadioButton;
    RadioButton4: TRadioButton;
    RadioGroup1: TRadioGroup;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Memo1Change(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form7: TForm7;
implementation
          uses Unit6,Unit8;
{$R *.lfm}

{ TForm7 }

procedure TForm7.Memo1Change(Sender: TObject);
begin

end;

procedure TForm7.Button1Click(Sender: TObject);
begin
  if (RadioButton1.Checked = false) and (RadioButton2.Checked = false) and
  (RadioButton3.Checked = false) and (RadioButton4.Checked = false)  then
               MessageDlg('Увы, необходимо ответить на вопрос №2',mtWarning,[mbOk],0)
  else if RadioButton2.Checked = true then
               begin
                 MessageDlg('Ответ верен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
                 q2:=1;
                 n:=n+1;
                 RadioButton1.Enabled:= false;
                 RadioButton2.Enabled:= false;
                 RadioButton3.Enabled:= false;
                 RadioButton4.Enabled:= false;
                 Form8.Show;
                 Form7.Hide;
               end;
  if (RadioButton1.Checked = true) or (RadioButton3.Checked = true) or (RadioButton4.Checked = true) then
               begin
               MessageDlg('Ответ неверен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
               RadioButton1.Enabled:= false;
               RadioButton2.Enabled:= false;
               RadioButton3.Enabled:= false;
               RadioButton4.Enabled:= false;
               Form8.Show;
               Form7.Hide;
               end;
end;

procedure TForm7.FormCreate(Sender: TObject);
begin

end;

end.

