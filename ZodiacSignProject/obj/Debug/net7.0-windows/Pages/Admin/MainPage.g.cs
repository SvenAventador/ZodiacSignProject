﻿#pragma checksum "..\..\..\..\..\Pages\Admin\MainPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEEA4C60777DF89961C0029782F64975BDD9754C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using ZodiacSignProject.Pages.Admin;


namespace ZodiacSignProject.Pages.Admin {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 122 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LookOrder;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditInfoAboutSignBtn;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditProfileBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZodiacSignProject;component/pages/admin/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LookOrder = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.LookOrder.Click += new System.Windows.RoutedEventHandler(this.LookOrder_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditInfoAboutSignBtn = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.EditInfoAboutSignBtn.Click += new System.Windows.RoutedEventHandler(this.EditInfoAboutSignBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditProfileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.EditProfileBtn.Click += new System.Windows.RoutedEventHandler(this.EditProfileBtn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

