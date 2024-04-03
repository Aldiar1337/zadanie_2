namespace ConsoleApp5;

class Program
{
    static void Main()
    {
        Student student = Student.ReadStudent();
        student.PrintInfo();
        Console.Write("Введите новую фамилию: ");
        student.surname = Console.ReadLine();
        Console.Write("Введите новую дату рождения (в формате дд.мм.гггг): ");
        student.birthdate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        Console.Write("Введите новый номер группы: ");
        student.group = Console.ReadLine();
        student.PrintInfo();

    }

    
}






