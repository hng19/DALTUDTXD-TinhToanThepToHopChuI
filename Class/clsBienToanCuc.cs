using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTUDTXDHONG.Class
{
    public static class clsBienToanCuc
    {
        public static ObservableCollection<clsTietDien> clsTietDien = new ObservableCollection<clsTietDien>();
        public static ObservableCollection<clsVatLieuThep> clsVatLieu { get; set; } = new ObservableCollection<clsVatLieuThep>();
        public static ObservableCollection<clsColumn> clsColumn { get; set; } = new ObservableCollection<clsColumn>();
    }
}
