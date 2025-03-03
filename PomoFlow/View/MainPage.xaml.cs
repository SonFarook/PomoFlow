using System.Windows.Controls;
using System.Windows.Input;
using PomoFlow.ViewModel;

namespace PomoFlow.View
{
    /// <summary>
    /// Interaktionslogik für MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        TimerViewModel timerViewModel = new TimerViewModel();
        public MainPage()
        {
            InitializeComponent();

            DataContext = timerViewModel;

            //set the focus on the page, so the keydown event triggers
            this.Focusable = true;
            this.Focus();
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            // if the user presses the "space" key, execute the command thats binded with the start-stop button
            if (e.Key == Key.Space) 
            {
                timerViewModel.StartStopButtonClicked.Execute(this);
            }
        }
    }
}
