using GestionCarrera;

Director d1 = new Director(10, "Luis", "Logistica");

Console.WriteLine(d1);


Horario h1 = new Horario("lunes", 19, 20);


Console.WriteLine(h1);

Curso c1 = new("Mate 1",5,h1,d1);
Console.WriteLine(c1);

Semestre s1 = new Semestre(1);
Semestre s2 = new Semestre(2);
Semestre s3 = new Semestre(3);
Semestre s4 = new Semestre(4);

Carrera cr1 = new Carrera(10, "Desarrollo de Software", "Carrera con orientacion a desarrollo", 6,d1);



List<Semestre> Semestres = cr1.GetSemestres();

Semestres.Add(s1);
Semestres.Add(s2);
Semestres.Add(s3);
Semestres.Add(s4);

cr1.GetSemestres();

Semestre sm1 = Semestres[0];

int st1 = Semestres[0].GetNumero();

Console.WriteLine(st1);