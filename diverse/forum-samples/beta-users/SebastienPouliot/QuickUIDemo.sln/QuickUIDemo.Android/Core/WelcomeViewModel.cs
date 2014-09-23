using Cirrious.MvvmCross.ViewModels;

namespace QuickUIDemo.Android.Core
{
    public class WelcomeViewModel  : MvxViewModel
    {
        private string _userName;
        public string UserName 
        {   
            get { return _userName; }
            set { _userName = value; RaisePropertyChanged(() => UserName); RaisePropertyChanged(() => LoginAvailable); }
        }

        private string _password;
        public string Password 
        {   
            get { return _password; }
            set { _password = value; RaisePropertyChanged(() => Password); RaisePropertyChanged(() => LoginAvailable); }
        }

        public bool LoginAvailable
        {
            get { return !string.IsNullOrEmpty(_userName) && !string.IsNullOrEmpty(_password); }
        }

        public IMvxCommand Go
        {
            get
            {
                return new MvxCommand(() =>
                    {
                        if (!LoginAvailable)
                            return;

                        ShowViewModel<DataViewModel>();
                    });
            }
        }
    }
}