using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Проект.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page Welcome;
        private Page AdminCreate;
        private Page Account;
        private Page Create;
        private Page OnlineCart;
        private Page AdminProduct;        
        private Page Product;
        private Page _currentPage;
        public Page CurrentPage { get { return _currentPage; } set { _currentPage = value; RaisePropertyChanged(() => CurrentPage);  } }
        public double FrameOpacity { get; set ;}
        public MainViewModel(string login, string password)
        {
            AdminProduct = new Pages.AdminProduct(login, password);
            AdminCreate = new Pages.AdminCreate(login,password);
            Welcome = new Pages.Welcome(login, password);
            Account = new Pages.Account(login,password);
            Create = new Pages.Create(login, password);
            OnlineCart = new Pages.OnlineCart(login, password);
            Product = new Pages.Product(login,password);           
            FrameOpacity = 1;
            CurrentPage = Welcome;

        }
        public ICommand BAdminCreate_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = AdminCreate);
            }
        }
        public ICommand BAdminItems_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = AdminProduct);
            }
        }
        public ICommand BItems_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Product);
            }
        }
        public ICommand BWelcome_Click
        {

            get
            {
                return new RelayCommand(() => CurrentPage = Welcome);
            }
        }
        public ICommand BAccount_Click
        {

            get
            {
                return new RelayCommand(() => CurrentPage = Account);
            }
        }
        public ICommand BCreate_Click
        {

            get
            {
                return new RelayCommand(() => CurrentPage = Create);
            }
        }
        public ICommand BOnlineCart_Click
        {

            get
            {
                return new RelayCommand(() => CurrentPage = OnlineCart);
            }
        }    
    }
}
