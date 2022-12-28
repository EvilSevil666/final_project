Console.Clear();
Console.WriteLine("Программа которая из введённого массива строк формирует массив из строк, длина которых меньше либо равна 3 символа."); 

string[] array = NArray();
string[] result = FindLess(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLess(string[] input, int n) {
    string[] output = new string[CLess(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CLess(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] NArray() {
    Console.Write("Введите данные через пробел: ");
    return Console.ReadLine().Split(" ");
}