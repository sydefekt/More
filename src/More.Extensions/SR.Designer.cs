﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace More {
    using System;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("More.SR", typeof(SR).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is abstract.  Abstract types are not supported in this context..
        /// </summary>
        internal static string AbstractNotSupported {
            get {
                return ResourceManager.GetString("AbstractNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; on type &apos;{1}&apos; must be static..
        /// </summary>
        internal static string ExpectedStaticMethod {
            get {
                return ResourceManager.GetString("ExpectedStaticMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&quot; is a generic type definition.  Generic type definitions are not supported in this context..
        /// </summary>
        internal static string GenericTypeDefNotSupported {
            get {
                return ResourceManager.GetString("GenericTypeDefNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is an interface.  Interface types are not supported in this context..
        /// </summary>
        internal static string InterfaceNotSupported {
            get {
                return ResourceManager.GetString("InterfaceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter must be an instance of type &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidArgType {
            get {
                return ResourceManager.GetString("InvalidArgType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only the file:// URI scheme is supported..
        /// </summary>
        internal static string InvalidFileUri {
            get {
                return ResourceManager.GetString("InvalidFileUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; property is read-only..
        /// </summary>
        internal static string PropertyIsReadOnly {
            get {
                return ResourceManager.GetString("PropertyIsReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied type &apos;{0}&apos; does not have the required constructor definition. ({1})..
        /// </summary>
        internal static string RequiredConstructorMissing {
            get {
                return ResourceManager.GetString("RequiredConstructorMissing", resourceCulture);
            }
        }
    }
}