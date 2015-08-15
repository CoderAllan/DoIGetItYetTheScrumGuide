namespace DoIGetItTheScrumGuide
{
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;
    
    using Properties;

    public partial class MainForm : Form, IQuestionForm
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public string QuestionCount
        {
            get { return lblQuestionCount.Text; }
            set { lblQuestionCount.Text = value; }
        }

        public bool StartVisible
        {
            get { return btnStart.Visible; }
            set { btnStart.Visible = value; }
        }

        public bool NextVisible
        {
            get { return btnNext.Visible; }
            set { btnNext.Visible = value; }
        }

        public bool QuestionLabelVisible
        {
            get { return lblQuestion.Visible; }
            set { lblQuestion.Visible = value; }
        }

        public bool ChoicesLabelVisible
        {
            get { return lblChoices.Visible; }
            set { lblChoices.Visible = value; }
        }

        public bool QuestionTextVisible
        {
            get { return txtQuestion.Visible; }
            set { txtQuestion.Visible = value; }
        }

        public string QuestionText
        {
            get { return txtQuestion.Text; }
            set { txtQuestion.Text = value; }
        }

        public int QuestionTextWidth
        {
            get { return txtQuestion.Width; }
            set { txtQuestion.Width = value; }
        }

        public Control.ControlCollection FormControls
        {
            get { return Controls; }
        }

        private readonly QuestionPresenter _presenter;
        public event EventHandler<EventArgs> Start;
        public event EventHandler<EventArgs> NextQuestion;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new QuestionPresenter(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Start != null)
            {
                Start(this, EventArgs.Empty);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (NextQuestion != null)
            {
                NextQuestion(this, EventArgs.Empty);
            }
        }

        public void AddChoiceButtons(List<RadioButton> choiceButtons)
        {
            foreach (var choiceButton in choiceButtons)
            {
                Controls.Add(choiceButton);
            }
        }

        public void RemoveChoiceButtons(List<RadioButton> choiceButtons)
        {
            foreach (var button in choiceButtons)
            {
                Controls.Remove(button);
            }
            choiceButtons.Clear();
        }

        public void ShowMessageBox(string messageBoxText)
        {
            MessageBox.Show(Resources.MainForm_ShowMessageBox_Correct_answer + messageBoxText, Resources.MainForm_ShowMessageBox_Wrong_answer, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
