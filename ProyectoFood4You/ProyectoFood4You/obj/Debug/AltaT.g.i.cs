﻿#pragma checksum "..\..\AltaT.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BECE15C6D56070F1A3A22EE847EFEA993863BB9E5901CA0A24DE6B021190E775"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoFood4You;
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


namespace ProyectoFood4You {
    
    
    /// <summary>
    /// AltaT
    /// </summary>
    public partial class AltaT : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AltaT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlaca;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AltaT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCapacidad;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AltaT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAltaT;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AltaT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btRegresar1;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoFood4You;component/altat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AltaT.xaml"
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
            this.txtPlaca = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\AltaT.xaml"
            this.txtPlaca.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPlaca_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCapacidad = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\AltaT.xaml"
            this.txtCapacidad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btAltaT = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AltaT.xaml"
            this.btAltaT.Click += new System.Windows.RoutedEventHandler(this.btAltaT_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btRegresar1 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AltaT.xaml"
            this.btRegresar1.Click += new System.Windows.RoutedEventHandler(this.btRegresar1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

