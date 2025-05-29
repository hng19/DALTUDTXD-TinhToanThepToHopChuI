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
using Wpf.Ui.Controls;

namespace DALTUDTXDHONG.Pages
{
    /// <summary>
    /// Interaction logic for pageColumnParameters.xaml
    /// </summary>
    public partial class pageColumnParameters : Page
    {
        public pageColumnParameters()
        {
            InitializeComponent();
            dtgColumn.ItemsSource = clsBienToanCuc.clsColumn;
            LoadDL();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgColumn.SelectedItem is clsColumn selectedItem)
            {
                cbbTietDien.SelectedItem = selectedItem.TietDien.Name;
                cbbVatLieu.SelectedItem = selectedItem.VatLieu.TenVatLieu;
                txtDaiCot.Text = selectedItem.ChieuCao.ToString();
                txtMoMen.Text = selectedItem.MoMent.ToString();
                txtTaiTrong.Text = selectedItem.LucDoc.ToString();
                txtName.Text = selectedItem.Name;
            }
        }

        public void LoadDL()
        {
            List<clsVatLieuThep> listvl = new List<clsVatLieuThep>();
            HashSet<string> tenVatLieuDaCo = new HashSet<string>();

            foreach (clsVatLieuThep vatLieuThep in clsBienToanCuc.clsVatLieu)
            {
                if (!tenVatLieuDaCo.Contains(vatLieuThep.TenVatLieu))
                {
                    tenVatLieuDaCo.Add(vatLieuThep.TenVatLieu);
                    listvl.Add(vatLieuThep);
                }
            }
            cbbVatLieu.ItemsSource = tenVatLieuDaCo;

            List<clsTietDien> listtd = new List<clsTietDien>();
            HashSet<string> tenTDDaCo = new HashSet<string>();

            foreach (clsTietDien clstietdien in clsBienToanCuc.clsTietDien)
            {
                if (!tenVatLieuDaCo.Contains(clstietdien.Name))
                {
                    tenTDDaCo.Add(clstietdien.Name);
                    listtd.Add(clstietdien);
                }
            }
            cbbTietDien.ItemsSource = tenTDDaCo;
        }
    }
}
