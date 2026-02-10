namespace DSC
{
    #region pro1
    //class Math
    //{
    //    public static int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //    public static int Subtract(int x, int y)
    //    {
    //        return x - y;
    //    }
    //    public static int Multiply(int x, int y)
    //    {
    //        return x * y;
    //    }
    //    public static double Divide(double x, double y)
    //    {
    //        return x / y;
    //    }
    //}
    #endregion
    #region pro2
    //public abstract class Discount
    //{
    //    public string Name { get; set; }
    //    public abstract decimal CalculateDiscount(decimal price, int quantity);
    //}
    //class PercentageDiscount : Discount
    //{
    //    public decimal percentage;
    //    public PercentageDiscount(decimal percentage)
    //    {
    //        this.percentage = percentage;
    //        Name = "Percentage Discount";
    //    }
    //    public override decimal CalculateDiscount(decimal price, int quantity)
    //    {
    //        return price * quantity * (percentage / 100);
    //    }
    //}
    //class FlatDiscount : Discount
    //{
    //    public decimal flatAmount;
    //    public FlatDiscount(decimal flatAmount)
    //    {
    //        this.flatAmount = flatAmount;
    //        Name = "Flat Discount";
    //    }
    //    public override decimal CalculateDiscount(decimal price, int quantity)
    //    {
    //        return flatAmount * Math.Min(quantity, 1);
    //    }
    //}
    //class BuyOneGetOneDiscount : Discount
    //{
    //    public BuyOneGetOneDiscount()
    //    {
    //        Name = "Buy One Get One";
    //    }

    //    public override decimal CalculateDiscount(decimal price, int quantity)
    //    {
    //        if (quantity > 1)
    //        {
    //            return (price / 2) * (quantity / 2);
    //        }
    //        return 0;
    //    }
    //}

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region pro1
            //Console.WriteLine("Add = " + Math.Add(5,3));
            //Console.WriteLine("Subtract = " + Math.Subtract(5,3));
            //Console.WriteLine("Multiply = " + Math.Multiply(5,3));
            //Console.WriteLine("Divide = " + Math.Divide(5,3));
            #endregion
            #region pro2
            //Discount dis1= new PercentageDiscount(10); ;
            //Console.WriteLine(dis1.Name + ": " + dis1.CalculateDiscount(100m, 3));

            //Discount dis2 = new FlatDiscount(50);
            //Console.WriteLine(dis2.Name + ": " + dis2.CalculateDiscount(100m, 3));

            //Discount dis3 = new BuyOneGetOneDiscount();
            //Console.WriteLine(dis3.Name + ": " + dis3.CalculateDiscount(100m, 4));
            #endregion
        }
    }
}
