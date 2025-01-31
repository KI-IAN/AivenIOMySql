namespace AivenIOMySql.DAL.Models
{
    public class TestTable
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
