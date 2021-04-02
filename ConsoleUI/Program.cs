using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        // Open Closed Principle 
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var Result =  productManager.GetProductDetails();

            if (Result.Success)
            {
                foreach(var product in Result.Data)
            {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(Result.Message);// şu anlık burası null dönüyor çünkü içeride yanlış yapılan bişey yok.
            }
        }
    }
}
