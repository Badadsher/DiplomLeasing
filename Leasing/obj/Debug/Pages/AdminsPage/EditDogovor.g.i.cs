﻿#pragma checksum "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4EF1313C035D64AA0367AB841C159BE1ADC77C4BA0D2D6F8346B8735236ED28"
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
    /// EditDogovor
    /// </summary>
    public partial class EditDogovor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGR;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbClient;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbStatus;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datestart;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateend;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCarID;
        
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
            System.Uri resourceLocater = new System.Uri("/Leasing;component/pages/adminspage/editdogovor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
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
            
            #line 9 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
            ((Leasing.Pages.AdminsPage.EditDogovor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\..\..\Pages\AdminsPage\EditDogovor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditDogovorClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGR = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.TxbClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxbStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.datestart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.dateend = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.TxbCarID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

