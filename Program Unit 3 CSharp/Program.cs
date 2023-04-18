
Student JIMENA = new Student("Jimena", 352215, 20, "Computer Engineering", true);
JIMENA.escribirApuntes();
Console.WriteLine();

Student LUCÍA = new Student("Lucia", 546235, 18, "Law", true);
LUCÍA.hacerTarea();
Console.WriteLine();

Student MARCOS = new Student("Marcos", 621244, 24, "International Business", false);
MARCOS.exponer();


public class Student
{
    protected string name;
    protected long id;
    protected int age;
    protected string career;
    protected bool insurance;


    public Student(string name, long id, int age, string career, bool insurance)
    {
        this.name = name;
        this.id = id;
        this.age = age;
        this.career = career;
        this.insurance = insurance;
    }
    public Student()
    {

    }
    public void exponer()
    {
        Console.WriteLine("El estudiante va a exponer");
    }
    public void hacerTarea()
    {
        Console.WriteLine("El alumno debe hacer tarea");
    }
    public void escribirApuntes()
    {
        Console.WriteLine("El alumno toma apuntes");
    }
    ~Student()
    {
        System.Diagnostics.Trace.WriteLine("Se borraron los datos del alumno");
    }

}



