using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace TODO
{
    public class TodoList
    {
        public List<TodoItem> TodoItems { get; set; }

        public TodoList(List<TodoItem> todoItems = null)
        {
            if (todoItems == null)
            {
                todoItems = new List<TodoItem>();
            }
            TodoItems = todoItems;
        }

        private string GetJsonPath() => Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "output", "output.json");

        public bool ExportToJson()
        {
            // Serialize list
            string jsonData = JsonConvert.SerializeObject(TodoItems, Formatting.Indented);

            // Write out
            File.WriteAllText(GetJsonPath(), jsonData);
            return true;
        }

        public bool ImportFromJson()
        {
            // Get and Read from file
            string jsonData = File.ReadAllText(GetJsonPath());
            // Deserialize list
            TodoItems = JsonConvert.DeserializeObject<List<TodoItem>>(jsonData);
            
            return true;
        }

    }
}
