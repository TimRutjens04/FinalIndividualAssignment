using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks.Classes
{
    [DataContract]
    public enum TaskStatus
    {
        [EnumMember]
        Open,
        [EnumMember]
        In_Progress,
        [EnumMember]
        Completed,
        [EnumMember]
        Blocked,
        [EnumMember]
        Cancelled
    }
}
