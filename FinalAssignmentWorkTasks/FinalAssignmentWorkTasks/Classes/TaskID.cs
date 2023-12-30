using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks.Classes
{
    public class TaskID
    {
        public const string TaskIDFileName = "TaskID.txt";
        public static readonly string TaskIDFilePath = Path.Combine("Resources", TaskIDFileName);

        public static int GetNextID()
        {
            int taskID = 1;

            if (File.Exists(TaskIDFilePath))
            {
                try
                {
                    string content = File.ReadAllText(TaskIDFilePath);
                    if (int.TryParse(content, out int storedTaskID))
                    {
                        taskID = storedTaskID + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading task ID\n" + ex.Message);
                }
            }
            SaveTaskId(taskID);
            return taskID;
        }
        public static void SaveTaskId(int taskId) 
        {
            try 
            {
                File.WriteAllText(TaskIDFilePath, taskId.ToString());
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error saving task ID\n" + ex.Message);
            }
        }
    }
}
