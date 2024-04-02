namespace ConsoleApp5;

class Program2
{
    
    public class Train
    {
        public string Destination;
        public int Number;
        public string DepartureTime;

        public void DisplayTrainInfo()
        {
            Console.WriteLine($"Поезд с номером {Number} следует в {Destination} и отправляется в {DepartureTime}");
        }
    }

    static void Main()
    {
        // Создаем массив объектов Train
        Train[] trains = new Train[]
        {
            new Train { Number = 101, Destination = "Москва", DepartureTime = "10:00" },
            new Train { Number = 102, Destination = "Томск", DepartureTime = "14:00" },
            new Train { Number = 103, Destination = "Новосибирск", DepartureTime = "18:00" },
            new Train { Number = 104, Destination = "Харьков", DepartureTime = "22:00" }
        };
        Console.Write("Введите номер поезда для вывода информации о нем: ");
        int trainNumber = int.Parse(Console.ReadLine());
        bool trainFound = false;
        foreach (Train train in trains)
        {
            if (train.Number == trainNumber)
            {
                train.DisplayTrainInfo();
                trainFound = true;
                break;
            }
        }

        if (!trainFound)
        {
            Console.WriteLine($" Поезд с таким номером {trainNumber} не был найден");
        }

    }

}