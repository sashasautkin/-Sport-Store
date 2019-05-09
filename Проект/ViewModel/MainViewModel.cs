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
        private Page Account;
        private Page Create;
        private Page OnlineCart;
        private Page Messages;
        private Page Items;
        public IUIAbstractFactory User;
        private Page _currentPage;
        public Page CurrentPage { get { return _currentPage; } set { _currentPage = value; RaisePropertyChanged(() => CurrentPage);  } }
      //  private double _frameOpacity;
        public double FrameOpacity { get; set ;}
        public MainViewModel()
        {

            Welcome = new Pages.Welcome();
            Account = new Pages.Account();
            Create = new Pages.Create();
            OnlineCart = new Pages.OnlineCart();
            Items = new Pages.Items();
           
            FrameOpacity = 1;
            CurrentPage = Welcome;

        }
     /*   public MainViewModel(IUIAbstractFactory user)
        {
            User = user;
            Welcome = new Pages.Welcome();
            Account = new Pages.Account();
            Create = new Pages.Create();
            OnlineCart = new Pages.OnlineCart();

            FrameOpacity = 1;
            CurrentPage = Welcome;

        }*/
         public ICommand BItems_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Items);
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
      
        private async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for( double i = 1.0; i> 0.0;i-=0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
                CurrentPage = page;
                for(double i = 0.0; i <1.1; i+=0.1 )
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);

                }


            });
        }


    }
}
