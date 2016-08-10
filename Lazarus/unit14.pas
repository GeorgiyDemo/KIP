unit Unit14;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Buttons, ExtCtrls;

type

  { TForm14 }

  TForm14 = class(TForm)
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
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
  Form14: TForm14;

implementation
     uses Unit1,Unit13;
{$R *.lfm}

{ TForm14 }

procedure TForm14.BitBtn1Click(Sender: TObject);
begin
   Form13.Show;
   Form14.Close;
end;

procedure TForm14.BitBtn2Click(Sender: TObject);
begin
  Form1.Show;
  Form14.Close;
end;

end.

