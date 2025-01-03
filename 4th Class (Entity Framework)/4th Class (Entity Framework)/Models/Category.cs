namespace _4th_Class__Entity_Framework_.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}