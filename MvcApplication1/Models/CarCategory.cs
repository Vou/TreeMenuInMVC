namespace MvcApplication1.Models
{
    public class CarCategory
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string FirstLetter { get; set; }
        public string AnchorName { get; set; }
        public int Level { get; set; }
        public short DelFlag { get; set; }
    }
}