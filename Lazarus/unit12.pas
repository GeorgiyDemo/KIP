unit Unit12;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls, CheckLst, Buttons;

type

  { TForm12 }

  TForm12 = class(TForm)
    BitBtn1: TBitBtn;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckBox6: TCheckBox;
    CheckGroup1: TCheckGroup;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    procedure BitBtn1Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure CheckBox1Change(Sender: TObject);
    procedure FormActivate(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form12: TForm12;
implementation
      uses Unit5,Unit6,Unit7,Unit8,Unit9,Unit10,Unit11;
{$R *.lfm}

{ TForm12 }

procedure TForm12.FormCreate(Sender: TObject);
begin

end;

procedure TForm12.CheckBox1Change(Sender: TObject);
begin

end;

procedure TForm12.FormActivate(Sender: TObject);
var itemlist1:Array[0..5] of System.String;
      j:integer;
begin
if (q1=1) then CheckBox1.Checked:= true;
if (q2=1) then CheckBox2.Checked:= true;
if (q3=1) then CheckBox3.Checked:= true;
if (q4=1) then CheckBox4.Checked:= true;
if (q5=1) then CheckBox5.Checked:= true;
if (q6=1) then CheckBox6.Checked:= true;
//Условный оператор case
Label3.Caption:='Правильных ответов: '+ FloatToStr(n);
case n of
 0..1: Label2.Caption:= 'Ваша оценка: 2';
 2..3: Label2.Caption:= 'Ваша оценка: 3';
 4..5: Label2.Caption:= 'Ваша оценка: 4';
 6: Label2.Caption:= 'Ваша оценка: 5';
 end;
         Form6.CheckBox1.Enabled:= true;
         Form6.CheckBox1.Checked:= false;
         Form6.CheckBox2.Enabled:= true;
         Form6.CheckBox2.Checked:= false;
         Form6.CheckBox3.Enabled:= true;
         Form6.CheckBox3.Checked:= false;
         Form6.CheckBox4.Enabled:= true;
         Form6.CheckBox4.Checked:= false;
         Form6.CheckBox5.Enabled:= true;
         Form6.CheckBox5.Checked:= false;
         Form7.RadioButton1.Enabled:= true;
         Form7.RadioButton1.Checked:= false;
         Form7.RadioButton2.Enabled:= true;
         Form7.RadioButton2.Checked:= false;
         Form7.RadioButton3.Enabled:= true;
         Form7.RadioButton3.Checked:= false;
         Form7.RadioButton4.Enabled:= true;
         Form7.RadioButton4.Checked:= false;
         Form8.ScrollBar1.Enabled:= true;
         Form8.ScrollBar1.Position := 10 ;
         Form9.ComboBox1.Enabled:= true;
         Form9.ComboBox1.Text:='Выберите правильный ответ =>';
         Form9.ComboBox2.Enabled:= true;
         Form9.ComboBox2.Text:='Выберите правильный ответ =>';
         Form9.ComboBox3.Enabled:= true;
         Form9.ComboBox3.Text:='Выберите правильный ответ =>';
         Form10.BitBtn1.Enabled:= true;
         Form10.BitBtn2.Enabled:= true;
         Form10.BitBtn3.Enabled:= true;
         Form10.BitBtn4.Enabled:= true;
         Form10.BitBtn5.Enabled:= true;
         Form10.BitBtn6.Enabled:= true;
         Form10.BitBtn7.Enabled:= true;
         Form10.ListBox1.Items.Clear;
         Form10.ListBox2.Items.Clear;
         Form10.ListBox3.Items.Clear;
         Form10.ListBox4.Items.Clear;
         Form10.ListBox5.Items.Clear;
         Form10.ListBox6.Items.Clear;
         Form10.ListBox7.Items.Clear;
              itemlist1[0] := 'Постановка задачи;';
              itemlist1[1] := 'Отладка программы;';
              itemlist1[2] := 'Анализ результатов;';
              itemlist1[3] := 'Разработка алгоритма;';
              itemlist1[4] := 'Разработка программы;';
              itemlist1[5] := 'Разработка математической модели;';
              for j := 0 to 5 do
              begin
         Form10.Listbox1.Items.Add(itemlist1[j]);
              end;
         Form11.CheckListBox1.Items.Add('Управление устройствами');
         Form11.CheckListBox1.Items.Add('Управление процессами');
         Form11.CheckListBox1.Items.Add('Создание текстовых документов');
         Form11.CheckListBox1.Items.Add('Управление памятью');
         Form11.CheckListBox1.Items.Add('Управление данными');
         Form11.CheckListBox1.Items.Add('Программирование');
end;

procedure TForm12.Button1Click(Sender: TObject);
begin
end;

procedure TForm12.BitBtn1Click(Sender: TObject);
begin
              Form5.Show;
              Form12.Hide;
end;

end.

