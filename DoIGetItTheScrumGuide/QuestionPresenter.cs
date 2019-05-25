namespace DoIGetItTheScrumGuide
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    //using System.Windows.Forms;
    
    using Model;

    public class QuestionPresenter
    {
        private readonly IQuestionForm _view;
        private readonly Document _document = new Document();
        private Question _currentQuestion;
        private readonly List<RadioButton> _choiceButtons = new List<RadioButton>();


        public QuestionPresenter(IQuestionForm view)
        {
            _view = view;
            Initializer();
        }

        private void Initializer()
        {
            _view.NextQuestion += NextQuestion;
            _view.Start += Start;

            _view.NextVisible = false;
            _view.QuestionLabelVisible = false;
            _view.QuestionTextVisible = false;
            _view.ChoicesLabelVisible = false;
            _view.StartVisible = true;

            _view.QuestionCount = String.Format("Total number of questions in database: " + _document.Questions.Count);
        }

        private void Start(object sender, EventArgs e)
        {
            _view.NextVisible = true;
            _view.QuestionLabelVisible = true;
            _view.QuestionTextVisible = true;
            _view.ChoicesLabelVisible = true;
            _view.StartVisible = false;

            ShowNextQuestion();
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            Choice correctAnswer = _currentQuestion.Choices.FirstOrDefault(p => p.AnswerSection != 0 && p.AnswerParagraph != 0);
            Section section = _document.Sections.FirstOrDefault(p => p.Id == correctAnswer.AnswerSection);
            Paragraph paragraph = section.Paragraphs.FirstOrDefault(p => p.Id == correctAnswer.AnswerParagraph);
            foreach (var control in _view.FormControls)
            {
                var button = control as RadioButton;
                if (button != null && button.Checked)
                {
                    string[] parameters = ((string)button.Tag).Split(';');
                    int answerSection = Int32.Parse(parameters[1]);
                    int answerParagraph = Int32.Parse(parameters[2]);
                    if (answerSection == 0 && answerParagraph == 0)
                    {
                        _view.ShowMessageBox(correctAnswer.Text + Environment.NewLine + Environment.NewLine + paragraph.Text);
                    }
                    _currentQuestion.HasBeenAnswered = true;
                }
            }
            if (!_currentQuestion.HasBeenAnswered)
            {
                _view.ShowMessageBox(correctAnswer.Text + Environment.NewLine + Environment.NewLine + paragraph.Text);
            }
            _view.RemoveChoiceButtons(_choiceButtons);
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var questions = _document.Questions.Where(p => !p.HasBeenAnswered);
            int unansweredQuestions = questions.Count();
            var rnd = new Random();
            _currentQuestion = questions.ElementAtOrDefault(rnd.Next(unansweredQuestions));
            if (_currentQuestion != null)
            {
                _view.QuestionText = _currentQuestion.Text;
                int topPos = 146;
                int buttonId = 1;
                foreach (var choice in _currentQuestion.Choices)
                {
                    var button = new RadioButton
                    {
                        Name = String.Format("rdChoice{0}", buttonId),
                        Text = String.Format("&{0}. {1}", buttonId, choice.Text),
                        Tag = String.Format("{0};{1};{2}", _currentQuestion.Id, choice.AnswerSection, choice.AnswerParagraph),
                        Location = new Point(16, topPos),
                        Width = _view.QuestionTextWidth
                    };
                    topPos += 20;
                    buttonId++;
                    _choiceButtons.Add(button);
                }
                _view.AddChoiceButtons(_choiceButtons);
            }
        }
    }
}
