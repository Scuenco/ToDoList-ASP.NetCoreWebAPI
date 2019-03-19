namespace todo_list_NetCoreWebAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool Completed { get; set; }
        public bool? Deleted { get; set; }
    }
}