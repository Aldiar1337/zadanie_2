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
            Console.WriteLine($"Поезд с номером {Number} следует в {Destination} и отправляетсяя в {DepartureTime}");
        }
    }
}