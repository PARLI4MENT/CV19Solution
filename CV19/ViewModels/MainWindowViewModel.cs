using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Title
        private string? _Title = "Analyse statistics CV19";
        /// <summary> Title </summary>
        public string Title
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

    }
}
