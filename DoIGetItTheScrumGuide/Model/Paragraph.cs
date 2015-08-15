namespace DoIGetItTheScrumGuide.Model
{
    public class Paragraph
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Paragraph(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
