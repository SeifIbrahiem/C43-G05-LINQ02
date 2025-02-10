
using System.Collections;
using static C43_G05_LINQ02.ListGenerator;
namespace C43_G05_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);
            #region Filteration operator
            //All product out stock //with fluentsyntax
            //var result=ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}
            //All product out stock //with querysyntax
            //var result =from p in ProductList
            //           where p.UnitsInStock == 0
            //           select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //-----------------------------------------------------------//
            //var result=ProductList.Where(p => p.Category== "Meat/Poultry");
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            //var result =from p in ProductList
            //           where p.Category == "Meat/Poultry"
            //            select p;
            //foreach (var item in result)
            //{ Console.WriteLine(item); }

            //-------------------------------------------------------------//
            //var result=ProductList.Where(p => p.Category== "Meat/Poultry" && p.UnitsInStock==0);

            //var result =from p in ProductList
            //           where p.Category == "Meat/Poultry" && p.UnitsInStock == 0
            //           select p;

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            //var result= ProductList.Where((p, Index) => Index < 5);
            // var result1 = ProductList.Where((p, Index) => Index < 5 && p.UnitsInStock==0);
            // var result2 = ProductList.Where((p, Index) => Index < 10 && p.UnitsInStock == 0);
            //var result2 = ProductList.Where(p => p.UnitsInStock > 0).Where((p, i) => i < 5);
            // foreach (var item in result ) 
            // {
            //     Console.WriteLine(item);
            // }
            // foreach (var item in result1)
            // {
            //     Console.WriteLine(item);
            // }
            // foreach (var item in result2)
            // {
            //     Console.WriteLine(item);
            // }
            //********************************************//
            //of type 
            //ArrayList arrayList = new ArrayList() { 1 , 2, 3 , 1.5,2.5, "ali", "seif","omar"};
            //var result = arrayList.OfType<int>();
            //foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }



                #endregion
        }
    }
}
