int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>0) return op;
    else {
        Console.WriteLine("Введите число > 0!");
        return AskUser();
    };
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

string AskUser2()
{
Console.Write("Введите элемент: ");
string? Ask = Console.ReadLine();
if (Ask != null){
    return Ask;
}
else{
    Console.WriteLine("Введите верный элемент!");
    return AskUser2();
}
}

string [] FillArray(string[] arrayToFill){
    for (int i = 0; i<arrayToFill.Length; i++){
        arrayToFill[i] = AskUser2();
    }
    return arrayToFill;
}

void PrintArray(string[] arrayToPrint){
    for (int i = 0; i<arrayToPrint.Length; i++){
        Console.Write(arrayToPrint[i]+ " ");
    }
}

string [] GetElementsLengthUpTo3(string[] array){
    string [] new_array = new string [array.Length];
    for (int i = 0; i<array.Length; i++){
        if (array[i].Length<=3){
            new_array[i] = array[i];
        }
    }
    return new_array;
}

string [] array = new string [AskUser()];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(GetElementsLengthUpTo3(array));