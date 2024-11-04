namespace TaskManager.Models
{
    public class TaskListModel
    {
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        //public DateOnly Date { get; set; }
        public bool Done { get; set; }
    }
}