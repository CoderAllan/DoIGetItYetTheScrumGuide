namespace DoIGetItTheScrumGuide.Model
{
    using System;
    using System.Collections.Generic;
    
    public class Question
    {
        public Guid Id { get; private set; }

        public string Text { get; set; }

        public List<Choice> Choices { get; set; }

        public bool HasBeenAnswered { get; set; }

        public Question()
        {
            Id = Guid.NewGuid();

            Choices = new List<Choice>();
        }
    }
}
