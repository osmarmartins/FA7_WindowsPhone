﻿#pragma checksum "C:\Users\1581444\Documents\Visual Studio 2015\Projects\DPP-I\AULA02\Canvas\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EEE5E597B4694FD78EF2FFC504BE21F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ExercicioCanvas {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Canvas cc;
        
        internal System.Windows.Controls.Button btAmarelo;
        
        internal System.Windows.Controls.Button btAzul;
        
        internal System.Windows.Controls.Button btBranco;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Canvas;component/MainPage.xaml", System.UriKind.Relative));
            this.cc = ((System.Windows.Controls.Canvas)(this.FindName("cc")));
            this.btAmarelo = ((System.Windows.Controls.Button)(this.FindName("btAmarelo")));
            this.btAzul = ((System.Windows.Controls.Button)(this.FindName("btAzul")));
            this.btBranco = ((System.Windows.Controls.Button)(this.FindName("btBranco")));
        }
    }
}

