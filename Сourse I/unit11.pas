unit Unit11;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls, CheckLst;

type

  { TForm11 }

  TForm11 = class(TForm)
    Button1: TButton;
    CheckListBox1: TCheckListBox;
    Memo1: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form11: TForm11;

implementation
         uses Unit5,Unit6,Unit7,Unit8,Unit10,Unit12;
{$R *.lfm}

{ TForm11 }

procedure TForm11.FormCreate(Sender: TObject);
begin
CheckListBox1.Items.Add('Управление устройствами');
CheckListBox1.Items.Add('Управление процессами');
CheckListBox1.Items.Add('Создание текстовых документов');
CheckListBox1.Items.Add('Управление памятью');
CheckListBox1.Items.Add('Управление данными');
CheckListBox1.Items.Add('Программирование');
end;

procedure TForm11.Button1Click(Sender: TObject);
begin
 if not(CheckListBox1.Checked[0]) and not(CheckListBox1.Checked[1]) and
    not(CheckListBox1.Checked[2]) and not(CheckListBox1.Checked[3]) and
    not(CheckListBox1.Checked[4]) and not(CheckListBox1.Checked[5]) then
         MessageDlg('Увы, необходимо ответить на вопрос №6',mtWarning,[mbOk],0)
 else if (CheckListBox1.Checked[0]) and (CheckListBox1.Checked[1]) and not(CheckListBox1.Checked[2])
 and (CheckListBox1.Checked[3]) and (CheckListBox1.Checked[4]) and not(CheckListBox1.Checked[5]) then
         begin
           CheckListBox1.Items.Clear;
            MessageDlg('Ответ верен, переходим к результатам теста..',mtWarning,[mbOk],0);
            q6:=1;
            n:=n+1;
            Form12.Show;
            Form11.Hide;
         end
 else
         begin
              CheckListBox1.Items.Clear;
              MessageDlg('Ответ неверен, переходим к результатам теста..',mtWarning,[mbOk],0);
              Form12.Show;
              Form11.Hide;
         end;
end;
end.

