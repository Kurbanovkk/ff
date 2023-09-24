using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int count = 1000000;
            List<int> list = new List<int>(count);
            ArrayList arrayList = new ArrayList(count);
            LinkedList<int> linkedList = new LinkedList<int>();

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Заполнение коллекций:");

            stopwatch.Start();
            for (int i = 1; i <= count; i++)
            {
                list.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"List: {stopwatch.ElapsedMilliseconds} ms,  {stopwatch.ElapsedTicks}  ticks");

            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 1; i <= count; i++)
            {
                arrayList.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"ArrayList: {stopwatch.ElapsedMilliseconds} ms, {stopwatch.ElapsedTicks} ticks");

            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 1; i <= count; i++)
            {
                linkedList.AddLast(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"LinkedList: {stopwatch.ElapsedMilliseconds} ms, {stopwatch.ElapsedTicks} ticks");

            stopwatch.Reset();

            Console.WriteLine();

            Console.WriteLine("Поиск 496753-го элемента:");

            stopwatch.Start();

            var value2 = list.IndexOf(496753);

            stopwatch.Stop();
            Console.WriteLine($"List:  значение под индексом 496753: {value2}, время {stopwatch.ElapsedMilliseconds} ms, {stopwatch.ElapsedTicks} ticks");

            stopwatch.Reset();

            stopwatch.Start();

            var value1 = arrayList.IndexOf(496753);

            stopwatch.Stop();
            Console.WriteLine($"ArrayList: значение под индексом 496753: {value1}, время {stopwatch.ElapsedMilliseconds} ms,  {stopwatch.ElapsedTicks}  ticks");

            stopwatch.Reset();

            LinkedListNode<int> currentNode = linkedList.First;
            stopwatch.Start();

            var node = linkedList.First;
            for (int i = 0; i < 496752; i++)
            {
                node = node.Next;
            }
            int elementLinkedList = node.Value;
            stopwatch.Stop();
            Console.WriteLine($"LinkedList: значение под индексом 496752: {elementLinkedList}, время {stopwatch.ElapsedMilliseconds} ms,  {stopwatch.ElapsedTicks}  ticks");

            stopwatch.Reset();

            Console.WriteLine();

            Console.WriteLine("Элементы, делющиеся на 777:");

            stopwatch.Start();
            foreach (int item in list)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"List: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Reset();

            stopwatch.Start();
            foreach (int item in arrayList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"ArrayList: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Reset();

            stopwatch.Start();
            foreach (int item in linkedList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"LinkedList: {stopwatch.ElapsedMilliseconds} ms");

            Console.WriteLine("\nЗадание выполнено.");
        }


    }
}
