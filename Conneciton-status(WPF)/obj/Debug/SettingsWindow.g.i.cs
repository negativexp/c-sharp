﻿#pragma checksum "..\..\SettingsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D5D45BDAC38770F2EF47E00B3EAE8503E746E9A88C136638F005F695ECA7C91"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using Conneciton_status_WPF_;
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


namespace Conneciton_status_WPF_ {
    
    
    /// <summary>
    /// SettingsWindow
    /// </summary>
    public partial class SettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonResumePing1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPausePing1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPingHost;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxInterval;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderWindowOpacity;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderPosX;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderPosY;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxAllignToTaskBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Conneciton-status(WPF);component/settingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SettingsWindow.xaml"
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
            
            #line 10 "..\..\SettingsWindow.xaml"
            ((Conneciton_status_WPF_.SettingsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.SettingsWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonClose1 = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\SettingsWindow.xaml"
            this.ButtonClose1.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonSave1 = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\SettingsWindow.xaml"
            this.ButtonSave1.Click += new System.Windows.RoutedEventHandler(this.ButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonResumePing1 = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\SettingsWindow.xaml"
            this.ButtonResumePing1.Click += new System.Windows.RoutedEventHandler(this.ButtonResumePing_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonPausePing1 = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\SettingsWindow.xaml"
            this.ButtonPausePing1.Click += new System.Windows.RoutedEventHandler(this.ButtonPausePing_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxPingHost = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\SettingsWindow.xaml"
            this.TextBoxPingHost.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxPingHost_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextBoxInterval = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\SettingsWindow.xaml"
            this.TextBoxInterval.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxInterval_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SliderWindowOpacity = ((System.Windows.Controls.Slider)(target));
            
            #line 44 "..\..\SettingsWindow.xaml"
            this.SliderWindowOpacity.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderWindowOpacity_Changed);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SliderPosX = ((System.Windows.Controls.Slider)(target));
            
            #line 48 "..\..\SettingsWindow.xaml"
            this.SliderPosX.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderPosX_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SliderPosY = ((System.Windows.Controls.Slider)(target));
            
            #line 49 "..\..\SettingsWindow.xaml"
            this.SliderPosY.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderPosY_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 54 "..\..\SettingsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonX_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 62 "..\..\SettingsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CheckBoxAllignToTaskBar = ((System.Windows.Controls.CheckBox)(target));
            
            #line 70 "..\..\SettingsWindow.xaml"
            this.CheckBoxAllignToTaskBar.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxAllignToTaskBar_Checked);
            
            #line default
            #line hidden
            
            #line 70 "..\..\SettingsWindow.xaml"
            this.CheckBoxAllignToTaskBar.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxAllignToTaskBar_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
