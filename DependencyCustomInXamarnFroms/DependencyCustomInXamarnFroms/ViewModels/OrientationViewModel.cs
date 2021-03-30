using DependencyCustomInXamarnFroms.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DependencyCustomInXamarnFroms.ViewModels
{
    public class OrientationViewModel
    {
        public ICommand OrientationCommand { get; }

        public string Text { get; set; }
       

        public IDeviceOrientationService orientationService;
        public OrientationViewModel(IDeviceOrientationService deviceOrientation)
        {
            orientationService = deviceOrientation;
            OrientationCommand = new DelegateCommand(() => deviceOrientation.GetOrientation());
            Text = deviceOrientation.GetOrientation().ToString();
        }

    }
}
