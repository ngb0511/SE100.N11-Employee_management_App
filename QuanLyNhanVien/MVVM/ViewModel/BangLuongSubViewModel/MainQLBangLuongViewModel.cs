using QuanLyNhanVien.Core;
using QuanLyNhanVien.MVVM.ViewModel.PhongBanSubViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.MVVM.ViewModel.BangLuongSubViewModel
{
    class MainQLBangLuongViewModel : ObservableObject
    {
        public RelayCommand LuongThuViecCommand { get; set; }
        public RelayCommand KhoiDieuHanhCommand { get; set; }

        //public RelayCommand SettingRoomStatusesViewCommand { get; set; }
        //public RelayCommand SettingRoomTypesViewCommand { get; set; }
        //public RelayCommand SettingRulesViewCommand { get; set; }

        public LuongThuViecViewModel LuongThuViecVM { get; set; }
        public KhoiDieuHanhViewModel KhoiDieuHanhVM { get; set; }

        //public SettingRoomStatusesViewModel SettingRoomStatusesVM { get; set; }
        //public SettingRoomTypesViewModel SettingRoomTypesVM { get; set; }
        //public SettingRulesViewModel SettingRulesVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainQLBangLuongViewModel()
        {
            LuongThuViecVM = new LuongThuViecViewModel();
            KhoiDieuHanhVM = new KhoiDieuHanhViewModel();

            CurrentView = LuongThuViecVM;

            LuongThuViecCommand = new RelayCommand(o =>
            {
                CurrentView = LuongThuViecVM;
            });

            KhoiDieuHanhCommand = new RelayCommand(o =>
            {
                CurrentView = KhoiDieuHanhVM;
            });


        }
    }
}