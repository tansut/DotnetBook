program DotNetKitabi.OrnekUygulamalar;

uses
  SysUtils;

var
  OkunanMetin: string;
begin
  Console.WriteLine('Herhangi bir de�er giriniz:');
  ReadLn(okunanMetin);
  Console.WriteLine(Format('Tarih-Saat:%s,Girilen De�er:%s', [DateTimeToStr(Now),  OkunanMetin]));
end.
