﻿#pragma checksum "..\..\..\View\ItemMode.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8CEEECB1B7C0B500EA7266B2621BF4390118B401"
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
    /// ItemMode
    /// </summary>
    public partial class ItemMode : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmMain;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Header;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuildMode;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProduct;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnItemPage;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsername;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserImage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\ItemMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
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
            System.Uri resourceLocater = new System.Uri("/Build it;component/view/itemmode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ItemMode.xaml"
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
            this.frmMain = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.Header = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.btnBuildMode = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\View\ItemMode.xaml"
            this.btnBuildMode.Click += new System.Windows.RoutedEventHandler(this.btnBuildMode_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\ItemMode.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnProduct = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\ItemMode.xaml"
            this.btnProduct.Click += new System.Windows.RoutedEventHandler(this.btnProduct_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnItemPage = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\ItemMode.xaml"
            this.btnItemPage.Click += new System.Windows.RoutedEventHandler(this.btnItemMode_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.UserImage = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\..\View\ItemMode.xaml"
            this.UserImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserImage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\ItemMode.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

