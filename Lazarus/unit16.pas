unit Unit16;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ExtCtrls,
  StdCtrls, Buttons;

type

  { TForm16 }

  TForm16 = class(TForm)
    BitBtn1: TBitBtn;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Button6: TButton;
    Image1: TImage;
    Image2: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    procedure BitBtn1Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Label1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form16: TForm16;

implementation
    uses Unit1,Unit15,Unit19;
{$R *.lfm}

{ TForm16 }

procedure TForm16.Label1Click(Sender: TObject);
begin

end;

procedure TForm16.Button1Click(Sender: TObject);
begin
  Form15.Show;
end;

procedure TForm16.BitBtn1Click(Sender: TObject);
begin
  Form1.Show;
  Form16.Hide;
end;

procedure TForm16.Button3Click(Sender: TObject);
begin
  Form19.Show;
end;

end.

