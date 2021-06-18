using GestaoDeGastosApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GestaoDeGastosApp.Data
{
    public static class Database
    {
        public static ObservableCollection<Gasto> gastos = new ObservableCollection<Gasto>();
    }
}
