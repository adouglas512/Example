using CommunityToolkit.Mvvm.ComponentModel;
using ExampleWPF.ViewModels;
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
using System.Windows.Shapes;

namespace ExampleWPF.Views; 

[ObservableObject]
public partial class DialogView : Window {
    [ObservableProperty]
    private UserControlViewModel _ucVM;
    
    public DialogView(UserControlViewModel ucVM) {
        DataContext = this;
        UcVM = ucVM;
        InitializeComponent();
    }
}
