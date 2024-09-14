using DesafioPOO.Models;

Nokia nokia = new Nokia("3823242432", "Nokia X", "24234", 64);
Iphone iphone = new Iphone("324344432", "Iphone 1334 geração", "2434", 1);

nokia.Ligar();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Shadow Fight");
iphone.InstalarAplicativo("Limpador de memoria");