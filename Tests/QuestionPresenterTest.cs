namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using DoIGetItTheScrumGuide;

    [TestClass]
    public class QuestionPresenterTest
    {
        [TestMethod]
        public void Test_Initialize()
        {
            // Arrange
            var view = new MockMainForm();
            
            // Act
            var presenter = new QuestionPresenter(view);

            // Assert
            Assert.IsNotNull(presenter);
            Assert.IsFalse(view.NextVisible);
            Assert.IsFalse(view.QuestionLabelVisible);
            Assert.IsFalse(view.QuestionTextVisible);
            Assert.IsFalse(view.ChoicesLabelVisible);
            Assert.IsTrue(view.StartVisible);
            Assert.IsTrue(view.QuestionCount.StartsWith("Total number of questions in database"));

            Assert.AreEqual(0, view.RemoveChoiceButtonsCallCount);
            Assert.AreEqual(0, view.AddChoiceButtonsCallCount);
            Assert.AreEqual(0, view.ShowMessageBoxCallCount);
        }

        [TestMethod]
        public void Test_Start()
        {
            // Arrange
            var view = new MockMainForm();

            // Act
            var presenter = new QuestionPresenter(view);
            view.FireStartClicked();

            // Assert
            Assert.IsNotNull(presenter);
            Assert.IsTrue(view.NextVisible);
            Assert.IsTrue(view.QuestionLabelVisible);
            Assert.IsTrue(view.QuestionTextVisible);
            Assert.IsTrue(view.ChoicesLabelVisible);
            Assert.IsFalse(view.StartVisible);
            Assert.AreEqual(0, view.RemoveChoiceButtonsCallCount);
            Assert.IsTrue(view.AddChoiceButtonsCallCount > 0);
            Assert.AreEqual(0, view.ShowMessageBoxCallCount);
        }

        [TestMethod]
        public void Test_NextQuestion()
        {
            // Arrange
            var view = new MockMainForm();

            // Act
            var presenter = new QuestionPresenter(view);
            view.FireStartClicked();
            view.FireRadioButtonChecked();
            view.FireNextQuestionClicked();

            // Assert
            Assert.IsNotNull(presenter);
            Assert.IsTrue(view.NextVisible);
            Assert.IsTrue(view.QuestionLabelVisible);
            Assert.IsTrue(view.QuestionTextVisible);
            Assert.IsTrue(view.ChoicesLabelVisible);
            Assert.IsFalse(view.StartVisible);
            Assert.IsTrue(view.RemoveChoiceButtonsCallCount > 0);
            Assert.IsTrue(view.AddChoiceButtonsCallCount > 0);
        }
    }
}
