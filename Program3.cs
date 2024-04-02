namespace ConsoleApp5;

class NamesSurname
{
    public String name;
    public String surname;
    public NamesSurname()
    {
        this.name = "";
        this.surname = "";
    }
    public NamesSurname (String name1, String name2)
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