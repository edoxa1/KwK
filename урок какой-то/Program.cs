using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_какой_то
{ 
    public class Animal
    {
        public string type = "Млекопитающие";
        public string breed = "Михаил Петрович";
        public string colour = "grey";
        public int agression = 30;

        public Animal()
        {

        }

        public Animal(string type,string breed)
        {
            this.type = type;
            this.breed = breed;
        }
        public Animal(string type, string breed, string colour)
        {
            this.type = type;
            this.breed = breed;
            this.colour = colour;
        }
        public Animal(string type, string breed, string colour,int agression)
        {
            this.type = type;
            this.breed = breed;
            this.colour = colour;
            this.agression = agression;
        }

        public void MyInfo()
        {
            Console.WriteLine($"Type: {type}, Breed: {breed}, Colour: {colour}, Agression level: {agression}");
        }
    }

    public class Tiles
    {
        public string brand = "";
        public int size_h = 0;
        public int size_w = 0;
        public int price = 0;


        public void getData(string brand, int size_h, int size_w, int price)
        {
            this.brand = brand;
            this.size_h = size_h;
            this.size_w = size_w;
            this.price = price;

            Console.WriteLine($"Brand name: {brand}\nHeight: {size_h} cm\nWidth: {size_w} cm\nPrice: {price} euro");
        }
    }

    public class Children
    {
        public string name = "";
        public string surname = "";
        public int age = 0;
        
        public void getInfo()
        {
            Console.WriteLine("Enter children name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter children surname: ");
            this.surname = Console.ReadLine();
            Console.WriteLine("Enter children age: ");
            this.age = Convert.ToInt32(Console.ReadLine());
        }

        public void MyInfo()
        {
            Console.WriteLine($"Children name: {name}\nChildren surname: {surname}\nChildren age: {age}");
        }
    }

    public class House
    {
        public string numberOfHouse = "";
        public string floors = "";
        public string apartsInFloors = "";
        public string roomsInAparts = "";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.MyInfo();
            //
            Animal dog = new Animal();
            dog.MyInfo();
            //
            Animal horse = new Animal("Black", "Mustang","Brown");
            horse.MyInfo();
            //
            Animal mouse = new Animal("Шрек","Болотный","Зеленый", 834598734);
            mouse.MyInfo();
            mouse.type = "Собака";
            Console.ReadKey();
            //_____________________________________________________//
            Console.Clear();
            Tiles tile1 = new Tiles();
            tile1.getData("AAAAA",25,25,10);
            Console.ReadKey();
            //_____________________________________________________//
            Console.Clear();
            Children child1 = new Children();
            child1.getInfo();
            child1.MyInfo();
            Console.ReadKey();
        }
        
    }
}
