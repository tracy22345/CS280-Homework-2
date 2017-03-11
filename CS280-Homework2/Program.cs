using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "";
            float National = 0.0f;
            string Abilities = "";
            float Weight = 0.0f;
            string Category = "";
            string Gender = "";

            Console.WriteLine("請輸入一隻Pokemon:");
            Console.Write("Name:");
            try
            {
                name = (Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("NationalNo:");
            try
            {
                National = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Weight:");
            try
            {
                Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Abilities:");
            try
            {
                Abilities = (Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Category:");
            try
            {
                Category = (Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Gender:");
            try
            {
                Gender = (Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.WriteLine("名字:{0}, 編號{1}, 體重{2}, 能力{3}, 類別{4}, 性別{5}",
                name, National, Weight, Abilities, Category, Gender);
        }
    }
}