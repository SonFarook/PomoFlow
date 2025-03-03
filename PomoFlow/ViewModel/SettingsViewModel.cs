using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media;

namespace PomoFlow.ViewModel
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        // static instance for app-wide access to colors and settings
        private static readonly SettingsViewModel _instance = new SettingsViewModel();
        public static SettingsViewModel Instance => _instance;

        public event PropertyChangedEventHandler PropertyChanged;

        // path to the settings.json file
        private readonly string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../settings.json"));

        // default app colors
        private static readonly string DefaultBackground1 = "#FF252B2B";
        private static readonly string DefaultBackground2 = "#FF380F17";
        private static readonly string DefaultForeground = "#FFEFDFC5";

        public ICommand ResetButtonClicked { get; set; }
        public ICommand SaveButtonClicked { get; set; }

        private Color _backgroundColor1;
        public Color BackgroundColor1
        {
            get => _backgroundColor1;
            set
            {
                _backgroundColor1 = value;
                OnPropertyChanged();
            }
        }

        private Color _backgroundColor2;
        public Color BackgroundColor2
        {
            get => _backgroundColor2;
            set
            {
                _backgroundColor2 = value;
                OnPropertyChanged();
            }
        }

        private Color _foregroundColor;
        public Color ForegroundColor
        {
            get => _foregroundColor;
            set
            {
                _foregroundColor = value;
                OnPropertyChanged();
            }
        }

        public SettingsViewModel()
        {
            ResetButtonClicked = new RelayCommand(ExecuteResetButtonClicked);
            SaveButtonClicked = new RelayCommand(ExecuteSaveButtonClicked);
            GetSelectedColors();
        }

        // resets colors and restarts the app
        private void ExecuteResetButtonClicked()
        {
            ResetColors();
            RestartApp();
        }

        // saves selected colors and restarts the app
        private void ExecuteSaveButtonClicked()
        {
            ChangeSelectedColors();
            GetSelectedColors();
            RestartApp();
        }

        // restarts the app to apply color changes
        private void RestartApp()
        {
            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(exePath, Environment.CommandLine);
            Environment.Exit(0);
        }

        // saves selected colors to settings.json
        private void ChangeSelectedColors()
        {
            var selectedColors = new Dictionary<string, string>
            {
                ["customBackground1"] = BackgroundColor1.ToString(),
                ["customBackground2"] = BackgroundColor2.ToString(),
                ["customForeground"] = ForegroundColor.ToString()
            };

            string json = JsonConvert.SerializeObject(selectedColors);
            File.WriteAllText(path, json);
        }

        // resets colors to defaults and updates settings.json
        private void ResetColors()
        {
            BackgroundColor1 = (Color)ColorConverter.ConvertFromString(DefaultBackground1);
            BackgroundColor2 = (Color)ColorConverter.ConvertFromString(DefaultBackground2);
            ForegroundColor = (Color)ColorConverter.ConvertFromString(DefaultForeground);
            ChangeSelectedColors();
        }

        // loads colors from settings.json
        private void GetSelectedColors()
        {
            string json = File.ReadAllText(path);
            Dictionary<string, string> config = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            BackgroundColor1 = (Color)ColorConverter.ConvertFromString(config["customBackground1"]);
            BackgroundColor2 = (Color)ColorConverter.ConvertFromString(config["customBackground2"]);
            ForegroundColor = (Color)ColorConverter.ConvertFromString(config["customForeground"]);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}