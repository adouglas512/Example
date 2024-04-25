using ExampleWPF.Helpers;
using ExampleWPF.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExampleWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private readonly IAbstractFactory<DialogView> _dialogViewFactory;

        public MainWindow(IAbstractFactory<DialogView> dialogViewFactory) {
            InitializeComponent();

            _dialogViewFactory = dialogViewFactory;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var dialog = _dialogViewFactory.Create();
            dialog.ShowDialog();
        }
    }
}