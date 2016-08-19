unit Unit4;

{$mode objfpc}{$H+}

interface

uses
  Math, Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs,
  StdCtrls, ExtCtrls;

type

  { TForm4 }

  TForm4 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Edit4Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Label4Click(Sender: TObject);
    procedure Label7Click(Sender: TObject);
    procedure StaticText1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form4: TForm4;
  //n,q1,q2,q3,q4,q5,q6 не трогать
  y_form4,d_form4,x_form4,e_form4,c_form4,min_form4,max_form4,way_form4,result_form4:real;
  //объявили кучу глобальных переменных
implementation
      uses Unit1;

{$R *.lfm}

{ TForm4 }
procedure minmax(y,d,x,e,c,min,max:real);
begin
 if (x>0) and (power(e,-x)>=y) then                //Ветка №1
            begin
                 way_form4:=1;
                 max:=log10(x);
                 if (x+y)>(max) then
                        max:=(x+y);
                 min:=power(x,3);
                 if power(e,-x+1)<min then
                       min:=power(e,-x+1);
                 if max<min then
                      min:=max;
                 result_form4:=min
             end
      else if (x<=0) and (power(e,-x)>=y) then    //Ветка №2
           begin
                way_form4:=2;
                result_form4:=1-(power(x,2))
           end
      else                                        //Ветка №3
       begin
           way_form4:=3;
           max:=x*power(c,2);
           if cos(x+y)>max then
           max:=d*(cos(x+y));
           result_form4:=max
       end;
  end;
procedure TForm4.Button1Click(Sender: TObject);
begin
x_form4:=StrToFloat(Edit1.Text);
y_form4:=StrToFloat(Edit2.Text);
e_form4:=StrToFloat(Edit3.Text);
c_form4:=StrToFloat(Edit4.Text);
d_form4:=StrToFloat(Edit7.Text);
       minmax(y_form4,d_form4,x_form4,e_form4,c_form4,min_form4,max_form4);
       Edit5.Text:=FloatToStr(result_form4);
       Edit6.Text:=FloatToStr(way_form4);
end;


procedure TForm4.Button2Click(Sender: TObject);
begin
  Form1.Show;
  Edit1.Clear;
  Edit2.Clear;
  Edit3.Clear;
  Edit4.Clear;
  Edit5.Clear;
  Edit6.Clear;
  Edit7.Clear;
  Form4.Close;
end;

procedure TForm4.Edit4Change(Sender: TObject);
begin

end;

procedure TForm4.FormCreate(Sender: TObject);
begin

end;

procedure TForm4.Label4Click(Sender: TObject);
begin

end;

procedure TForm4.Label7Click(Sender: TObject);
begin

end;

procedure TForm4.StaticText1Click(Sender: TObject);
begin

end;

end.

