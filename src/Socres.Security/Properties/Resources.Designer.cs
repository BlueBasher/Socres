﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Socres.Security.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Socres.Security.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum length is bigger than maximum length..
        /// </summary>
        internal static string PasswordGenerator_MinimumLength_Bigger_Maximum_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_MinimumLength_Bigger_Maximum_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum password length is too small..
        /// </summary>
        internal static string PasswordGenerator_Minimumlength_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_Minimumlength_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum passowrd length is smaller than sum of characters..
        /// </summary>
        internal static string PasswordGenerator_MinimumLength_SmallerThanSum_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_MinimumLength_SmallerThanSum_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum length fo lowercase characters is too small..
        /// </summary>
        internal static string PasswordGenerator_MinimumLowerCase_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_MinimumLowerCase_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum length fo numeric characters is too small..
        /// </summary>
        internal static string PasswordGenerator_MinimumNumeric_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_MinimumNumeric_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum length fo special characters is too small..
        /// </summary>
        internal static string PasswordGenerator_MinimumSpecial_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_MinimumSpecial_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum length fo uppercase characters is too small..
        /// </summary>
        internal static string PasswordGenerator_MinimumUpperCase_Error {
            get {
                return ResourceManager.GetString("PasswordGenerator_MinimumUpperCase_Error", resourceCulture);
            }
        }
    }
}
