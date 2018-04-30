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
//            Author someAuthor1 = new Author("James", "Copeland");
//            Author someAuthor2 = new Author("Dan", "Brown");

//            Book someBook1 = new Book("Bubblegum Thief", "aaaaa", someAuthor1);
//            Book someBook2 = new Book("Origin", "bbbb", someAuthor2);

//            Library someLibrary = new Library();

//            someLibrary.AddBooksToCollection(someBook1);
//            someLibrary.AddBooksToCollection(someBook2);

//            someLibrary.ReviewBookCollection();
//        }
//    }
//}

namespace homework7.Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BuiltInDisplay someDisplay1 = new BuiltInDisplay();
            ExternalDisplay someDisplay2 = new ExternalDisplay();
            Projector someDisplay3 = new Projector();

            Joystick someInput1 = new Joystick();
            Keyboard someInput2 = new Keyboard();
            Mouse someInput3 = new Mouse();

            Amd64Processor someProcessor1 = new Amd64Processor();
            ArmProcessor someProcessor2 = new ArmProcessor();

            Computer someComputer1 = new Computer(someProcessor1, someDisplay1, someInput1);
            Computer someComputer2 = new Computer(someProcessor2, someDisplay2, someInput2);
            Computer someComputer3 = new Computer(someProcessor1, someDisplay3, someInput3);

            someComputer1.Work();
            someComputer2.Work();
            someComputer3.Work();
        }
    }
}
