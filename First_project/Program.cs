Console.WriteLine("ТЕКСТ: ");
string t =  Console.ReadLine();
Console.WriteLine("колво символов - " + t.Length);
Console.WriteLine("вверхний рег - " + t.ToUpper());
Console.WriteLine("нижний рег - " + t.ToLower());
Console.WriteLine("замена - " + t.Replace(" ", "_"));