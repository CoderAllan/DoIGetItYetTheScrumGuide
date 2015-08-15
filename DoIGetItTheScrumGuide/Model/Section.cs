namespace DoIGetItTheScrumGuide.Model
{
    using System.Collections.Generic;

    public class Section
    {
        public int Id { get; set; }

        public string Heading { get; set; }

        public List<Paragraph> Paragraphs { get; set; }

        public Section()
        {
            Paragraphs = new List<Paragraph>();
        }
    }
}
