namespace TaskManager.Data.Entities
{
    public class TaskToDo : BaseEntity
    {   

        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public bool Done { get; set; }
    }
}