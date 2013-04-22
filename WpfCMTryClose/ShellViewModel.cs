using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace WpfCMTryClose
{
    public class ShellViewModel : Screen
    {
        public MainViewModel MainView { get; protected set; }

        public ShellViewModel()
        {
            MainView = new MainViewModel();
        }

        public void Exit()
        {
            TryClose();
        }
    }
}
