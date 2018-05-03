using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace homework7.Task_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var someAuthor1 = new Author("James", "Copeland");
//            var someAuthor2 = new Author("Dan", "Brown");

//            var someBook1 = new Book("Bubblegum Thief", "aaaaa", someAuthor1);
//            var someBook2 = new Book("Origin", "bbbb", someAuthor2);

//            var someLibrary = new Library();

//            someLibrary.AddBooksToCollection(someBook1);
//            someLibrary.AddBooksToCollection(someBook2);

//            someLibrary.ReviewBookCollection();
//        }
//    }
//}

//namespace homework7.Task_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var someDisplay1 = new BuiltInDisplay();
//            var someDisplay2 = new ExternalDisplay();
//            var someDisplay3 = new Projector();

//            var someInput1 = new Joystick();
//            var someInput2 = new Keyboard();
//            var someInput3 = new Mouse();

//            var someProcessor1 = new Amd64Processor();
//            var someProcessor2 = new ArmProcessor();

//            var someComputer1 = new Computer(someProcessor1, someDisplay1, someInput1);
//            var someComputer2 = new Computer(someProcessor2, someDisplay2, someInput2);
//            var someComputer3 = new Computer(someProcessor1, someDisplay3, someInput3);

//            someComputer1.Work();
//            someComputer2.Work();
//            someComputer3.Work();
//        }
//    }
//}

namespace homework7.Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ElectricCooktop = new Cooktop();
            var GasCooktop = new Cooktop();
            var ElectricOven = new Oven();
            var GasOven = new Oven();

            var ElectricStove = new Stove(ElectricCooktop,ElectricOven);
            var GasStove = new Stove(GasCooktop,GasOven);

            ElectricCooktop.Cook();
            GasOven.Bake();

            GasStove.Bake();
            GasStove.Cook();
        }
    }
}
