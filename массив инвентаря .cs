using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Практическое применение массивов на примере концепта инвентаря:
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qua= 10;    // условное колличество ячеек инвентаря
            string[] inventarray = new string[qua];
            string[] itemarray= new string [20];  // массив с перечнем всех предметов игры
            itemarray[0] = "карта";
            Console.WriteLine("обычная карта, которая есть у любого туриста");
            Console.WriteLine("взять её?");
            string act= Console.ReadLine();
                if (act=="да")
                   { 
                    inventarray[0] = itemarray[0]; // добавление подобранного предмета в инвентарь
                    Console.WriteLine("найден предмет: "+ itemarray[0]);  // сообщение о полученном предмете
                    
                    }
                else
               { Console.WriteLine("Тут что то не так, вы предпочли пройти мимо");}
               
             
             
          
            
        }
    }
}
