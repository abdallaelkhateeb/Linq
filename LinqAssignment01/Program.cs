namespace LinqAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Q1
            //1. Find all products that are out of stock.
            //var result = ListGenerators.ProductList.Where(Product => Product.UnitsInStock == 0);
            //result.print();

            #endregion



            #region Q2
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ListGenerators.ProductList.Where(Product=>Product.UnitsInStock>0&&Product.UnitPrice>3.00M);
            //result.print();
            #endregion

            #region Q3
            //3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((x, i) => x.Length < i);
            //result.print();
            #endregion

            #endregion


            #region LINQ - Element Operators
            #region Q1
            //1. Get first Product out of Stock 


            #endregion



            #region Q2
            // 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            #endregion


            #region Q3
            //3. Retrieve the second number greater than 5 



            #endregion


            #endregion

        }
    }
}
