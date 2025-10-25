Console.Write("数値を入力してください->");
int value = int.Parse(Console.ReadLine());
if (value % 4 == 0)
{
    Console.WriteLine("4の倍数です。");
}
else
{
    Console.WriteLine("4の倍数ではありません。");
}

