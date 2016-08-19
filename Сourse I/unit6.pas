unit Unit6;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm6 }

  TForm6 = class(TForm)
    Button1: TButton;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckGroup1: TCheckGroup;
    Memo1: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Memo1Change(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form6: TForm6;
  n,q1,q2,q3,q4,q5,q6:integer;

implementation
       uses Unit7,Unit8,Unit12;
{$R *.lfm}

{ TForm6 }

procedure TForm6.FormCreate(Sender: TObject);
begin

end;

procedure TForm6.Button1Click(Sender: TObject);
begin
         Form12.CheckBox1.Checked:= false;
         Form12.CheckBox2.Checked:= false;
         Form12.CheckBox3.Checked:= false;
         Form12.CheckBox4.Checked:= false;
         Form12.CheckBox5.Checked:= false;
         Form12.CheckBox6.Checked:= false;
  n:=0;
  q1:=0;
  q2:=0;
  q3:=0;
  q4:=0;
  q5:=0;
  q6:=0;
  if  (CheckBox1.Checked = false) and (CheckBox2.Checked = false) and (CheckBox3.Checked = false)and
      (CheckBox4.Checked = false) and (CheckBox5.Checked = false) then
                          MessageDlg('Увы, сначала необходимо ответить на вопрос №1',mtWarning,[mbOk],0)
  else if (CheckBox1.Checked = true) and (CheckBox2.Checked = false) and (CheckBox3.Checked = true)and
      (CheckBox4.Checked = false) and (CheckBox5.Checked = false) then
      begin
        MessageDlg('Ответ верен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
        q1:=1;
        n:=n+1;
        CheckBox1.Enabled:= false;
        CheckBox2.Enabled:= false;
        CheckBox3.Enabled:= false;
        CheckBox4.Enabled:= false;
        CheckBox5.Enabled:= false;
        Form7.Show;
        Form6.Hide;
      end
  else
  begin
         MessageDlg('Ответ неверен, переходим к следующему вопросу..',mtWarning,[mbOk],0);
        CheckBox1.Enabled:= false;
        CheckBox2.Enabled:= false;
        CheckBox3.Enabled:= false;
        CheckBox4.Enabled:= false;
        CheckBox5.Enabled:= false;
     Form7.Show;
     Form6.Hide;
  end;
end;

procedure TForm6.Memo1Change(Sender: TObject);
begin

end;

end.

