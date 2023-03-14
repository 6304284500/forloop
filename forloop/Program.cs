public  class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of table that you want to print");
         int n = Convert.ToInt32(Console.ReadLine ());
        Console.WriteLine("Enter the Muliple times of the Table you want to print ");
         int k= Convert.ToInt32(Console.ReadLine());
        int i;
        for (i=1;i<=k;i++)
        {
            Console.WriteLine(" {0} X {1} = {2}", n,i,i*n);
        }
        
    }
}