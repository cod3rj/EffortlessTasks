namespace Domain
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}