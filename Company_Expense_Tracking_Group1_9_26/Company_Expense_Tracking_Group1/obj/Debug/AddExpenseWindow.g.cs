﻿#pragma checksum "..\..\AddExpenseWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D9EBA5018DF00C3688A04E6E5382D22"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace Company_Expense_Tracking_Group1 {
    
    
    /// <summary>
    /// AddExpenseWindow
    /// </summary>
    public partial class AddExpenseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Company_Expense_Tracking_Group1.AddExpenseWindow AddExpenseWindow1;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Category_Label;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Amount_Input_TextBox;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Amount_Input_Label;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Date_Input_Label_Copy;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Date_Input_TextBox_Copy;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Expense_Button;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Veiw_Expense_Button;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddExpenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Date_Time;
        
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
            System.Uri resourceLocater = new System.Uri("/Company_Expense_Tracking_Group1;component/addexpensewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddExpenseWindow.xaml"
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
            this.AddExpenseWindow1 = ((Company_Expense_Tracking_Group1.AddExpenseWindow)(target));
            return;
            case 2:
            this.Category_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Amount_Input_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Amount_Input_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Date_Input_Label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Date_Input_TextBox_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Add_Expense_Button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AddExpenseWindow.xaml"
            this.Add_Expense_Button.Click += new System.Windows.RoutedEventHandler(this.Add_Expense_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Veiw_Expense_Button = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AddExpenseWindow.xaml"
            this.Veiw_Expense_Button.Click += new System.Windows.RoutedEventHandler(this.Veiw_Expense_Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Date_Time = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

