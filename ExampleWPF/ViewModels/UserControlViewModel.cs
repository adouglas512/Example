using CommunityToolkit.Mvvm.ComponentModel;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWPF.ViewModels;

public partial class UserControlViewModel : ObservableObject {
    private readonly IDataAccess _da;

    [ObservableProperty]
    private string _someData;

    [ObservableProperty]
    private string _someMoreData;

    public UserControlViewModel(IDataAccess da) {
        _da = da;

        SomeData = _da.GetSomeData();
        SomeMoreData = _da.GetSomeMoreData();
    }
}
