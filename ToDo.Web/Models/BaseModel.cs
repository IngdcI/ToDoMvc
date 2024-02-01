namespace ToDo.Models
{
    public class BaseModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; }=DateTime.Now;
    }
}
