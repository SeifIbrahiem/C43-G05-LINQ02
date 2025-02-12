
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

            #region Transformation operater
            //select //selectmany
            //        fleunt syntax   //
            //var result = ProductList.Select(p => p);
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result) { Console.WriteLine(item); }
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Seafood")
            //     .Select(p => new
            //     {
            //         p.ProductName,
            //         p.Category,
            //         oldprice=p.UnitPrice,
            //         newprice=p.UnitPrice-p.UnitPrice*0.1m
            //     });
            // foreach (var item in result) { Console.WriteLine(item); }
            //var result=  CustomerList.Select(c => c.CustomerName);
            //var result=CustomerList.Select(c => c.Orders);
            // var result=CustomerList.SelectMany(c => c.Orders);
            //foreach (var item in result) { Console.WriteLine(item); }
            //query syntax//
            //var result = from p in ProductList
            //            select p.ProductName;
            //foreach (var item in result) { Console.WriteLine(item); }
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Seafood"
            //             select new
            //             {
            //                 p.ProductName,
            //                 p.Category,
            //                 oldprice = p.UnitPrice,
            //                 newprice = p.UnitPrice - p.UnitPrice * 0.1m
            //             };
            //foreach (var item in result) { Console.WriteLine(item); }
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             select o;
            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion

            #region ordering operator

            //var result = ProductList.OrderBy(p => p.UnitPrice);
            //var result = ProductList.OrderBy(p => p.UnitPrice).Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitPrice,
            //    p.UnitsInStock,
            //});
            //foreach (  var item in result) { Console.WriteLine(item); }

            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitPrice,
            //    p.UnitsInStock,
            //});
            //foreach (var item in result) { Console.WriteLine(item); }
            //then by 
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductID);
            //foreach (var item in result) { Console.WriteLine(item); }



            #endregion

            #region elements operator 

            //elements operator <<>>immediate execution

            //var result =  ProductList.First();
            // var result1 = ProductList.Last();
            // Console.WriteLine(result);
            // Console.WriteLine(result1);
            //ProductList=new List<Product>();
            // var result =  ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName="defaultproduct"});
            //var result = ProductList.FirstOrDefault(p=>p.UnitsInStock==0);
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0,new Product() { ProductName = "defaultproduct" });
            // Console.WriteLine(result);

            // var result =  ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName="defaultproduct"});
            //var result = ProductList.LastOrDefault(p=>p.UnitsInStock==0);
            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 0,new Product() { ProductName = "defaultproduct" });
            // Console.WriteLine(result);

            //var result = ProductList.ElementAt(0);
            // var result = ProductList.ElementAtOrDefault(0);
            // Console.WriteLine(result);

            //var result =  ProductList.Single();
            //Console.WriteLine(result);
            //ProductList=new List<Product>() { new Product() {ProductName="onlyoneproduct" } };
            //var result = ProductList.Single();
            //Console.WriteLine(result);
            //var result = ProductList.Single(p=>p.UnitsInStock == 1);
            //Console.WriteLine(result);

            #endregion

            #region aggregate operator - imidiate execution
            //count sum max min avg 
            //count 
            //var result = ProductList.Count;
            // var result = ProductList.Count();
            //var result = ProductList.Count(p=>p.UnitsInStock == 0);
            //var result = ProductList.Where (p => p.UnitsInStock == 0).Count();
            // Console.WriteLine(result);

            //sum 
            //var result = ProductList.Sum(p => p.UnitsInStock);
            // var result = ProductList.Sum(p => p.UnitPrice);
            // Console.WriteLine(result);

            //average 
            //var result = ProductList.Average(p => p.UnitsInStock);
            //Console.WriteLine(result);

            //MAX ** MIN 

            //var result = ProductList.Max();
            //var result1= ProductList.Min();
            //Console.WriteLine(result);
            //Console.WriteLine(result1);

            //Aggregate
            //List<string> Names = new List<string>() { "seif", "ibrahiem", "mohmed", "elslimany" };
            //var result = Names.Aggregate((so1, so2) => $"{so1}{so2}");
            //Console.WriteLine(result);




            #endregion

            #region castingoperator
            // List<Product>list = ProductList.Where(p=>p.UnitsInStock==0).ToList();
            //Product[] list = ProductList.Where(p => p.UnitsInStock == 0).ToArray();
            //HashSet<Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();
            //  Dictionary<long,Product>list = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            // foreach (Product item in list) { Console.WriteLine(item); }
            #endregion

            #region generic operation
            //the only way to call this method as > class member method through "enumerable"class
            //range //empty //repeat
            //var result =  Enumerable.Range(1, 100);
            //var result = Enumerable.Repeat(ProductList[0], 3);
            //var result = Enumerable.Empty<Product>().ToList();
            //result.Add(new Product() { ProductName = "product1" });
            //foreach (var item in result) { Console.WriteLine(item); }


            #endregion

            #region setoperator _ union family
            //union //unionall //interset // expect 
            //var seqo1 = Enumerable.Range(1, 100);
            //var seqo2 = Enumerable.Range(50, 100);
            //var result = seqo1.Union(seqo2);
            //var result2 = seqo1.Intersect(seqo2);
            //var result3= seqo1.Except(seqo2);
            //foreach (var item in result) { Console.WriteLine(item); }
            //foreach (var item in result2) { Console.WriteLine(item); }
            //foreach (var item in result3) { Console.WriteLine(result3); }
            #endregion

        }
    }
}
