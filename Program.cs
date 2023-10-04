using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia:");
Nokia nokia = new Nokia(numero:"12345",modelo:"modelo 1", imei:"11111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Iphone:");

Iphone iphone = new Iphone(numero:"4568",modelo:"modelo 2", imei:"2222222",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");