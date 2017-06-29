namespace Net.Chdk.Model.Category
{
    public sealed class CategoryInfo
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            var categoryInfo2 = obj as CategoryInfo;
            return Name.Equals(categoryInfo2?.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}