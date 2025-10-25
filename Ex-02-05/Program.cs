Console.Write("数値を入力してください->");
int value = int.Parse(Console.ReadLine());
if (value % 2 == 0)
{
    value = value * 10;
} 
Console.WriteLine("結果:"+value);
