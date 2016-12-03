﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.CommandWpf;

namespace ParticleEditor.ViewModels
{
    public class HelpWindowViewModel
    {
        public RelayCommand<Window> CloseWindowCommand
        {
            get { return new RelayCommand<Window>(CloseWindow);}
        }

        private void CloseWindow(Window window)
        {
            if(window != null)
                window.Close();
        }

        public RelayCommand<string> HyperLinkRequestCommand
        {
            get { return new RelayCommand<string>(HyperlinkRequest); }
        }
        private void HyperlinkRequest(string link)
        {
            Process.Start(new ProcessStartInfo(link));
        }
    }
}