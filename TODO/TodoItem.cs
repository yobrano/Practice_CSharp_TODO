using System;
using System.Collections.Generic;
using System.Text;

namespace TODO
{

    public class TodoItem
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Priority { get; set; }
        public List<string> Notes { get; set; }
        public List<string> Tags { get; set; }
        public bool IsComplete { get; set; }

        public TodoItem(string title, DateTime startTime, DateTime endtime, int priority = 0, List<string> tags = null, List<string> notes = null)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endtime;
            Tags = tags;
            Notes = notes;
            Priority = priority;
        }

        public TimeSpan Duration() => EndTime - StartTime;


        public string TaskStatus()
        {
            string status;

            if (IsComplete){
                status = "Complete";    
            }else if(StartTime > DateTime.Now && IsComplete == false){
                status = "Upcomming";
            }else if (EndTime > DateTime.Now && StartTime <= DateTime.Now){
                status = "In Progress";
            }else{
                status = "Overdue";
            }

            return status;
        }

        public string Description()
        {
            var descripton = new StringBuilder();
            descripton.AppendLine($"Title:\t\t{Title}");
            descripton.AppendLine($"Start:\t\t{StartTime}");
            descripton.AppendLine($"End:\t\t{EndTime}");
            descripton.AppendLine($"Duration:\t{Duration()}");
            descripton.AppendLine($"Status:\t{TaskStatus()}");
            descripton.AppendLine($"Tags");
            foreach (var tag in Tags)
            {
                descripton.AppendLine($"\t* {tag}");
            }

            descripton.AppendLine($"Notes");
            foreach (var note in Notes)
            {
                descripton.AppendLine($"\t* {note}");
            }


            return descripton.ToString();
        }

    }
}
