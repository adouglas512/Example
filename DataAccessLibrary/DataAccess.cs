using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;
public class DataAccess : IDataAccess {
    public string GetSomeData() {
        return "Some Data";
    }

    public string GetSomeMoreData() {
        return "Some More Data";
    }
}
