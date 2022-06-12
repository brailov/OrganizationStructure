
namespace OrgManager.Domain.Entities
{
    public class Task
    {
        public string text { get; set; }
        public string assignDate { get; set; }
        public string dueDate { get; set; }
        public object Status { get; set; }
    }
}
