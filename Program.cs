using DesafioPOO.Models;



// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("1","Modelo 1","123",128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("2","Modelo 2","567",256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");




