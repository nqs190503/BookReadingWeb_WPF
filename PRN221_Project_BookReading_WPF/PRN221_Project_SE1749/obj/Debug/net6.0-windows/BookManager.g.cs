﻿#pragma checksum "..\..\..\BookManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "586D13138521CA636E5E60D936424C7F5F0D6601"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PRN221_Project_SE1749;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PRN221_Project_SE1749 {
    
    
    /// <summary>
    /// BookManager
    /// </summary>
    public partial class BookManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\BookManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\BookManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbApprove;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\BookManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BooksDataGrid;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\BookManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendFeedBackButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRN221_Project_SE1749;component/bookmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\BookManager.xaml"
            ((PRN221_Project_SE1749.BookManager)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 30 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbApprove = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\BookManager.xaml"
            this.cbApprove.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbApprove_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BooksDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            
            #line 126 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 127 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 128 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApprovedButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 129 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RejectButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 130 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadBooksButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 135 "..\..\..\BookManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ManageAccountsButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SendFeedBackButton = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\BookManager.xaml"
            this.SendFeedBackButton.Click += new System.Windows.RoutedEventHandler(this.SendFeedBackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

