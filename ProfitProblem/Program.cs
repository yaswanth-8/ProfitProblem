namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        int[] priceArray = { 7, 1, 2, 5, 6, 4 };
        int length=priceArray.Length;
        int maxProfit = 0;
        for (int i = 0;i<length;i++)
        {
           for(int j=i;j<length;j++) {
                if (priceArray[j] - priceArray[i] > maxProfit)
                {
                    maxProfit = priceArray[j] - priceArray[i];
                }
           }
        }
        Console.WriteLine(maxProfit);
    }
}