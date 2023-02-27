string[] SelectThreeOrLessChar(string[] text)
{
    string[] result = new string[0];
    foreach (string word in text)
    {
        if (word.Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = word;
        }
    }
    return result;
}

string[] text_1 = { "hello", "2", "world", ":-)" };
string[] text_2 = { "1234", "1567", "-2", "computer science" };
string[] text_3 = { "Russia", "Denmark", "Kazan" };
Console.Clear();
Console.WriteLine(string.Join(" ", SelectThreeOrLessChar(text_1)));
Console.WriteLine(string.Join(" ", SelectThreeOrLessChar(text_2)));
Console.WriteLine(string.Join(" ", SelectThreeOrLessChar(text_3)));