#pragma checksum "..\..\..\..\..\..\Pages\Admin\SeeAndEditInfoAboutSign\EditInfoAboutSignPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5B8754FCF481ECE9EBAA41D9C2A5D5497D5C5C32"
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


namespace ZodiacSignProject.Pages.Admin.SeeAndEditInfoAboutSign {
    
    
    /// <summary>
    /// EditInfoAboutSignPage
    /// </summary>
    public partial class EditInfoAboutSignPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\..\Pages\Admin\SeeAndEditInfoAboutSign\EditInfoAboutSignPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameSign;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\..\Pages\Admin\SeeAndEditInfoAboutSign\EditInfoAboutSignPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InfoSign;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\..\Pages\Admin\SeeAndEditInfoAboutSign\EditInfoAboutSignPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditDataBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/ZodiacSignProject;component/pages/admin/seeandeditinfoaboutsign/editinfoaboutsig" +
                    "npage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Pages\Admin\SeeAndEditInfoAboutSign\EditInfoAboutSignPage.xaml"
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
            this.NameSign = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.InfoSign = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EditDataBtn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\..\..\..\Pages\Admin\SeeAndEditInfoAboutSign\EditInfoAboutSignPage.xaml"
            this.EditDataBtn.Click += new System.Windows.RoutedEventHandler(this.EditDataBtn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

