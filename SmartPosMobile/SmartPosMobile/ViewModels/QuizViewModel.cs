using SmartPosMobile.Helper;
using SmartPosMobile.Models;
using SmartPosMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartPosMobile.ViewModels
{
    public class QuizViewModel : BasePageViewModel
    {

        private bool quizVisible = true;

        public bool QuizVisible
        {
            get { return quizVisible; }
            set { quizVisible = value; OnPropertyChanged(nameof(QuizVisible)); }
        }

        private bool visible = false;

        public bool Visible
        {
            get { return visible; }
            set { visible = value; OnPropertyChanged(nameof(Visible)); }
        }

        private long totalPoint;

        public long TotalPoint
        {
            get { return totalPoint; }
            set { totalPoint = value; OnPropertyChanged(nameof(TotalPoint)); }
        }

        private long point = 0;

        public long Points
        {
            get { return point; }
            set { point = value; OnPropertyChanged(nameof(Points)); }
        }
        private long lose = 0;

        public long Loss
        {
            get { return lose; }
            set { lose = value; OnPropertyChanged(nameof(Loss)); }
        }

        private bool _swipe = false;

        public bool Swipe
        {
            get { return _swipe; }
            set { _swipe = value; OnPropertyChanged(nameof(Swipe)); }
        }

        private int _position = 1;

        public int Position
        {
            get { return _position; }
            set { _position = value; OnPropertyChanged(nameof(Position)); }
        }

        private string selected;

        public string Selected
        {
            get { return selected; }
            set { selected = value; OnPropertyChanged(nameof(Selected)); }
        }

        private Quiz _model;
        public Quiz Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged(nameof(Model)); }
        }

        private long time;

        public long Time
        {
            get { return time; }
            set { time = value; OnPropertyChanged(nameof(Time)); }
        }

        public ObservableCollection<Quiz> Quizzes { get; set; }
        public QuizViewModel()
        {
            Quizzes = new ObservableCollection<Quiz>();
            Quizzes.Add(new Quiz
            {
                Id = 1,
                Question = "Tallest Building in the world",
                option_1 = "Dharara",
                option_2 = "Bruj khalifa",
                answer = "Bruj khalifa"
            });
            Quizzes.Add(new Quiz
            {
                Id = 2,
                Question = "Heighest mountain?",
                option_1 = "Mt Everest",
                option_2 = "Mt kanchanjunga",
                answer = "Mt Everest"
            });
            Quizzes.Add(new Quiz
            {
                Id = 3,
                Question = "Tallest Man",
                option_1 = "Hari",
                option_2 = "Ram",
                answer = "Hari"
            });
            Quizzes.Add(new Quiz
            {
                Id = 4,
                Question = "Tallest Car",
                option_1 = "Honda",
                option_2 = "Car",
                answer = "Honda"
            });
            Task.Run(() =>
            {
                if (Quizzes.LastOrDefault() == Model)
                {
                    QuizVisible = false;
                    TotalPoint = Points;
                    visible = true;
                }

             
            });
        }

        public ICommand Submit => new Command<Quiz>((model) =>
             {
                 Model = model;
                 var selectedAns = Selected;
                 if (selectedAns == model.answer)
                 {
                     Points++;
                 }
                 else
                     Loss--;
                 Position++;
             });
    }
}
