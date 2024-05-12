namespace HomeWork3_7_5; 
public struct Notebook {
    string model;
    string producer;
    int price;
    
    public Notebook(string model, string producer, int price) {
        this.model = model;
        this.producer = producer;
        this.price = price;
    }
    public void ToConsole() {
        Console.WriteLine($"модель: {model}");
        Console.WriteLine($"продукт: {producer}");
        Console.WriteLine($"ціна: {price}");
    }
}
