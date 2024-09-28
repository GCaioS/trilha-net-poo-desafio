using DesafioPOO.Models;

Smartphone iphone = new Iphone("12345678", "Iphone 16", "000000000000", 256);

Console.WriteLine("Aplicativo Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");

Smartphone nokia = new Nokia("12345678", "Iphone 16", "000000000000", 256);

Console.WriteLine("Aplicativo Nokia");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");