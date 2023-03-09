Console.WriteLine("Введите кол-во слов которые хотите ввести: ");
int count = int.Parse(Console.ReadLine());
string[] array = GetArrayLess3(count);

string[] GetArrayLess3(int size){
    string[] result = new string[size];
    int index = 0;
    for (int i = 0; i < size; i++){
        Console.WriteLine($"Введите {i+1} слово: ");
        string word = Console.ReadLine();
        if (word.Length<=3){
            result[index++] = word;
        }        
        else {
            Console.WriteLine($"Длина {i+1} слова больше 3-х: ");
        }
    }
    Array.Resize(ref result, index); // remove unused array elements
    return result;
}

Console.WriteLine($"[{String.Join(", ", array)}]");