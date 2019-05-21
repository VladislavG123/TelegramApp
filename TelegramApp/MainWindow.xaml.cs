using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TelegramApp
{
    public partial class MainWindow : Window
    {
        private string _currentThemeUri;

        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(@"Чтобы поменять тему, введите ""Сменить тему"" в поле для ввода сообщений");
            _currentThemeUri = @"LightTheme.xaml";
        }


        private void ChatTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (chatTextBox.Text.ToLower() == "сменить тему")
            {
                if (_currentThemeUri == @"LightTheme.xaml")
                {
                    _currentThemeUri = @"DarkTheme.xaml";
                }
                else
                {
                    _currentThemeUri = @"LightTheme.xaml";
                }
                resurseDictionary.Source = new Uri(_currentThemeUri, UriKind.Relative);

                chatTextBox.Text = "";
            }
        }
    }
}
