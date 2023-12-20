try
{
    Console.WriteLine("Введите кол-во минут");
    int min = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите кол-во секунд");
    int sek = int.Parse(Console.ReadLine()!);

    Time time = new Time(min, sek);
    time.Print();


}
catch (Exception ex) { Console.WriteLine(ex.Message); }
class Time
{
    private int min;
    private int sek;
    public int Min
    {
        get { return min; }
        set { min = value; }
    }
    public int Sek
    {
        get { return sek; }
        set { sek = value; }
    }
    public Time(int min, int sek)
    {
        this.min = min;
        this.sek = sek;

    }
    public int Ain(int min, int sek)
    {

        return (min / 60) + sek;

    }

    public void Print()
    {
        Console.WriteLine($"Общее кол-во секунд: {Ain(min, sek)},Кол - во минут: {min},Кол-во сукунд: {sek}");
    }
}



