string directory = @"C:\Users\kilia\source\repos\Day2.1\Day2.1\Input.txt";
List<string> stringList = new List<string>();
StreamReader sr = new StreamReader(directory);
int hPos = 0, depth = 0;
string[] input;
int result = 0;


try
{
    do
    {
        stringList.Add(sr.ReadLine());
    }
    while (sr.Peek() != -1);
}
catch
{
    stringList.Add("File is empty");
}
finally
{
    sr.Close();
}

foreach(string s in stringList)
{
    input = s.Split(" ");
    if(input[0] == "forward")
    {
        hPos = hPos + Int32.Parse(input[1]);
    }
    else if(input[0] == "down")
    {
        depth = depth + Int32.Parse(input[1]);
    }
    else if(input[0] == "up")
    {
        depth = depth - Int32.Parse(input[1]);
    }
    else
    {
        Console.WriteLine("Can't read input");
    }
}

result = depth * hPos;
Console.WriteLine(result);
Console.Read();