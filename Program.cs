using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "(11)948465661", modelo: "5.5", imei:"222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Smartphone nokia = new Nokia(numero: "(21)987885456", modelo: "12.1", imei: "2121", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
