﻿#pragma checksum "C:\Aptech\SEM3\T2010A_UWP\T2010A_UWP\T2010A_UWP\Pages\Categories.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F9F49034838EC85BD8393A218EC113D21263C859D8BB32003A24E45A4000EE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T2010A_UWP.Pages
{
    partial class Categories : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Media_Imaging_BitmapImage_UriSource(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.UriSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Categories_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICategories_Bindings
        {
            private global::T2010A_UWP.Models.Entity.Food dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8UriSourceDisabled = false;

            public Categories_obj5_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 23 && columnNumber == 36)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 24 && columnNumber == 36)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 20 && columnNumber == 46)
                {
                    isobj8UriSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Pages\Categories.xaml line 17
                        this.obj5 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 6: // Pages\Categories.xaml line 23
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // Pages\Categories.xaml line 24
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // Pages\Categories.xaml line 20
                        this.obj8 = (global::Windows.UI.Xaml.Media.Imaging.BitmapImage)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj5.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::T2010A_UWP.Models.Entity.Food) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ICategories_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::T2010A_UWP.Models.Entity.Food)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::T2010A_UWP.Models.Entity.Food obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_name(obj.name, phase);
                        this.Update_price(obj.price, phase);
                        this.Update_image(obj.image, phase);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Categories.xaml line 23
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_price(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Categories.xaml line 24
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                    }
                }
            }
            private void Update_image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Categories.xaml line 20
                    if (!isobj8UriSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_Imaging_BitmapImage_UriSource(this.obj8, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Categories.xaml line 13
                {
                    this.CategoryName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Pages\Categories.xaml line 14
                {
                    this.Products = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 5: // Pages\Categories.xaml line 17
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element5 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    Categories_obj5_Bindings bindings = new Categories_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element5, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

