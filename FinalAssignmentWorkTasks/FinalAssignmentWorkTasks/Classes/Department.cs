using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks.Classes
{
    [DataContract]
    public enum Department
    {
        [EnumMember]
        Unassigned,
        [EnumMember]
        Human_Resources,
        [EnumMember]
        Marketing,
        [EnumMember]
        Sales,
        [EnumMember]
        Support,
        [EnumMember]
        Research_and_Development,
        [EnumMember]
        Admin
    }

}
