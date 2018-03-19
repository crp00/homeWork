//1. Изучите, скомпилируйте и запустите и объясните работу примера в контексте темы
//типовзначений(value-types) и типов-ссылок(reference types).  


using System;


class types
{
    static public void Main(string[] args)
    {
        int i = 100;
        string s = "Hello, world";

        Console.WriteLine("Before, i = " + i);
        ChangeInt(i);
        Console.WriteLine("After, i = " + i);

        Console.WriteLine("Before, s = " + s);
        ChangeString(s);
        Console.WriteLine("After, s = " + s);
    }
    static void ChangeInt(int i)
    {
        i = 99;
        //Console.WriteLine(i);
    }
    static void ChangeString(string s)
    {
        s = "Hello, I've been changed.";
    }
}


// Чему равно значение переменой i до вызова функции ChangeInt? После вызова? Почему?   
// значение равно 100 оба раза так как переменная i обявленная в main методе вне доступности 
// метода ChangeInt который просто создает новую переменную i = 99 

// Чему равно значение переменной s до вызова функции ChangeString? После вызова? Почему?
// та же причина, переменная s из main метода не доступна методу ChangeString

//////////////////////////////////////

//Какие типы являются типами-значениями(value types)?
// int, float, double, bool, user created sctructs

//Какие типы являются типами-ссылками(reference-types)?
//string, object, class

//Какие различия между типами-значениями и типами-сылками?
//типы-значения содержат присвоенные данные в то время как типы-сылки ссылаються на данные обекта

//В чем проявляется эта разница в примере первом пример?
//???

//Где размещаются переменные типов-значений(values-types)?
//в stack

//Где размещаются переменные типов-ссылок(reference-types)?
//в heap

//Как создать новый тип-значение(values-type) ?
//int x = 12;

//Как создать новый тип-ссылку(reference-type)?
/*
public class TestObject
{
    public int age;
    public string name;
}
*/

//3. Почему класс String называется неизменяемым (immutable)? Что означает неизменяемый» (immutable)
//строка относиться к типу-ссылке и следовательно не содержит прямого значения а содержит ссылку на значение. 
//Каждый раз когда мы меняем значение или присваиваем новое на саомом деле создаеться новая ссылка на значение 
//а не изменяеться старая. immutable типы не подлежат прямому изминению как описано в примере со string

//4. Объясните, почему в следующем примере будет выведена строка      
//“Hello, world.      I wasn’t trimmed!” 
//а не строка “Hello, world. I wasn’t trimmed!”

/*
public class TestTrim
{
    public static void Main()
    {
        string s = "Hello, world.     ";
        s.Trim();
        Console.WriteLine(s + " I wasn’t trimmed!");
    }
}
*/


//потому что в данном случае s это строка и она immutable. когда мы вызвали метод trim для этой строки мы
//создали новую тип-ссылку но не присвоили ее значение переменной.

/*
class BoxingTest
{
    public static void Main()
    {
        int i = 123;
        object o = i;        //implicit boxing   
        i = 456;    
        Console.WriteLine("The value-type value = {0}", i);
        Console.WriteLine("The object-type value = {0}", o);
    }
}
*/

//В результате работы программа печатает следующее:    
//The value-type value = 456    
//The object-type value = 123

//Вопросы: почему переменная типа-ссылки (reference type) o содержит старое значение?
//Потому что по мере выполнения кода мы присвоили o значение i которое на тот момент было 123. 
//То что мы потом поменяли значение переменно i не влияет на переменную o

//что такое boxing и unboxing?
//boxing - приобразование value-type значения в reference-type
//unboxing - извлечение ранее упакованного reference-type значения

//6. Объясните что токре enumerator (перечисление) и для чего он ?
//enumerator это набор связанчх константных значений которые используються для перечеслений. 
//он позволяет заменить обычное значение на константу что может облегчить читаемость и снизить 
//вероятность передачи не правильного значения

//7. Что произойдет если тип Int32 приветси к типу Int16? 

//int x = 10000 Int16 y = (Int16)x; //original

//Я предполагаю это должен был быть пример где я словлю integer overflow exception но мне кажеться задача в PDF
//написана не правильно?? можно подсказку о чем сдесь речь? 