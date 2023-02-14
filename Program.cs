Console.WriteLine("Введите строки через запятую:");
char[] separators = new char[] {',', ' '};
string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

string[] NewArray(string[] words)
{
    int size = 0;
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length < 4)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[j] = words[i];
            j++;
        
        }
    }
    return newArray;
}

string[] newWords = NewArray(words);
Console.WriteLine($"Новый массив со строками меньше либо равными 3 символам - [{String.Join(", ", newWords)}]");
