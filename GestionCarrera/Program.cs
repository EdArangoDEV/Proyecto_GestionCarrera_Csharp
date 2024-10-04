namespace GestionCarrera;

public class Institucion
{

    public static void Main(String[] args)
    {
        // Creacion de objetos principales
        Director dir1 = new(2401, "Ing. Luis Marroquin", "Logistica");

        Carrera cr1 = new(2401, "Tecnico de Desarollo de Software",
                    "Programa de estudios en Ingeniería de Software", 5, dir1);
        cr1.AgregarSemestres();

        Horario h1 = new("Lunes", 18, 19);
        Horario h2 = new("Miercoles", 19, 20);
        Horario h3 = new("Viernes", 20, 21);

        Profesor p1 = new(2402, "Marvin Castillo", "Matematicas");
        Profesor p2 = new(2403, "Alejandra Torres", "Idioma Ingles");

        Curso c1 = new("Mate1", 5, h1, p1);
        Curso c2 = new("Logica", 7, h2, dir1);
        Curso c3 = new("Ingles", 6, h3, p2);

        List<Semestre> Semestres = cr1.GetSemestres();

        Semestres[0].AgregarCurso(c1);
        Semestres[0].AgregarCurso(c2);
        Semestres[0].AgregarCurso(c3);

        Console.Clear();
        while (true)
        {
            InformacionCarrera(cr1);
            MostrarMenuPrincipal();
            int opcionPrincipal = LeerOpcion();

            switch (opcionPrincipal) {
                case 1:
                    EditarDatosCarrera(cr1);
                    break;
                case 2:
                    ;
                    //editarDirector(cr1, cr1.director);
                    break;
                case 3:
                   // editarSemestres(cr1);
                    break;
                case 4:
                    Console.WriteLine("\nSaliendo del programa...");
                    LimpiarConsola();
                    return;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    LimpiarConsola();
                    break;
            }
            
        }
        
    }

    private static void LimpiarConsola(){
        Thread.Sleep(1000);
        Console.Clear();
    }

    private static void LimpiraIngreso(){
        Thread.Sleep(500);
        Console.Clear();
    }

    private static void InformacionCarrera(Carrera carrera)
    {
        Console.WriteLine("Sistema de Gestion de carrera!\n");
        Console.WriteLine(carrera);
    }

    private static void MostrarMenuPrincipal() {
         Console.WriteLine("\nMenú principal:");
         Console.WriteLine("1. Editar datos carrera");
         Console.WriteLine("2. Director carrera");
         Console.WriteLine("3. Ver semestres carrera");
         Console.WriteLine("4. Salir");
    }

    private static void MenuDatosCarrera() {

        Console.WriteLine("Opciones datos Carrera:\n");
        Console.WriteLine("1. Editar Nombre");
        Console.WriteLine("2. Editar Descripcion");
        Console.WriteLine("3. regresar");
    }

    private static void MenuDirectorCarrera() {

        Console.WriteLine("Opciones Director Carrera:\n");
        Console.WriteLine("1. Cambiar de director");
        Console.WriteLine("2. regresar");
    }

    private static void MenuDatosDirectorCarrera() {

        Console.WriteLine("Opciones Director actual:\n");
        Console.WriteLine("1. Editar Nombre");
        Console.WriteLine("2. Editar Especialidad");
        Console.WriteLine("3. regresar");
    }

    private static void MenuSemestres() {

        Console.WriteLine("\nOpciones datos Semestres:\n");
        Console.WriteLine("1. Editar cursos semestre");
        Console.WriteLine("2. regresar");
    }

    private static void MenuCursos() {

        Console.WriteLine("\nOpciones datos Cursos:\n");
        Console.WriteLine("1. Editar Nombre de curso");
        Console.WriteLine("2. Editar Horario de curso");
        Console.WriteLine("3. Editar Profesor de curso");
        Console.WriteLine("4. Agregar curso");
        Console.WriteLine("5. Eliminar curso");
        Console.WriteLine("6. regresar");
    }

    private static void EditarDatosCarrera(Carrera carrera){
        do
        {
            Console.WriteLine("Datos actuales de la carrera: " + carrera.GetNombre() + ", descripcion: " + carrera.GetDescripcion() + ".\n");
            MenuDatosCarrera();
            int opcionPrincipal = LeerOpcion();

            switch (opcionPrincipal) {
                case 1:
                    Console.Write("Ingrese nuevo nombre de carrera: ");
                    string Nnombre = Console.ReadLine();
                    carrera.SetNombre(Nnombre);
                    LimpiraIngreso();
                    break;
                case 2:
                    Console.Write("Ingrese nueva descripcion de la carrera: ");
                    string nDescripcion = Console.ReadLine();
                    carrera.SetDescripcion(nDescripcion);
                    LimpiraIngreso();
                    break;
                case 3:
                    Console.WriteLine("\nRegresando a Menu principal...");
                    LimpiarConsola();
                    return;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.\n");
                    LimpiraIngreso();
                    break;
            }

        } while (true);
    }

    private static Empleado AgregarDirector(Carrera carrera){
        Console.Write("Ingrese el codigo de empleado: ");
        int codP = int.Parse(Console.ReadLine());
        LimpiraIngreso();
        Profesor profEncontrado = carrera.GetProfesores(codP);
        Empleado emp;
        LimpiraIngreso();
        if (profEncontrado != null)
        {
            int codEmp = profEncontrado.GetCodigo();
            string nombreEmp = profEncontrado.GetNombre();
            string espEmp = profEncontrado.GetEspecialidad();
            Console.Write($"Se encontro empleado con codigo: {codEmp} y nombre: {nombreEmp}\n");
            emp = new Director(codEmp, nombreEmp, espEmp);
            return emp;
        }
        else
        {
            Console.WriteLine($"No se encontro Empleado con codigo: {codP}" );
            Console.Write("Ingrese el nombre: ");
            string nNombre = Console.ReadLine();
            LimpiraIngreso();
            Console.WriteLine($"Empleado ingresado con codigo: {codP}, nombre: {nNombre}");
            Console.Write("Ingrese la especialidad: ");
            string nEspecialidad = Console.ReadLine();
            LimpiraIngreso();
            Console.WriteLine($"Empleado ingresado con codigo: {codP}, nombre: {nNombre} y especialidad: {nEspecialidad}\n");
            emp = new Director(codP, nNombre, nEspecialidad);
            return emp;
        }
    }

    private static Profesor AgregarProfesor(Carrera carrera){

        Console.Write("Ingrese el codigo del profesor: ");
        int codP = int.Parse(Console.ReadLine());
        LimpiraIngreso();
        Profesor profEncontrado = carrera.GetProfesores(codP);
        Profesor p;
        LimpiraIngreso();
        if (profEncontrado != null) {
            Console.Write($"Se encontro profesor con codigo: {profEncontrado.GetCodigo()}  y nombre: {profEncontrado.GetNombre()}\n");
            p = profEncontrado;
            return p;
        } else {
            Console.WriteLine($"No se encontro profesor con codigo: {codP}");
            Console.Write("Ingrese el nombre: ");
            string nNombreP = Console.ReadLine();
            LimpiraIngreso();
            Console.WriteLine("Profesor ingresado con codigo: {codP}, nombre: {nNombreP}");
            Console.Write("Ingrese la especialidad: ");
            string nEspecialidadP = Console.ReadLine();
            LimpiraIngreso();
            Console.WriteLine($"Profesor ingresado con codigo: {codP}, nombre: {nNombreP} y especialidad: {nEspecialidadP}");
            p = new Profesor(codP, nNombreP, nEspecialidadP);
            return p;
        }
    }

    private static void EditarDirector(Carrera carrera, Director director){

        do {
            Console.WriteLine("Director actual de la carrera: " + director.GetNombre() + "\n");
            MenuDirectorCarrera();
            int opcionPrincipal = LeerOpcion();

            switch (opcionPrincipal) {
                case 1:
                    Empleado emp = AgregarDirector(carrera);
                    // conversion de clase padre a clase hija
                    Director dir = (Director) emp;
                    carrera.SetDirector(dir);
                    director = dir;
                    break;
                case 2:
                    Console.WriteLine("\nRegresando a Menu principal...");
                    LimpiarConsola();
                    return;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }

        } while (true);

    }

    private static void EditarDatosDirector(Director director) {
        do {
            Console.WriteLine("Datos actuales del director:");
            Console.WriteLine($"\tNombre: {director.GetNombre()}");
            Console.WriteLine($"\tEspecialidad: {director.GetEspecialidad()}\n");
            MenuDatosDirectorCarrera();
            int opcionPrincipal = LeerOpcion();

            switch (opcionPrincipal) {
                case 1:
                    Console.Write("Ingrese nuevo nombre del director: ");
                    string nDirector = Console.ReadLine();
                    director.SetNombre(nDirector);
                    break;
                case 2:
                    Console.Write("Ingrese nueva especialidad del director: ");
                    string nEspecialidad = Console.ReadLine();
                    director.SetEspecialidad(nEspecialidad);
                    break;
                case 3:
                    Console.WriteLine("\nRegresando a Menu principal...");
                    LimpiarConsola();
                    return;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }

        } while (true);
    }

    private static void EditarSemestres(Carrera carrera){

        do {
            carrera.GetSemestres();
            MenuSemestres();
            int opcionPrincipal = LeerOpcion();

            switch (opcionPrincipal) {
                case 1:
                    Console.Write("Ingrese numero de semestre: ");
                    // int nSemestre = scanner.nextInt();
                    int nSemestre = int.Parse(Console.ReadLine());
                    List<Semestre> ListSemestres = carrera.GetSemestres();
                    Semestre semestre = ListSemestres[nSemestre - 1];
                    LimpiraIngreso();
                    editarCursos(semestre, carrera);
                    break;
                case 2:
                    Console.WriteLine("\nRegresando a Menu principal...\n");
                    return;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.\n");
                    break;
            }

        } while (true);

    }

    private static int NumeroCurso() {
        Console.Write("Ingrese numero de curso: ");
        int nCurso = int.Parse(Console.ReadLine());
        return nCurso;
    }

    private static int IngresarHora(string m) {
        int hora = 0;
        int op = 0;
        string formatoH = "La hora debe estar en 0 a 24, ingresela de nuevo\n";

        do {
            Console.Write("Ingrese hora de " + m + " de curso de 0 a 24 horas: ");
            hora = int.Parse(Console.ReadLine());
            LimpiraIngreso();
            if (hora > 0 && hora < 25) {
                op = 1;
            } else {
                Console.Write(formatoH);
            }

        } while (op != 1);
        op = 0;
        return hora;
    }

    private static int ValidarHoraF(int horaI){
        int nHoraF = 0;
        int op = 0;

        do {
            nHoraF = IngresarHora("Fin");

            if (nHoraF <= horaI) {
                Console.WriteLine("La hora de Fin tiene que ser mayor a la hora de Inicio vuelva a ingresarla");
            } else {
                op = 1;
            }
            // limpiarConsola();
        } while (op != 1);
        op = 0;
        return nHoraF;
    }



    public static int LeerOpcion()
    {
        while (true)
        {
            try
            {
                int op;
                Console.Write("Ingrese una opción: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                return op;
            }
            catch (System.Exception)
            {
                Console.Clear();
                Console.WriteLine("Entrada inválida. Porfavor ingrese un numero.");
            }
        }

    }

}

