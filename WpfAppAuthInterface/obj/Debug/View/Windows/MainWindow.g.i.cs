﻿#pragma checksum "..\..\..\..\View\Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F755EBE6BD8A5D33F7F72C3E0D67E88D4430F124B08B616221B369682F078FBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfAppAuthInterface;


namespace WpfAppAuthInterface {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\View\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PswrdBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PswrdBoxx;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowPswrdBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignUpBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignInBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfAppAuthInterface;component/view/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PswrdBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.PswrdBoxx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ShowPswrdBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\..\..\View\Windows\MainWindow.xaml"
            this.ShowPswrdBox.Checked += new System.Windows.RoutedEventHandler(this.ShowPswrdBox_Checked);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\View\Windows\MainWindow.xaml"
            this.ShowPswrdBox.Unchecked += new System.Windows.RoutedEventHandler(this.ShowPswrdBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SignUpBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\View\Windows\MainWindow.xaml"
            this.SignUpBtn.Click += new System.Windows.RoutedEventHandler(this.SignUpBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SignInBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\View\Windows\MainWindow.xaml"
            this.SignInBtn.Click += new System.Windows.RoutedEventHandler(this.SignInBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
