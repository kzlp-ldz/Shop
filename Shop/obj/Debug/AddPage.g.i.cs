﻿#pragma checksum "..\..\AddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C212C0C54C044593B943B13E517A8436FECA4F9BEF68737E1CB5FEB4E58C031"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Shop;
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


namespace Shop {
    
    
    /// <summary>
    /// AddPage
    /// </summary>
    public partial class AddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_name;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_full;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_unit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_photo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_photo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_country;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_country;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_country;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_addCountry;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delCountry;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;
        
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
            System.Uri resourceLocater = new System.Uri("/Shop;component/addpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddPage.xaml"
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
            this.tbx_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbx_full = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cbx_unit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.btn_photo = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddPage.xaml"
            this.btn_photo.Click += new System.Windows.RoutedEventHandler(this.btn_photo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.img_photo = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.lb_country = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lv_country = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.cbx_country = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.btn_addCountry = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\AddPage.xaml"
            this.btn_addCountry.Click += new System.Windows.RoutedEventHandler(this.btn_addCountry_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_delCountry = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\AddPage.xaml"
            this.btn_delCountry.Click += new System.Windows.RoutedEventHandler(this.btn_delCountry_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_save = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\AddPage.xaml"
            this.btn_save.Click += new System.Windows.RoutedEventHandler(this.btn_save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

