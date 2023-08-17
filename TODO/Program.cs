using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime startTime = new DateTime(2023, 8, 10, 17, 30, 0);
            //DateTime endTime = new DateTime(2023, 8, 11, 20, 0, 0);
            //var tags = new List<string>{ "Home", "Chores", "Organise" };
            //var notes = new List<string> { "Get Bucket from Marion", "Try using new bleach on shirt" };
            //var priorityList = new List<string> { "Low", "Medium", "High"};

            //TodoItem myTodo = new TodoItem("Clean Clothes", startTime, endTime, priorityList.IndexOf("Low"), tags, notes);
            
            //Console.WriteLine(myTodo.Description());

            //var myTodoList = new TodoList();
            //var todoItems = myTodoList.TodoItems;
            //todoItems.Add(myTodo);

            //myTodoList.ExportToJson();

            var myTodoList = new TodoList();
            myTodoList.ImportFromJson();
            Console.WriteLine(myTodoList.TodoItems[0].Description());

            Console.ReadLine();
        }
    }
}
