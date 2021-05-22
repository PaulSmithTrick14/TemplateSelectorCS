using System.Windows;

namespace TemplateSelectorCS.VM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new Model.Domain();
            InitializeComponent();
        }
    }
}