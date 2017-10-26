/*Описать структуру Article, содержащую следующие
поля: код товара; название товара; цену товара.*/
using System;

namespace HomeCaseCS_Lesson3_1
{
    struct Article
    {
        private int productCode;
        private string productName;
        private double productPrice;

        public Article(int pCode,string pName,double pPrice)
        {
            productCode = pCode;
            productName = pName;
            productPrice = pPrice;
        }
        public void PrintArticle()
        {
            Console.WriteLine($"Code: {productCode}");
            Console.WriteLine($"Name: {productName}");
            Console.WriteLine($"Price: {productPrice}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Article notebook = new Article(777, "Notebook Asus 751LB", 18000);
            notebook.PrintArticle();

            Console.ReadKey();
        }
    }
}
