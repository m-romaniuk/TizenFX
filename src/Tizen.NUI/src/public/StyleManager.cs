//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI
{

    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// StyleManager informs applications of system theme change, and supports application theme change at runtime.<br>
    /// Applies various styles to Controls using the properties system.<br>
    /// On theme change, it automatically updates all controls, then raises a event to inform the application.<br>
    /// If the application wants to customize the theme, RequestThemeChange needs to be called.<br>
    /// It provides the path to the  application resource root folder, from there the filename can an be specified along with any sub folders, e.g Images, Models etc.<br>
    /// </summary>
    public class StyleManager : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal StyleManager(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.StyleManager_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StyleManager obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~StyleManager()
        {
            DisposeQueue.Instance.Add(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public override void Dispose()
        {
            if (!Stage.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_StyleManager(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        /// <summary>
        /// Style changed event arguments
        /// </summary>
        public class StyleChangedEventArgs : EventArgs
        {
            private StyleManager _styleManager;
            private StyleChangeType _styleChange;

            /// <summary>
            /// StyleManager.
            /// </summary>
            public StyleManager StyleManager
            {
                get
                {
                    return _styleManager;
                }
                set
                {
                    _styleManager = value;
                }
            }

            /// <summary>
            /// StyleChange - contains Style change information (default font changed or
            /// default font size changed or theme has changed).<br>
            /// </summary>
            public StyleChangeType StyleChange
            {
                get
                {
                    return _styleChange;
                }
                set
                {
                    _styleChange = value;
                }
            }

        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void StyleChangedCallbackDelegate(IntPtr styleManager, Tizen.NUI.StyleChangeType styleChange);
        private EventHandler<StyleChangedEventArgs> _styleManagerStyleChangedEventHandler;
        private StyleChangedCallbackDelegate _styleManagerStyleChangedCallbackDelegate;

        /// <summary>
        /// Event for StyleChanged signal which can be used to subscribe/unsubscribe the
        /// event handler provided by the user.<br>
        /// StyleChanged signal is is emitted after the style (e.g. theme/font change) has changed
        /// and the controls have been informed.<br>
        /// </summary>
        public event EventHandler<StyleChangedEventArgs> StyleChanged
        {
            add
            {
                if (_styleManagerStyleChangedEventHandler == null)
                {
                    _styleManagerStyleChangedCallbackDelegate = (OnStyleChanged);
                    StyleChangedSignal().Connect(_styleManagerStyleChangedCallbackDelegate);
                }
                _styleManagerStyleChangedEventHandler += value;
            }
            remove
            {
                _styleManagerStyleChangedEventHandler -= value;
                if (_styleManagerStyleChangedEventHandler == null && StyleChangedSignal().Empty() == false)
                {
                    StyleChangedSignal().Disconnect(_styleManagerStyleChangedCallbackDelegate);
                }
            }
        }

        // Callback for StyleManager StyleChangedsignal
        private void OnStyleChanged(IntPtr styleManager, StyleChangeType styleChange)
        {
            StyleChangedEventArgs e = new StyleChangedEventArgs();

            // Populate all members of "e" (StyleChangedEventArgs) with real data
            e.StyleManager = StyleManager.GetStyleManagerFromPtr(styleManager);
            e.StyleChange = styleChange;

            if (_styleManagerStyleChangedEventHandler != null)
            {
                //here we send all data to user event handlers
                _styleManagerStyleChangedEventHandler(this, e);
            }
        }

        internal static StyleManager GetStyleManagerFromPtr(global::System.IntPtr cPtr)
        {
            StyleManager ret = new StyleManager(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Creates a StyleManager handle.<br>
        /// this can be initialized with StyleManager::Get().<br>
        /// </summary>
        public StyleManager() : this(NDalicPINVOKE.new_StyleManager(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the singleton of StyleManager object.
        /// </summary>
        /// <returns>A handle to the StyleManager control</returns>
        public static StyleManager Get()
        {
            StyleManager ret = new StyleManager(NDalicPINVOKE.StyleManager_Get(), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Applies a new theme to the application. <br>
        /// This will be merged on top of the default Toolkit theme.<br>
        /// If the application theme file doesn't style all controls that the
        /// application uses, then the default Toolkit theme will be used
        /// instead for those controls.<br>
        /// </summary>
        /// <param name="themeFile">A relative path is specified for style theme</param>
        public void ApplyTheme(string themeFile)
        {
            NDalicPINVOKE.StyleManager_ApplyTheme(swigCPtr, themeFile);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Applies the default Toolkit theme.
        /// </summary>
        public void ApplyDefaultTheme()
        {
            NDalicPINVOKE.StyleManager_ApplyDefaultTheme(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Sets a constant for use when building styles.
        /// </summary>
        /// <param name="key">The key of the constant</param>
        /// <param name="value">The value of the constant</param>
        public void SetStyleConstant(string key, PropertyValue value)
        {
            NDalicPINVOKE.StyleManager_SetStyleConstant(swigCPtr, key, PropertyValue.getCPtr(value));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Returns the style constant set for a specific key.
        /// </summary>
        /// <param name="key">The key of the constant</param>
        /// <param name="valueOut">The value of the constant if it exists</param>
        /// <returns></returns>
        public bool GetStyleConstant(string key, PropertyValue valueOut)
        {
            bool ret = NDalicPINVOKE.StyleManager_GetStyleConstant(swigCPtr, key, PropertyValue.getCPtr(valueOut));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Applies the specified style to the control.
        /// </summary>
        /// <param name="control">The control to which to apply the style</param>
        /// <param name="jsonFileName">The name of the JSON style file to apply</param>
        /// <param name="styleName">The name of the style within the JSON file to apply</param>
        public void ApplyStyle(View control, string jsonFileName, string styleName)
        {
            NDalicPINVOKE.StyleManager_ApplyStyle(swigCPtr, View.getCPtr(control), jsonFileName, styleName);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal StyleChangedSignal StyleChangedSignal()
        {
            StyleChangedSignal ret = new StyleChangedSignal(NDalicPINVOKE.StyleManager_StyleChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

    }

    /// <summary>
    /// Types of style change. Enumeration for StyleChange type.
    /// </summary>
    public enum StyleChangeType
    {
        /// <summary>
        /// Denotes that the default font has changed.
        /// </summary>
        DefaultFontChange,
        /// <summary>
        /// Denotes that the default font size has changed.
        /// </summary>
        DefaultFontSizeChange,
        /// <summary>
        /// Denotes that the theme has changed.
        /// </summary>
        ThemeChange
    }

}
