namespace PhotoDemo.Models
{
    public class DiscoverModel
    {
        public string Img { get; }
        public string UserImg { get; }
        public string Name { get; }
        public string Nick { get; }

        public DiscoverModel(string img, string userImg, string name, string nick)
        {
            Img = img;
            UserImg = userImg;
            Name = name;
            Nick = nick;
        }
    }
}
