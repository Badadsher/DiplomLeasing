﻿#pragma checksum "..\..\..\..\Pages\AdminsPage\EditLease.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D75D24F1B5E4A6F2A1D6E2382451121AD6C2314D0A66B9F33C1F31646A4BF70"
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
    /// EditLease
    /// </summary>
    public partial class EditLease : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCount;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPrice;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbAvance;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGR;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Leasing;component/pages/adminspage/editlease.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
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
            
            #line 9 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
            ((Leasing.Pages.AdminsPage.EditLease)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditLeaseClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxbCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxbPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxbAvance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 31 "..\..\..\..\Pages\AdminsPage\EditLease.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddImg);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DataGR = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.combob = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

