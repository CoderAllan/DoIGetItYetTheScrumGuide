namespace DoIGetItTheScrumGuide
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public interface IQuestionForm
    {
        string QuestionCount { get; set; }
        bool StartVisible { get; set; }
        bool NextVisible { get; set; }
        bool QuestionLabelVisible { get; set; }
        bool ChoicesLabelVisible { get; set; }
        bool QuestionTextVisible { get; set; }
        int QuestionTextWidth { get; set; }
        string QuestionText { get; set; }
        Control.ControlCollection FormControls { get; }

        void AddChoiceButtons(List<RadioButton> choiceButtons);
        void RemoveChoiceButtons(List<RadioButton> choiceButtons);
        void ShowMessageBox(string messageBoxText);

        event EventHandler<EventArgs> Start;
        event EventHandler<EventArgs> NextQuestion;
    }
}
