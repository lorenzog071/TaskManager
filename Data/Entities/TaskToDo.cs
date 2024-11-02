namespace TaskManager.Data.Entities
{
    public class TaskToDo
    {   
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public bool Done { get; set; }
    }
}