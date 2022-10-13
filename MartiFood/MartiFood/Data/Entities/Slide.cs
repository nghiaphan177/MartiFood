using MartiFood_API.Data.Enums;

namespace MartiFood_API.Data.Entities
{
    public class Slide
    {
        public Guid Id { set; get; }
        public string Name { set; get; } = null!;
        public string? Description { set; get; }
        public string? Url { set; get; }

        public string Image { get; set; } = null!;
        public int SortOrder { get; set; }
        public Status Status { set; get; }
    }
}
