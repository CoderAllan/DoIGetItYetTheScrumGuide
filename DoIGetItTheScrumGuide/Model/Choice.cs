namespace DoIGetItTheScrumGuide.Model
{
    public class Choice
    {
        public string Text { get; set; }
        public int AnswerSection { get; set; }
        public int AnswerParagraph { get; set; }

        public Choice(int answerSection, int answerParagraph, string text)
        {
            Text = text;
            AnswerSection = answerSection;
            AnswerParagraph = answerParagraph;
        }
    }
}
