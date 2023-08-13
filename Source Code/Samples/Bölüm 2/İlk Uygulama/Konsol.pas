program DotNetKitabi.OrnekUygulamalar;

uses
  SysUtils;

var
  OkunanMetin: string;
begin
  Console.WriteLine('Herhangi bir deðer giriniz:');
  ReadLn(okunanMetin);
  Console.WriteLine(Format('Tarih-Saat:%s,Girilen Deðer:%s', [DateTimeToStr(Now),  OkunanMetin]));
end.
