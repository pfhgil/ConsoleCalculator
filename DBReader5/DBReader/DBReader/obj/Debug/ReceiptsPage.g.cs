﻿#pragma checksum "..\..\ReceiptsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F6B7E9F1F756A916910E5EF442E9D8FC45A791882450E316F9149D1DAA27126"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DBReader;
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


namespace DBReader {
    
    
    /// <summary>
    /// ReceiptsPage
    /// </summary>
    public partial class ReceiptsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\ReceiptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableDataGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ReceiptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextTableButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ReceiptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousTableButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ReceiptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateRecordButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ReceiptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditRecordButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ReceiptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteRecord;
        
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
            System.Uri resourceLocater = new System.Uri("/DBReader;component/receiptspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReceiptsPage.xaml"
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
            this.TableDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.NextTableButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ReceiptsPage.xaml"
            this.NextTableButton.Click += new System.Windows.RoutedEventHandler(this.NextTableButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PreviousTableButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ReceiptsPage.xaml"
            this.PreviousTableButton.Click += new System.Windows.RoutedEventHandler(this.PreviousTableButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CreateRecordButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ReceiptsPage.xaml"
            this.CreateRecordButton.Click += new System.Windows.RoutedEventHandler(this.CreateRecordButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditRecordButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\ReceiptsPage.xaml"
            this.EditRecordButton.Click += new System.Windows.RoutedEventHandler(this.EditRecordButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteRecord = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ReceiptsPage.xaml"
            this.DeleteRecord.Click += new System.Windows.RoutedEventHandler(this.DeleteRecordButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

