namespace Tests
{
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;

    using DoIGetItTheScrumGuide;

    public class MockMainForm : IQuestionForm
    {
        public string QuestionCount { get; set; }
        public bool StartVisible { get; set; }
        public bool NextVisible { get; set; }
        public bool QuestionLabelVisible { get; set; }
        public bool ChoicesLabelVisible { get; set; }
        public bool QuestionTextVisible { get; set; }
        public int QuestionTextWidth { get; set; }
        public string QuestionText { get; set; }

        public int RemoveChoiceButtonsCallCount { get; set; }
        public int AddChoiceButtonsCallCount { get; set; }
        public int ShowMessageBoxCallCount { get; set; }

        public Control.ControlCollection FormControls { get; set; }

        public event EventHandler<EventArgs> Start;
        public event EventHandler<EventArgs> NextQuestion;

        public MockMainForm()
        {
            var owner = new Control();
            FormControls = new Control.ControlCollection(owner);
        }

        public void RemoveChoiceButtons(List<RadioButton> choiceButtons)
        {
            foreach (var choiceButton in choiceButtons)
            {
                FormControls.Remove(choiceButton);
            }
            RemoveChoiceButtonsCallCount++;
        }

        public void AddChoiceButtons(List<RadioButton> choiceButtons)
        {
            foreach (var choiceButton in choiceButtons)
            {
                FormControls.Add(choiceButton);
            }
            AddChoiceButtonsCallCount++;
        }

        public void ShowMessageBox(string messageBoxText)
        {
            ShowMessageBoxCallCount++;
        }

        public void FireStartClicked()
        {
            if (Start != null)
            {
                Start(this, EventArgs.Empty);
            }
        }

        public void FireNextQuestionClicked()
        {
            if (NextQuestion != null)
            {
                NextQuestion(this, EventArgs.Empty);
            }
        }

        public void FireRadioButtonChecked()
        {
            if (FormControls != null && FormControls.Count > 0)
            {
                var radioButton = FormControls[0] as RadioButton;
                radioButton.Checked = true;
            }
        }
    }
}
