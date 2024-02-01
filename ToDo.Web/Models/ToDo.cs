using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Web.Models;

namespace ToDo.Models
{
    public class ToDo:BaseModel
    {
        public string Description {  get; set; }
        public DateTime? DeadLine { get; set; }
        public int StatusId {  get; set; }
        public int PriorityId {  get; set; }

        //navigational properties
        public virtual Status Status { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        
    }
}
