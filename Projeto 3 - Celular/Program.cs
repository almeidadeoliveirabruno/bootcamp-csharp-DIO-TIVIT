using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(numero:"123456789", modelo:"Nokia 3310", imei:"IMEI123456", memoria:16);
Iphone iphone = new Iphone(numero:"987654321", modelo:"iPhone 12", imei:"IMEI987654", memoria:128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();
