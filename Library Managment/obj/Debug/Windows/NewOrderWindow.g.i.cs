#pragma checksum "..\..\..\Windows\NewOrderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B48012ABBBADED01620884D5584BED1405667DA2C17F814A1E168EF2CDED9375"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Managment.Windows;
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


namespace Library_Managment.Windows
{


    /// <summary>
    /// NewOrder
    /// </summary>
    public partial class NewOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 16 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectCustomer;

#line default
#line hidden


#line 17 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectBooks;

#line default
#line hidden


#line 18 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveOrder;

#line default
#line hidden


#line 19 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOrderSummary;

#line default
#line hidden


#line 20 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPrice;

#line default
#line hidden


#line 21 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBookCountsSum;

#line default
#line hidden


#line 22 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBookCount;

#line default
#line hidden


#line 23 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;

#line default
#line hidden


#line 25 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;

#line default
#line hidden


#line 26 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCustomerName;

#line default
#line hidden


#line 28 "..\..\..\Windows\NewOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBooks;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library Managment;component/windows/neworderwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Windows\NewOrderWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.NewOrderWindow = ((Library_Managment.Windows.NewOrder)(target));
                    return;
                case 2:
                    this.btnSelectCustomer = ((System.Windows.Controls.Button)(target));

#line 16 "..\..\..\Windows\NewOrderWindow.xaml"
                    this.btnSelectCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnSelectCustomer_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btnSelectBooks = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\..\Windows\NewOrderWindow.xaml"
                    this.btnSelectBooks.Click += new System.Windows.RoutedEventHandler(this.BtnSelectBooks_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btnSaveOrder = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\..\Windows\NewOrderWindow.xaml"
                    this.btnSaveOrder.Click += new System.Windows.RoutedEventHandler(this.BtnSaveOrder_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.lblOrderSummary = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.lblPrice = ((System.Windows.Controls.Label)(target));
                    return;
                case 7:
                    this.lblBookCountsSum = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.lblBookCount = ((System.Windows.Controls.Label)(target));
                    return;
                case 9:
                    this.btnClose = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\..\Windows\NewOrderWindow.xaml"
                    this.btnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.textBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 11:
                    this.lblCustomerName = ((System.Windows.Controls.Label)(target));
                    return;
                case 12:
                    this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 13:
                    this.lblBooks = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window NewOrderWindow;
        internal System.Windows.Controls.DataGrid dgCustomerSelectedBook;
    }
}

