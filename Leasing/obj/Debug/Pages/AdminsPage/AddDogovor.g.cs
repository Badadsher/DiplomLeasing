﻿#pragma checksum "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EE9E8AA9C3A7F6AFABCBD7C1A9127FE10F7787A4FADC510000DE06E88027A20A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Leasing.Pages.AdminsPage;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Leasing.Pages.AdminsPage {
    
    
    /// <summary>
    /// AddDogovor
    /// </summary>
    public partial class AddDogovor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbClient;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datestart;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateend;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CarId;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combob;
        
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
            System.Uri resourceLocater = new System.Uri("/Leasing;component/pages/adminspage/adddogovor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
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
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxbClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 21 "..\..\..\..\Pages\AdminsPage\AddDogovor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddDogovorClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datestart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.dateend = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.CarId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.combob = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

