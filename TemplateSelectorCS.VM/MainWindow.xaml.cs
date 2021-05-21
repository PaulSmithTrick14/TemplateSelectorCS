using System.Windows;

namespace TemplateSelectorCS.VM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new Model.Domain();
            InitializeComponent();
        }
    }
}
