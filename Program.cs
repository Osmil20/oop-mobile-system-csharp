﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nókia: ");
Smartphone nokia = new Nokia (numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone (numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");