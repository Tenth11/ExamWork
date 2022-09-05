Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите строки");
string[] array = new string[n];
for(int i = 0; i < n; i++){
array[i] = Console.ReadLine();
}
Console.WriteLine();
for(int i = 0; i < n; i++){
    if(array [i].Length <= 3)
Console.Write("[{0}]", string.Join(", ", array[i]));
}
