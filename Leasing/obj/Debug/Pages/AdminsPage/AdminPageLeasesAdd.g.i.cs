﻿#pragma checksum "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "696430671224A10D825AD6F20553B50BE7BCD5F1588D265A7D3E4FE258F0609A"
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
    /// AdminPageLeasesAdd
    /// </summary>
    public partial class AdminPageLeasesAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card MainCard;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitToAuth;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RenderPages;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl CardContainer;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border DarkOverlay;
        
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
            System.Uri resourceLocater = new System.Uri("/Leasing;component/pages/adminspage/adminpageleasesadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
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
            
            #line 10 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((Leasing.Pages.AdminsPage.AdminPageLeasesAdd)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainCard = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 3:
            
            #line 34 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UsersClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 43 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DogovorClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitToAuth = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            this.ExitToAuth.Click += new System.Windows.RoutedEventHandler(this.ExitToAuthClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RenderPages = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CardContainer = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 10:
            
            #line 120 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditLease);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 121 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCar);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 122 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 13:
            this.DarkOverlay = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 104 "..\..\..\..\Pages\AdminsPage\AdminPageLeasesAdd.xaml"
            ((System.Windows.Controls.Border)(target)).MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OpenCarCard);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

