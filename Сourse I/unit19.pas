unit Unit19;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, Buttons,
  StdCtrls, ExtCtrls;

type

  { TForm19 }

  TForm19 = class(TForm)
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    procedure BitBtn1Click(Sender: TObject);
    procedure BitBtn2Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form19: TForm19;

implementation
      uses Unit16,Unit20;
{$R *.lfm}

{ TForm19 }

procedure TForm19.BitBtn1Click(Sender: TObject);
begin
  Form20.Show;
  Form19.Hide;
end;

procedure TForm19.BitBtn2Click(Sender: TObject);
begin
  Form16.Show;
  Form19.Hide;
end;

end.

