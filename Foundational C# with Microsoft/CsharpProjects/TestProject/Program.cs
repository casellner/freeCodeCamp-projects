string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);

for (int i = 0; i < orderArray.Length; i++)
{
    Console.Write(orderArray[i] + "\t");
    if (orderArray[i].Length != 4)
    {
        Console.Write("- Error");
    }
    Console.WriteLine("");
}
