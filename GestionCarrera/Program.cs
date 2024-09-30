using GestionCarrera;

Director d1 = new Director(10, "Luis", "Logistica");

Console.WriteLine(d1);


Horario h1 = new Horario("lunes", 19, 20);


Console.WriteLine(h1);

Curso c1 = new("Mate 1",5,h1,d1);
Console.WriteLine(c1);

