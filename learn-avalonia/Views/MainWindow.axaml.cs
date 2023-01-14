using Avalonia.Controls;
using Avalonia.Interactivity;

namespace learn_avalonia.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("Title", "asdfasdf");
            messageBoxStandardWindow.Show();
        }

        private void OnPointerEnter(object sender, RoutedEventArgs e)
        {

        }
    }
}
