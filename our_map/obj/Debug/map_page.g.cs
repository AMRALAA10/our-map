﻿

#pragma checksum "D:\projects\visual studio 2013\windows phone contest\handasa-map-master\handasa-map-master\our_map\map_page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CEB65A35A784F08F8D976D24D4EE6A2D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace our_map
{
    partial class map_page : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 11 "..\..\map_page.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.loselost_Completed;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 1065 "..\..\map_page.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 973 "..\..\map_page.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.goWhere_TextChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 974 "..\..\map_page.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Image_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

