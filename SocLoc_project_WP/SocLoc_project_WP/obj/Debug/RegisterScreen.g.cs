﻿#pragma checksum "C:\Users\maciek\Documents\Visual Studio 2015\Projects\SocLoc_project_WP\SocLoc_project_WP\RegisterScreen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DD88551FAAE572D843934DE412924E9"
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


namespace SocLoc_project_WP {
    
    
    public partial class RegisterScreen : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.TextBox regLoginTextBox;
        
        internal System.Windows.Controls.PasswordBox regPasswdTextBox;
        
        internal System.Windows.Controls.Button regInButton;
        
        internal System.Windows.Controls.TextBlock infoTextBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SocLoc_project_WP;component/RegisterScreen.xaml", System.UriKind.Relative));
            this.regLoginTextBox = ((System.Windows.Controls.TextBox)(this.FindName("regLoginTextBox")));
            this.regPasswdTextBox = ((System.Windows.Controls.PasswordBox)(this.FindName("regPasswdTextBox")));
            this.regInButton = ((System.Windows.Controls.Button)(this.FindName("regInButton")));
            this.infoTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("infoTextBlock")));
        }
    }
}

