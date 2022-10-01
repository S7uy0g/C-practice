using System;
public class MyFirstCode
{
    static int a,b,temp;
    public static void Main()
    {
        a=Input();
        b=Input();
        System.Console.WriteLine("Ans="+Add(a,b));
        System.Console.WriteLine("Press any key to continue!!!");
        System.Console.ReadKey();
        System.Console.WriteLine("Ans="+Mul(a,b));
        System.Console.WriteLine("Press any key to continue!!!");
        System.Console.ReadKey();
        System.Console.WriteLine("Ans:");
        System.Console.WriteLine("Remainder="+Div(a,b));
        System.Console.WriteLine("Press any key to continue!!!");
        System.Console.ReadKey();
        swap(a,b);
    }
    public static int Add(int x,int y)
    {
        int ans=x+y;
        return ans;
    }
    public static int Mul(int x,int y)
    {
        int ans=x*y;
        return ans;
    }
    public static int Div(int x,int y)
    {
        int quo=x/y;
        int rem=x%y;
        System.Console.WriteLine("Quotient="+quo);
        return rem;
    }
    public static int Input()
    {
        System.Console.WriteLine("Input=");
        int inp1=Convert.ToInt32(Console.ReadLine());
        return inp1;
    }
    public static void swap(int x,int y)
    {
        System.Console.WriteLine("Before swap:");
        System.Console.WriteLine("A="+x+"B="+y);
        temp=x;
        x=y;
        y=temp;
        System.Console.WriteLine("After swap:");
        System.Console.WriteLine("A="+x+"B="+y);
    }
}