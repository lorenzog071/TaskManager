namespace TaskManager.Models
{
    public class TaskListModel
    {
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        //public DateOnly Date { get; set; }
        public Priority TaskPriority { get; set; }

        public enum Priority
    {
        Alta = 3,
        Media = 2,
        Baja = 1
    }
    }
}