using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title : string - Заголовок главного окна
        private string? _Title = "Analyse statistics CV19";
        /// <summary> Title </summary>
        public string? Title
        {
            //get { return _Title; }
            get => _Title;

            //set
            //{
            // Variant 1
            //    //if (Equals(_Title, value))
            //    //    return;
            //    //_Title = value;
            //    //OnPropertyChanged();
            //  Variant 2
            //    //Set(ref _Title, value);

            //}

            // Variant 3
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status : string - статус программы
        private string? _Status = "Done!";
        public string? Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region Commands
        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecute(object obj)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object obj) => true;
        #endregion
        #endregion
        public MainWindowViewModel()
        {
            #region Commands
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
