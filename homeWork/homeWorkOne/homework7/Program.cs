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

//namespace homework7.Task_3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ElectricCooktop someDevice1 = new ElectricCooktop();
//            ElectricOven someDevice2 = new ElectricOven();
//            GasStove someDevice3 = new GasStove();

//            someDevice1.Cook();
//            someDevice2.Bake();

//            someDevice3.Cook();
//            someDevice3.Bake();
//        }
//    }
//}

//namespace homework7.Task_3_aggregation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            GasCook someCook1 = new GasCook();
//            GasOvenNew someOven1 = new GasOvenNew();
//            ElectricOvenNew someOven2 = new ElectricOvenNew();

//            StoveNew someStove1 = new StoveNew(someCook1, someOven1);
//            StoveNew someStove2 = new StoveNew(someCook1, someOven2);

//            someStove1.Bake();
//            someStove1.Cook();

//            someStove2.Bake();
//            someStove2.Cook();
//        }
//    }
//}
