//Arya Taheri
int firstNum = 0, secodnNum = 1, result = 0, n;
Console.WriteLine("n?");
try
{
    n = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Bad Input Try Again");
    return;
}
for (int i = 0; i <= n; i++)
{
    result = firstNum + secodnNum;
    firstNum = secodnNum;
    secodnNum = result;
}
Console.WriteLine(result);
Console.ReadKey();
