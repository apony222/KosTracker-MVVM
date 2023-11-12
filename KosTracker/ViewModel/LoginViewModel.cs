using GalaSoft.MvvmLight.Command;
using KosTracker.Core;
using KosTracker.Data;
using KosTracker.Data.SqlOperations;
using KosTracker.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace KosTracker.ViewModel
{
    abstract class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private readonly IDataHelper<User> dataHelper;
        private ObservableCollection<User> users;
        bool isLoggedIn=false;

        ICommand LoginCommand {  get; }
        
        public LoginViewModel()
        {
            dataHelper = new UserEntity();
            users = new ObservableCollection<User>();
            LoadData();
            //LoginCommand = new RelayCommand();
        }

        private async void LoadData()
        {
            users.Clear();
            foreach (User user in await dataHelper.GetAllAsync())
            {
                users.Add(user);
            }
        }

       /* private async bool Login(string UserName, string Password)
        {
            
            LoadData();
            foreach (User user in await dataHelper.GetAllAsync())
            {
                if(user.UserName.Equals(UserName)&&user.Password.Equals(Password))
                {
                    isLoggedIn = true;   
                }
            }
            return isLoggedIn;
        }*/
    }
}
