﻿#pragma checksum "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F8C05A7F4CE5B2F5A8911BEFF8C519577AB5DDD9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestImmo.Views.GererPret.Forms;
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


namespace GestImmo.Views.GererPret.Forms {
    
    
    /// <summary>
    /// GererPretForm
    /// </summary>
    public partial class GererPretForm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BienPret_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ApportPret_TextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MensualitePret_TextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DureePret_TextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_BienPret;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_ApportPret;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_MensualitePret;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_DureePret;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bouton_Ajouter_Pret;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestImmo;component/views/gererpret/forms/gererpretform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BienPret_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
            this.BienPret_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BienPret_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ApportPret_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
            this.ApportPret_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ApportPret_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MensualitePret_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
            this.MensualitePret_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MensualitePret_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DureePret_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
            this.DureePret_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.DureePret_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Lbl_BienPret = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Lbl_ApportPret = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Lbl_MensualitePret = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Lbl_DureePret = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Bouton_Ajouter_Pret = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\..\..\Views\GererPret\Forms\GererPretForm.xaml"
            this.Bouton_Ajouter_Pret.Click += new System.Windows.RoutedEventHandler(this.Bouton_Ajouter_Pret_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

