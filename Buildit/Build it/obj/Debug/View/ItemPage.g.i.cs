﻿#pragma checksum "..\..\..\View\ItemPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CD0827F0406A3FE4A6D6C865F2E048B7B939785B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Build_it.View {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spMenu;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel Menu_Navigasi;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProduct;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmMain;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsername;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserImage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuildMode;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnItemPage;
        
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
            System.Uri resourceLocater = new System.Uri("/Build it;component/view/itempage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ItemPage.xaml"
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
            this.spMenu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Menu_Navigasi = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\View\ItemPage.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnBuild_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnProduct = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\View\ItemPage.xaml"
            this.btnProduct.Click += new System.Windows.RoutedEventHandler(this.btnComponent_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frmMain = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.lblUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.UserImage = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\View\ItemPage.xaml"
            this.UserImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserImage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnBuildMode = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\View\ItemPage.xaml"
            this.btnBuildMode.Click += new System.Windows.RoutedEventHandler(this.btnCompare_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnItemPage = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\View\ItemPage.xaml"
            this.btnItemPage.Click += new System.Windows.RoutedEventHandler(this.btnCompare_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

