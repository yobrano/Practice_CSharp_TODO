using TODO;

namespace TODOUnitTests
{
    public class TodoItemTest
    {

        [Fact]
        public void TodoItemCreation()
        {
            DateTime startTime = new DateTime(2023, 8, 10, 17, 30, 0);
            DateTime endTime = new DateTime(2023, 8, 11, 20, 0, 0);
            var tags = new List<string> { "Home", "Chores", "Organise" };
            var notes = new List<string> { "Get Bucket from Marion", "Try using new bleach on shirt" };
            var priorityList = new List<string> { "Low", "Medium", "High" };
            
            // Valid Entry 
            Assert.IsType<TodoItem>(
               new TodoItem("Clean Clothes", startTime, endTime, priorityList.IndexOf("Low"), tags, notes)
             );

            // Error - End time < Start time
            Assert.Throws<ArgumentException>(
                ()=> new TodoItem( "Do Lanudry", endTime, startTime )
            );
        }
    }
}