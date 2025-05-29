using DALTUDTXDHONG.Class;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DALTUDTXDHONG.Pages
{
    /// <summary>
    /// Interaction logic for pageVatLieu.xaml
    /// </summary>
    public partial class pageVatLieu : Page
    {
        public pageVatLieu()
        {
            InitializeComponent();
            loadDaTa();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            clsBienToanCuc.clsVatLieu.Add(new clsVatLieuThep(txtName.Text, Convert.ToDouble(txtCuongDoKeoChay.Text), Convert.ToDouble(txtMoDunDanHoi.Text)));
            loadDaTa();
        }
        private void loadDaTa()
        {
            List<clsVatLieuThep> list = new List<clsVatLieuThep>();
            HashSet<string> tenVatLieuDaCo = new HashSet<string>();

            foreach (clsVatLieuThep vatLieuThep in clsBienToanCuc.clsVatLieu)
            {
                if (!tenVatLieuDaCo.Contains(vatLieuThep.TenVatLieu))
                {
                    tenVatLieuDaCo.Add(vatLieuThep.TenVatLieu);
                    list.Add(vatLieuThep);
                }
            }

            MaterialDataGrid.ItemsSource = list;
        }
    }
}
