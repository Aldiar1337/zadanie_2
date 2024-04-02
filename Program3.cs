namespace ConsoleApp5;

public class Program3
{
    static void Main()
    {
        NamesSurname people = new NamesSurname();
        while (true)
        {
            Console.WriteLine("Введите число 0, чтобы завершить работу программы.");
            Console.WriteLine("Введите число 1, чтобы ввести имя и фамилию");
            Console.WriteLine("Введите число 2, чтобы показать данные");
            Console.Write("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Вы завершили программу");
                    return;
                case 1:
                    Console.Write("Введите Имя: ");
                    String name1 = Console.ReadLine();
                    Console.Write("Введите Фамилию: ");
                    String name2 = Console.ReadLine();
                    people = new NamesSurname(name1, name2);
                    break;
                case 2:
                    Console.WriteLine(people.name);
                    Console.Write(people.surname);
                    break;
            }
        }
    }

    class NamesSurname
    {
        public String name;
        public String surname;

        public NamesSurname()
        {
            this.name = "";
            this.surname = "";
        }

        public NamesSurname(String name1, String name2)
        {
            this.name = name1;
            this.surname = name2;
        }

        ~NamesSurname()
        {
            Console.Write($"{this.name} was deleted");
            Console.Write($"{this.surname} was deleted");
        }
    }

}