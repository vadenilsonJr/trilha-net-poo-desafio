using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
var nokia = new Nokia("99 99999-9999", "Nokia LUMIA", "1231354646987", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook LITE");

Console.WriteLine("Smartphone Apple (Iphone): ");
var iphone = new Iphone("88 88888-8888", "Iphone 12 PRO MAX", "000223234587887", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");