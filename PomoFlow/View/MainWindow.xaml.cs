using PomoFlow.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace PomoFlow.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TimerViewModel timerViewModel = new TimerViewModel();   

        public MainWindow()
        {
            InitializeComponent();

            DataContext = timerViewModel;


            //if active window is this, stop blinking
            this.Activated += (s, e) => timerViewModel.WindowBlink(false);

            // Navigate the MainFrame everytime the program starts to mainPage
            MainPage mainPage = new MainPage();

            MainFrame.Navigate(mainPage);

            // Event handler for state changes
            StateChanged += MainWindow_StateChanged;
        }

        private void CloseWindowBtn_Clicked(object sender, RoutedEventArgs e)
        {   
            // Close Program if close button clicked
            this.Close();
        }

        private void MinimizeWindowBtn_Clicked(object sender, RoutedEventArgs e)
        {   
            // uncheck the pin window checkbox, so the program can get minimized
            PinWindowCheckBox.IsChecked = false;

            // minimize program if minimize window clicked
            WindowState = WindowState.Minimized;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {   
            //makes the window draggable

            try
            {
                this.DragMove();
            }
            catch { }
        }

        private void PinWindow_Checked(object sender, RoutedEventArgs e)
        {
            // get the window to foreground
            Topmost = true;
        }

        private void PinWindow_Unchecked(object sender, RoutedEventArgs e)
        {
            // get the window to background
            Topmost = false;
        }
        private void MainWindow_StateChanged(object sender, System.EventArgs e)
        {
            if (WindowState == WindowState.Minimized && Topmost)
            {
                // if the window gets minimized and Topmost is true, then get it back
                WindowState = WindowState.Normal;
            }
        }

        private void SettingsBtn_Checked(object sender, RoutedEventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            MainFrame.Navigate(settingsPage);
        }

        private void SettingsBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            MainFrame.Navigate(mainPage);
        }
    }
}