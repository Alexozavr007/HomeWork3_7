namespace HomeWork3_7_2; 
public struct Train {
    public string Destination;
    public int TrainNumber;
    public string DepartureTime;

    public void ToConsol() {
        Console.WriteLine($"Номер: {TrainNumber}");
        Console.WriteLine($"Назва пункту: {Destination}");
        Console.WriteLine($"Час відправки: {DepartureTime}");
    }
}
