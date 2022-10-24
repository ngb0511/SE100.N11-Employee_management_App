using QuanLyNhanVien.Core;
using QuanLyNhanVien.MVVM.ViewModel.BangLuongSubViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.MVVM.ViewModel.HeThongSubViewModel
{
    class MainQLHeThongViewModel : ObservableObject
    {
        public RelayCommand TaiKhoanCommand { get; set; }
        public RelayCommand ThamSoCommand { get; set; }

        //public RelayCommand SettingRoomStatusesViewCommand { get; set; }
        //public RelayCommand SettingRoomTypesViewCommand { get; set; }
        //public RelayCommand SettingRulesViewCommand { get; set; }

        public TaiKhoanViewModel TaiKhoanVM { get; set; }
        public ThamSoViewModel ThamSoVM { get; set; }

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

        public MainQLHeThongViewModel()
        {
            TaiKhoanVM = new TaiKhoanViewModel();
            ThamSoVM = new ThamSoViewModel();

            CurrentView = TaiKhoanVM;

            TaiKhoanCommand = new RelayCommand(o =>
            {
                CurrentView = TaiKhoanVM;
            });

            ThamSoCommand = new RelayCommand(o =>
            {
                CurrentView = ThamSoVM;
            });


        }
    }
}
