﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarsInfrastructure {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CarsInfrastructure.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The &apos;Jurisdiction&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterCarRequestValidator_InvalidJurisdiction {
            get {
                return ResourceManager.GetString("RegisterCarRequestValidator_InvalidJurisdiction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Make&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterCarRequestValidator_InvalidMake {
            get {
                return ResourceManager.GetString("RegisterCarRequestValidator_InvalidMake", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Model&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterCarRequestValidator_InvalidModel {
            get {
                return ResourceManager.GetString("RegisterCarRequestValidator_InvalidModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;NumberPlate&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterCarRequestValidator_InvalidNumberPlate {
            get {
                return ResourceManager.GetString("RegisterCarRequestValidator_InvalidNumberPlate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Year&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterCarRequestValidator_InvalidYear {
            get {
                return ResourceManager.GetString("RegisterCarRequestValidator_InvalidYear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;FromUtc&apos; is either missing or in the past.
        /// </summary>
        internal static string ScheduleMaintenanceCarRequestValidator_InvalidFromUtc {
            get {
                return ResourceManager.GetString("ScheduleMaintenanceCarRequestValidator_InvalidFromUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;ToUtc&apos; is either missing, or is before the &apos;FromUtc&apos;.
        /// </summary>
        internal static string ScheduleMaintenanceCarRequestValidator_InvalidToUtc {
            get {
                return ResourceManager.GetString("ScheduleMaintenanceCarRequestValidator_InvalidToUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;ToUtc&apos; must be greater than &apos;FromUtc&apos;.
        /// </summary>
        internal static string SearchAllAvailableCarsRequestValidator_InvalidToUtc {
            get {
                return ResourceManager.GetString("SearchAllAvailableCarsRequestValidator_InvalidToUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;FromUtc&apos; is either missing or in the past.
        /// </summary>
        internal static string TakeOfflineCarRequestValidator_InvalidFromUtc {
            get {
                return ResourceManager.GetString("TakeOfflineCarRequestValidator_InvalidFromUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;ToUtc&apos; is either missing, or is before the &apos;FromUtc&apos;.
        /// </summary>
        internal static string TakeOfflineCarRequestValidator_InvalidToUtc {
            get {
                return ResourceManager.GetString("TakeOfflineCarRequestValidator_InvalidToUtc", resourceCulture);
            }
        }
    }
}
