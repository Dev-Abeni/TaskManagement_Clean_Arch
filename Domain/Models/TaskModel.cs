using Domain.Enums;
using Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TaskModel : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? AssignedTo { get; set; }
        public StatusEnum Status { get; set; }
    }
}
