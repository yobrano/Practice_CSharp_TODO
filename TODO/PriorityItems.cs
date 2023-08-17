using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public class PriorityItems
    {
        public Dictionary<string, int> PriorityDict { get; set; }
        public PriorityItems(Dictionary<string, int> priorityDict)
        {
            this.PriorityDict = priorityDict;
        }

        public void AddOrUpdate(string label, int rank)
        {
            // check if rank is present


            while (this.PriorityDict.ContainsValue(rank))
            {
                // if present shift the ranks. preference to the new one
                string oldLabel = PriorityItems.getDictKey(rank, this.PriorityDict);
                this.PriorityDict[oldLabel] -= 1;
                rank = this.PriorityDict[oldLabel];
                Console.WriteLine($"Shifted \t {oldLabel} : {rank} ");
            }

            if (this.PriorityDict.ContainsKey(label))
            {
                this.PriorityDict[label] = rank;
            }

            // otherwise add the rank 


        }

        public void Remove(string label, int rank)
        {

        }

        public void SetToDefault(string label, int rank)
        {
            this.PriorityDict= new Dictionary<string, int>{};
            this.PriorityDict.Add("Low", 0);
            this.PriorityDict.Add("Medium", 1);
            this.PriorityDict.Add("High", 2);
        }

        public static string getDictKey(int value, Dictionary<string, int> dict)
        {
            List<string> keys = dict.Keys.ToList();
            List<int> values = dict.Values.ToList();

            int keyIndex = values.IndexOf(value);

            return keys[keyIndex];
        }
    }

}
