using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Doubly_Console_App
{
    class program
    {
        static void Main(string[] args)
        {
            FirstSet.LinkedList_Doubly LLD1 = new FirstSet.LinkedList_Doubly();
            LLD1.InsertNode(4);
            LLD1.InsertNode(6);
            LLD1.InsertNode(2);
            LLD1.InsertNode(8);
            LLD1.InsertNode(12);
            LLD1.InsertNode(10);

            LLD1.InsertNode(4);
            
            LLD1.Traverse();

            LLD1.DeleteNode(1);
            LLD1.DeleteNode(4);
            LLD1.DeleteNode(2);
            LLD1.DeleteNode(12);

            LLD1.InsertNode(12);

            Console.WriteLine("-------");
            LLD1.Traverse();

            Console.WriteLine("-------");
            LLD1.Pretravel();
            Console.WriteLine("===========================================================");
            /////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("===========================================================");
            SecondSet.LinkedList_Doubly LLD2 = new SecondSet.LinkedList_Doubly();
            LLD2.InsertNode(5);
            LLD2.InsertNode(3);
            LLD2.InsertNode(7);
            LLD2.InsertNode(1);
            LLD2.InsertNode(11);
            LLD2.InsertNode(9);

            LLD2.InsertNode(5);

            LLD2.Traverse();

            LLD2.DeleteNode(2);
            LLD2.DeleteNode(4);
            LLD2.DeleteNode(1);
            LLD2.DeleteNode(9);
            LLD2.DeleteNode(11);

            LLD2.InsertNode(9);

            Console.WriteLine("-------");
            LLD2.Traverse();

            Console.WriteLine("-------");
            LLD2.Pretravel();
            Console.ReadLine();
        }
    }
}
