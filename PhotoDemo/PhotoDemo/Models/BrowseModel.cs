namespace PhotoDemo.Models
{
    public class BrowseModel
    {
        public string Img { get; }
        public SizeImageEnum SizeImage { get; }
        public bool IsFeatured { get; }
        public BrowseModel(string img, SizeImageEnum size, bool isFeatured = false)
        {
            Img = img;
            SizeImage = size;
            IsFeatured = isFeatured;
        }
    }
}
