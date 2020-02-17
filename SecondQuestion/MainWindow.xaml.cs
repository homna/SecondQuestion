using System;
using System.Windows;

namespace SecondQuestion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isPersian = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries.Clear();
            var dictionary = new ResourceDictionary();
            if (_isPersian)
            {
                _isPersian = false;
                dictionary.Source = new Uri("pack://application:,,,/EnglishLanguage.xaml", UriKind.Absolute);
            }
            else
            {
                _isPersian = true;
                dictionary.Source = new Uri("pack://application:,,,/PersianLanguage.xaml", UriKind.Absolute);
            }
            Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
