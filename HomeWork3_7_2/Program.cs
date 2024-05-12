using HomeWork3_7_2;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Train[] trains = new Train[3];
bool numberIsWalid;

for  (int i = 0; i < trains.Length; i++) {
    Console.WriteLine($"Введіть інформацію для поїзду № {i + 1}");
    
    do {
        Console.Write("Номер поїзду: ");
        var strNumber = Console.ReadLine();
        int trainNo;
        numberIsWalid = Int32.TryParse(strNumber, out trainNo);
        if (numberIsWalid) {
            trains[i].TrainNumber = trainNo;
        }
    } while (!numberIsWalid);

    Console.Write("Час відправлення: ");
    trains[i].DepartureTime = Console.ReadLine();

    Console.Write("Назва пункту призначення: ");
    trains[i].Destination = Console.ReadLine();

    Console.WriteLine();
}
trains.Sort();


int trainNoToSearch;
do {
    Console.WriteLine("Введіть номер потягу для пошуку: ");
    var strNumber = Console.ReadLine();
    numberIsWalid = Int32.TryParse(strNumber, out trainNoToSearch);
} while (!numberIsWalid);

bool trainFound = false;

for (int i = 0; i < trains.Length; i++) {

    if (trains[i].TrainNumber == trainNoToSearch) {
        trains[i].ToConsol();
        trainFound = true;
    }else if (trains[i].TrainNumber > trainNoToSearch) {
        break; 
    }
}
if (trainFound == false) {
    Console.WriteLine("Потяг не знайдено");
}