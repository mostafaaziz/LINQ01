using static LINQ01.ListGenerator;
namespace LINQ01
{
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, true);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

            #region Q1

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            #endregion

            #region Q2

            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);


            #endregion

            #region Q3

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((n, i) => n.Length < i); 

            #endregion
            
            #region Q1

            //var Result = ProductList.OrderBy(P => P.ProductName);

            #endregion

            #region Q2

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy((s) => s, new CustomComparer());

            #endregion

            #region Q3

            //var Result = ProductList.OrderByDescending((P) => P.UnitsInStock);

            #endregion

            #region Q4

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.OrderBy(n => n.Length).ThenBy(n => n);


            #endregion

            #region Q5

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = words.OrderBy(s => s.Length).ThenBy(s => s, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region Q6

            //var Result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            #endregion

            #region Q7

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x, new CustomComparer());

            #endregion

            #region Q8

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(x => x[1] == 'i').Reverse();

            #endregion 
          

            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
        }
    }
}
