using PomoFlow.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Input;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows;


namespace PomoFlow.ViewModel
{
    public class TimerViewModel : INotifyPropertyChanged
    {
        private readonly TimerModel _timerModel;
        private readonly System.Timers.Timer _timer;
        private readonly SoundPlayer _buttonClickSound = new SoundPlayer(@"Sounds\ButtonClickSound.wav");
        private readonly SoundPlayer _timerEndSound = new SoundPlayer(@"Sounds\TimerEndSound.wav");

        public ICommand StartStopButtonClicked { get; set; }
        public ICommand SkipBreakButtonClicked { get; set; }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FlashWindowEx(ref FLASHWINFO pwfi); // importing FlashWindowEx to create windows notification (program blinks orange)
        [StructLayout(LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public uint cbSize; //size of the structure
            public IntPtr hwnd; // window-handle (WindowInteropHelper)
            public uint dwFlags; // says how the program should blink
            public uint uCount; // count of blinks
            public uint dwTimeout; // time in milliseconds between the blink events
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();  // importing GetForegroundWindow() to get the active window

        public event PropertyChangedEventHandler PropertyChanged;

        public TimerViewModel()
        {
            _timerModel = new TimerModel();
            _timer = new System.Timers.Timer(100);
            _timer.Elapsed += OnTimedEvent;

            StartStopButtonClicked = new RelayCommand(ExecuteStartStopButtonClicked);
            SkipBreakButtonClicked = new RelayCommand(ExecuteSkipBreakButtonClicked);

            SetDefaultValues();
        }

        private string _startStopButtonContent;
        public string StartStopButtonContent
        {
            get => _startStopButtonContent;
            set
            {
                _startStopButtonContent = value;
                OnPropertyChanged();
            }
        }

        private string _pomoCountText;
        public string PomoCountText
        {
            get => _pomoCountText;
            set
            {
                _pomoCountText = value;
                OnPropertyChanged();
            }
        }

        private string _remainingTime;
        public string RemainingTime
        {
            get => _remainingTime;
            set
            {
                _remainingTime = value;
                OnPropertyChanged();
            }
        }

        private bool _isPomoTime;
        public bool IsPomoTime
        {
            get => _isPomoTime;
            set
            {
                _isPomoTime = value;
                OnPropertyChanged();
            }
        }

        private bool _isShortBreakTime;
        public bool IsShortBreakTime
        {
            get => _isShortBreakTime;
            set
            {
                _isShortBreakTime = value;
                OnPropertyChanged();
            }
        }

        private bool _isLongBreakTime;
        public bool IsLongBreakTime
        {
            get => _isLongBreakTime;
            set
            {
                _isLongBreakTime = value;
                OnPropertyChanged();
            }
        }

        private bool _showSkipButton;
        public bool ShowSkipButton
        {
            get => _showSkipButton;
            set
            {
                _showSkipButton = value;
                OnPropertyChanged();
            }
        }


        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            TimeSpan remainingTime = _timerModel.GetRemainingTime();

            RemainingTime = remainingTime.ToString(@"mm\:ss");

            if (remainingTime.TotalSeconds <= 0)
            {   
                _timerModel.IsBreakTime = !_timerModel.IsBreakTime; // change the value of isBreakTime everytime the timer ends

                if (!_timerModel.IsBreakTime)
                {
                    _timerModel.PomoCounter++; // only raise the pomocounter, if a pomodoro timer ends
                    PomoCountText = "#" + _timerModel.PomoCounter.ToString();

                    RemainingTime = "25:00";
                    ChangeSelectedLabel("Pomo");
                }

                else
                {
                    if (_timerModel.PomoCounter % 4 == 0) // after 4 pomos, start a long break
                    {
                        RemainingTime = "15:00";
                        ChangeSelectedLabel("LongBreak");
                    }
                    else
                    {
                        RemainingTime = "05:00";
                        ChangeSelectedLabel("ShortBreak");
                    }
                }
                ResetTimer();
                _timerEndSound.Play();
                WindowBlink(true);
            }
        }

        private void ExecuteStartStopButtonClicked()
        {   
            // end the timer end notification sound, if user clicks the button

            _timerEndSound.Stop();
            
            _buttonClickSound.Play();

            // if timer is not active

            if (!_timerModel.IsRunning)
            {
                if (!_timerModel.GotClickedBefore)
                {
                    // if the button got clicked the first time, add one second (because the timer is dropping 1 second instantly)
                    _timerModel.TimerStartTime = DateTime.Now + TimeSpan.FromSeconds(1) - _timerModel.ElapsedTime;
                }

                else
                {
                    _timerModel.TimerStartTime = DateTime.Now - _timerModel.ElapsedTime;
                }

                _timer.Start();
                _timerModel.IsRunning = true;
                _timerModel.GotClickedBefore = true;
                StartStopButtonContent = "Stop";
                ShowSkipButton = true;
            }

            // if timer is active

            else
            {
                _timer.Stop();
                _timerModel.IsRunning = false;
                StartStopButtonContent = "Start";
                ShowSkipButton = false;
            }
        }

        private void ExecuteSkipBreakButtonClicked()
        {
            _timerEndSound.Stop();
            _buttonClickSound.Play();
            ResetTimer();

            if (_timerModel.IsBreakTime)
            {
                RemainingTime = "25:00";
                _timerModel.IsBreakTime = !_timerModel.IsBreakTime;
                ChangeSelectedLabel("Pomo");
            }

            else
            {
                _timerModel.IsBreakTime = !_timerModel.IsBreakTime;
                _timerModel.PomoCounter++;
                PomoCountText = "#" + _timerModel.PomoCounter.ToString();

                if(_timerModel.PomoCounter % 4 == 0)
                {
                    RemainingTime = "15:00";
                    ChangeSelectedLabel("LongBreak");

                }

                else
                {
                    RemainingTime = "05:00";
                    ChangeSelectedLabel("ShortBreak");
                }
            }
        }

        //resets the timer
        private void ResetTimer()
        {
            StartStopButtonContent = "Start";
            _timer.Stop();
            _timerModel.GotClickedBefore = false;
            _timerModel.IsRunning = false;
            _timerModel.ElapsedTime = TimeSpan.FromSeconds(0);
            ShowSkipButton = false;
        }

        //starts or stops window blinking
        public void WindowBlink(bool blinkMode)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Window mainWindow = Application.Current.MainWindow;
                if (mainWindow == null) return;

                IntPtr hwnd = new WindowInteropHelper(mainWindow).Handle;
                if (hwnd == GetForegroundWindow()) return; // stop blinking if window is active

                FLASHWINFO fi = new FLASHWINFO
                {
                    cbSize = (uint)Marshal.SizeOf(typeof(FLASHWINFO)),
                    hwnd = hwnd, // re-using hwnd
                    dwFlags = (uint)(blinkMode ? 2 : 0), // FLASHW_TRAY or FLASHW_STOP
                    uCount = blinkMode ? uint.MaxValue : 0, // blink or stop
                    dwTimeout = 0
                };

                FlashWindowEx(ref fi);
            });
        }

        //changing selected label for the ui changes (check label style in app.xaml)
        private void ChangeSelectedLabel(string selectedTimerType)
        {
            IsPomoTime = false;
            IsShortBreakTime = false;
            IsLongBreakTime = false;

            switch (selectedTimerType) 
            {
                case "Pomo":
                    IsPomoTime = true;
                    break;

                case "ShortBreak":
                    IsShortBreakTime= true; 
                    break;

                case "LongBreak":
                    IsLongBreakTime= true;
                    break;
            }
        }
        
        //sets the first values, so that the textblocks etc. wont be empty in the beginning
        private void SetDefaultValues()
        {
            PomoCountText = "#" + _timerModel.PomoCounter.ToString();
            StartStopButtonContent = "Start";
            RemainingTime = "25:00";
            ChangeSelectedLabel("Pomo");
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
