unit UMain;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, SynEditExport, SynExportRTF, SynEdit,
  SynEditHighlighter, SynHighlighterCS, SynHighlighterDOT,
  SynHighlighterJScript, SynHighlighterHtml, SynHighlighterCSS,
  SynHighlighterCpp, ExtCtrls, SynHighlighterXML, SynHighlighterSQL,
  SynHighlighterPHP, SynHighlighterPas, SynHighlighterJava,
  SynHighlighterIDL, WordXP, OleServer, Clipbrd, SynHighlighterVB,
  SynHighlighterGeneral, Spin;

type
  TForm1 = class(TForm)
    SynEdit1: TSynEdit;
    SynExporterRTF1: TSynExporterRTF;
    Panel1: TPanel;
    ctlLangList: TComboBox;
    Button1: TButton;
    SynCSSyn1: TSynCSSyn;
    SynCppSyn1: TSynCppSyn;
    SynIdlSyn1: TSynIdlSyn;
    SynHTMLSyn1: TSynHTMLSyn;
    SynJavaSyn1: TSynJavaSyn;
    SynJScriptSyn1: TSynJScriptSyn;
    SynPasSyn1: TSynPasSyn;
    SynPHPSyn1: TSynPHPSyn;
    SynSQLSyn1: TSynSQLSyn;
    SynXMLSyn1: TSynXMLSyn;
    Button2: TButton;
    msword: TWordApplication;
    doc: TWordDocument;
    Button3: TButton;
    Image1: TImage;
    RadioGroup1: TRadioGroup;
    SynGeneralSyn1: TSynGeneralSyn;
    Button4: TButton;
    SpinEdit1: TSpinEdit;
    Button5: TButton;
    Button6: TButton;
    Button7: TButton;
    Button8: TButton;
    Button9: TButton;
    Button10: TButton;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure ctlLangListChange(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure Button10Click(Sender: TObject);
  private
    procedure QuickAktar(Index: Integer);
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

Procedure FileCopy(Const SourceFileName, TargetFileName: String );
Var
  S, T: TFileStream;
Begin
  S := TFileStream.Create(sourcefilename, fmOpenRead );
  try
    T := TFileStream.Create(targetfilename, fmOpenWrite or fmCreate);
   try
     T.CopyFrom(S, S.Size ) ;
   finally
     T.Free;
   end;
  finally
   S.Free;
  end;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  SynExporterRTF1.ExportAll(SynEdit1.Lines);
  SynExporterRTF1.CopyToClipboard;
end;

procedure TForm1.FormCreate(Sender: TObject);
var I: Integer;
    obj: TSynCustomHighlighter;
begin
  for I := 0 to Self.ComponentCount - 1 do
  begin
    if (self.Components[i] is TSynCustomHighlighter) then
    begin
      obj := self.Components[i] as TSynCustomHighlighter;
      ctlLangList.AddItem(obj.LanguageName, obj);
    end;
  end;

end;

procedure TForm1.ctlLangListChange(Sender: TObject);
begin
  SynEdit1.Highlighter := ctlLangList.Items.objects[ctlLangList.ItemIndex] as  TSynCustomHighlighter;
  SynExporterRTF1.Highlighter := SynEdit1.Highlighter;
end;

procedure TForm1.Button2Click(Sender: TObject);
var StyleIndex, WordStyle: OleVariant;
begin
  SynEdit1.Lines.Text := Trim(SynEdit1.Lines.Text);
  SynExporterRTF1.ExportAll(SynEdit1.Lines);
  SynExporterRTF1.CopyToClipboard;
  msword.Connect;
  StyleIndex := 'BookCode';
  if RadioGroup1.ItemIndex = 1 then
    StyleIndex := 'BookCodeInTable';
  WordStyle := msword.ActiveDocument.Styles.Item(StyleIndex);
  MsWord.Selection.Set_Style(WordStyle);
  msword.Selection.PasteAndFormat(wdFormatSurroundingFormattingWithEmphasis);
end;

procedure TForm1.Button3Click(Sender: TObject);
var FileName: OleVariant;
    Desc: OleVariant;
begin
  FileName := InputBox('', 'Dosya adý', '');
  if FileName > '' then
  begin
    FileName := 'C:\Documents and Settings\Tansu\My Documents\Books\DotNet\Documents\BookPictures\Ekran\' + FileName;
    if FileExists(Filename) then
    begin
      if MessageDlg('Dosya zaten var. Üzerine mi yazayým ?', mtConfirmation, [mbYes, mbNo], 0) <> mryes then
        exit;
    end;
    Desc := InputBox('Desc', '', '');
    FileCopy('C:\Documents and Settings\Tansu\My Documents\Books\DotNet\Temp\ScreenCaptures\LastCapture.tif',
             Filename);
    FileCopy('C:\Documents and Settings\Tansu\My Documents\Books\DotNet\Temp\ScreenCaptures\LastCaptureOrj.tif',
             'C:\Documents and Settings\Tansu\My Documents\Books\DotNet\Documents\BookPictures\OrjEkran\' + ExtractFileName(FileName));

    msword.Run('EkranEkleWithParam', FileName, Desc);
  end;

end;

procedure TForm1.Button4Click(Sender: TObject);
var I, Cut: Integer;
begin
  Cut := SpinEdit1.Value;
  for i := 0 to SynEdit1.Lines.Count - 1 do
  begin
    if (Length(SynEdit1.Lines[i]) >= Cut) and (SynEdit1.Lines[i][Cut] = ' ')  then
    SynEdit1.Lines[i] := Copy(SynEdit1.Lines[i], Cut+1, 10000);
  end;
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
  ctlLangList.ItemIndex := 0;
    ctlLangListChange(self);
end;

procedure TForm1.Button6Click(Sender: TObject);
begin
  ctlLangList.ItemIndex := ctlLangList.Items.Count - 1;
  ctlLangListChange(self);
end;

procedure TForm1.Button7Click(Sender: TObject);
begin
  SynEdit1.Clear;
  SynEdit1.PasteFromClipboard;
end;

procedure TForm1.Button9Click(Sender: TObject);
begin
  QuickAktar(0);
end;

procedure TForm1.QuickAktar(Index: Integer);
begin
  SynEdit1.Clear;
  SynEdit1.PasteFromClipboard;
  ctlLangList.ItemIndex := index;
  ctlLangListChange(self);
  Button2Click(self);  
end;

procedure TForm1.Button10Click(Sender: TObject);
begin
   QuickAktar(ctlLangList.Items.Count - 1);
end;

end.
