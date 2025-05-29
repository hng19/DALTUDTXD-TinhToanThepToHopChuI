using DALTUDTXDHONG.Class;
using DALTUDTXDHONG.Pages;
using ETABSv1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace DALTUDTXDHONG.ViewModels
{
    public class ColumnParametersVM
    {
        public ICommand cmNhapEtab { get; set; }
        public ICommand cmLuuCot { get; set; }

        public ColumnParametersVM()
        {
            cmNhapEtab = new RelayCommand<pageColumnParameters>((parameter) => true, (parameter) => LayThongTinTuEtab(parameter));
            cmLuuCot = new RelayCommand<pageColumnParameters>((parameter) => true, (parameter) => LuuCot(parameter));
        }

        public void LayThongTinTuEtab(pageColumnParameters parameter)
        {
            EtabsAPI_Ctrinhcon.DocETABSAPI_GetallFrame();
            parameter.LoadDL();
        }

        public void LuuCot(pageColumnParameters parameter)
        {
            clsTietDien clsTietDien1 = null;
            clsVatLieuThep clsVatLieuThep = null;
            foreach (clsTietDien clsTietDien in clsBienToanCuc.clsTietDien) 
            {
                if(clsTietDien.Name == parameter.cbbTietDien.Text)
                {
                    clsTietDien1= clsTietDien;
                }
            }
            foreach (clsVatLieuThep clsVatLieu in clsBienToanCuc.clsVatLieu)
            {
                if (clsVatLieu.TenVatLieu == parameter.cbbVatLieu.Text)
                {
                    clsVatLieuThep = clsVatLieu;
                }
            }

            clsBienToanCuc.clsColumn.Add
                (
                    new clsColumn(parameter.txtName.Text,
                    Convert.ToDouble(parameter.txtDaiCot.Text),
                    clsVatLieuThep,
                    clsTietDien1 ,
                    Convert.ToDouble(parameter.txtTaiTrong.Text),
                    Convert.ToDouble(parameter.txtMoMen.Text))
                );
        }
    }
}
