unit Unit15;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Buttons, ExtCtrls;

type

  { TForm15 }

  TForm15 = class(TForm)
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    Label1: TLabel;
    Label7: TLabel;
    procedure BitBtn1Click(Sender: TObject);
    procedure BitBtn2Click(Sender: TObject);
    procedure BitBtn3Click(Sender: TObject);
    procedure Edit4Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form15: TForm15;
implementation
      uses Unit16,Unit17;
{$R *.lfm}

{ TForm15 }
procedure TForm15.BitBtn1Click(Sender: TObject);
begin
  Form15.Hide;
  Form17.Show;
end;

procedure TForm15.BitBtn2Click(Sender: TObject);
begin
  Form16.Show;
  Form15.Hide;
end;

procedure TForm15.BitBtn3Click(Sender: TObject);
begin
end;

procedure TForm15.Edit4Change(Sender: TObject);
begin

end;

procedure TForm15.FormCreate(Sender: TObject);
begin
end;

end.

