unit Unit18;

{$mode objfpc}{$H+}

interface

uses
  Math, Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm18 }

  TForm18 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label9: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form18: TForm18;
        y_form18,d_form18,x_form18,e_form18,c_form18,min_form18,max_form18,way_form18,ProcedureResult_form18:single;
implementation
        uses Unit16;
{$R *.lfm}

{ TForm18 }
function uslovie1(var y,x,e:single):single;
var min,max:single;
begin

                 way_form18:=1;
                 max:=log10(x);
                 if (x+y)>(max) then
                        max:=(x+y);
                 min:=power(x,3);
                 if power(e,-x+1)<min then
                       min:=power(e,-x+1);
                 if max<min then
                      min:=max;
                 uslovie1:=min;
 end;
procedure max_min(var y,d,x,e,c:single);
var max:single;
begin
 if (x>0) and (power(e,-x)>=y) then  //Ветка №1
            begin
                ProcedureResult_form18:=uslovie1(y,x,e);
             end
      else if (x<=0) and (power(e,-x)>=y) then //Ветка №2
           begin
                way_form18:=2;
                ProcedureResult_form18:=1-(power(x,2))
           end
      else                              //Ветка №3
       begin
           way_form18:=3;
           max:=x*power(c,2);
           if cos(x+y)>max then
           max:=d*(cos(x+y));
           ProcedureResult_form18:=max
       end;
  end;

function minmax(var y,d,x,e,c:single):single;
 var max:single;
begin
 if (x>0) and (power(e,-x)>=y) then  //Ветка №1
            begin
               minmax:=uslovie1(y,x,e);
             end
      else if (x<=0) and (power(e,-x)>=y) then //Ветка №2
           begin
                way_form18:=2;
                minmax:=1-(power(x,2))
           end
      else                                //Ветка №3
       begin
           way_form18:=3;
           max:=x*power(c,2);
           if cos(x+y)>max then
           max:=d*(cos(x+y));
           minmax:=max
       end;
  end;
procedure TForm18.Button1Click(Sender: TObject);
begin
x_form18:=StrToFloat(Edit1.Text);
y_form18:=StrToFloat(Edit2.Text);
e_form18:=StrToFloat(Edit3.Text);
c_form18:=StrToFloat(Edit4.Text);
d_form18:=StrToFloat(Edit7.Text);
       max_min(y_form18,d_form18,x_form18,e_form18,c_form18);
       Edit5.Text:=FloatToStr(minmax(y_form18,d_form18,x_form18,e_form18,c_form18));
       Edit8.Text:=FloatToStr(ProcedureResult_form18);
       Edit6.Text:=FloatToStr(way_form18);
end;

procedure TForm18.Button2Click(Sender: TObject);
begin
  Form16.Show;
  Edit1.Clear;
  Edit2.Clear;
  Edit3.Clear;
  Edit4.Clear;
  Edit5.Clear;
  Edit6.Clear;
  Edit7.Clear;
  Edit8.Clear;
  Form18.Hide;
end;

end.

