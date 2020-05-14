
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars carsNoName = new Cars();
            Cars carsVolvo = new Cars("Volvo S60");
            Cars carsLamborgini = new Cars("Avendator s", "Lamborgini", "S");
            Cars carsBugatti = new Cars("Chiron", "Bugatti", "S");

            carsNoName.WriteCars();
            carsVolvo.WriteCars();
            carsLamborgini.WriteCars();
            carsBugatti.WriteCars();

            Console.Read();
        }
    }
}
class Cars
{
    private string name;//название авто  
    private string brand; // год авто
    private string clas; // цвет авто
    public string Name { get { return name; } set { name = value; } }  // название авто 
    public string Brand { get { return brand; } set { brand = value; } } // год авто
    public string Clas { get { return clas; } set { clas = value; } } // цвет авто


    public Cars()
    {
        Name = "NoName";
        Brand = "NoBrand";
        Clas = "NoClas";

    }

    public Cars(string name) : this()
    {
        Name = name;
    }
    public Cars(string name, string brand) : this(name)
    {
        Clas = clas;


    }
    public Cars(string name, string brand, string clas)
    {
        Name = name;
        Brand = brand;
        Clas = clas;
    }
    public void WriteCars() // метод  -вывоит информацию о  студенте 
    {
        Console.WriteLine("Название авто: {0}\nМарка: {1}\nКласс: {2}\n", Name, Brand, Clas);
    }

}