using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DependencyCustomInXamarnFroms.ViewModels
{
    public class EntryViewModel
    {
        public ICommand DigiCommand { get; }
        public string Text { get; set; }
        public string TextUser { get; set; }
        public EntryViewModel()
        {
            DigiCommand = new DelegateCommand(() => Change());
        }
        public void Change()
        {
            if (!String.IsNullOrEmpty(Text))
            {
                TextUser = Text;
            }
            else
            {
                TextUser = "No ha ingresado texto";
            }
        }
    }
}
