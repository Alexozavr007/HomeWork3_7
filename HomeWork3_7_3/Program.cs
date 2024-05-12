using HomeWork3_7_3;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
static void ClassTaker(MyClass myClass) {
    myClass.change = "змінено";
}
static void StructTaker(MyStruct myStruct) {
    myStruct.change = "змінено";
}

var a = new MyClass();
var b = new MyStruct();

a.change = "не змінено";
b.change = "не змінено";

ClassTaker(a);
StructTaker(b);
Console.WriteLine($"значення в класі {a.change}");
Console.WriteLine($"значення в структурі {b.change}");

/*
 * Метод StructTaker приймає на вхід структуру, а тому при його виклику передається не оригінальний екземпляр, а його клон 
 * Тому екземпляр b залишається не зміненим після виклику StructTaker
 */