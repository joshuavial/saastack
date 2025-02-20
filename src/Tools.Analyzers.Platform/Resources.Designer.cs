﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tools.Analyzers.Platform {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tools.Analyzers.Platform.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to This type should have a &lt;summary&gt; to describe what it designed to do..
        /// </summary>
        internal static string SAS001Description {
            get {
                return ResourceManager.GetString("SAS001Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; requires a documentation &lt;summary/&gt;.
        /// </summary>
        internal static string SAS001MessageFormat {
            get {
                return ResourceManager.GetString("SAS001MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing documentation.
        /// </summary>
        internal static string SAS001Title {
            get {
                return ResourceManager.GetString("SAS001Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method should have a &lt;summary&gt; to describe what it designed to do..
        /// </summary>
        internal static string SAS002Description {
            get {
                return ResourceManager.GetString("SAS002Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension method &apos;{0}&apos; requires a documentation &lt;summary/&gt;.
        /// </summary>
        internal static string SAS002MessageFormat {
            get {
                return ResourceManager.GetString("SAS002MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing documentation.
        /// </summary>
        internal static string SAS002Title {
            get {
                return ResourceManager.GetString("SAS002Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method should return a Result type..
        /// </summary>
        internal static string SAS010Description {
            get {
                return ResourceManager.GetString("SAS010Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If method &apos;{0}&apos; is supposed to be a service operation, then it should return one of these possible types: &apos;{1}&apos;.
        /// </summary>
        internal static string SAS010MessageFormat {
            get {
                return ResourceManager.GetString("SAS010MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong return type.
        /// </summary>
        internal static string SAS010Title {
            get {
                return ResourceManager.GetString("SAS010Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service operation should have at least one parameter, and that parameter should be derived from: &apos;IWebRequest&lt;TResponse&gt;&apos;..
        /// </summary>
        internal static string SAS011Description {
            get {
                return ResourceManager.GetString("SAS011Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service operation &apos;{0}&apos; should have at least one parameter of a type derived from; &apos;IWebRequest&lt;TResponse&gt;&apos;.
        /// </summary>
        internal static string SAS011MessageFormat {
            get {
                return ResourceManager.GetString("SAS011MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing first parameter or wrong parameter type.
        /// </summary>
        internal static string SAS011Title {
            get {
                return ResourceManager.GetString("SAS011Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service operation can only have a &apos;CancellationToken&apos; as its second parameter..
        /// </summary>
        internal static string SAS012Description {
            get {
                return ResourceManager.GetString("SAS012Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service operation &apos;{0}&apos; can only have a &apos;CancellationToken&apos; as its second parameter.
        /// </summary>
        internal static string SAS012MessageFormat {
            get {
                return ResourceManager.GetString("SAS012MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong second parameter type.
        /// </summary>
        internal static string SAS012Title {
            get {
                return ResourceManager.GetString("SAS012Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request type for this service operation should be declared with a &apos;RouteAttribute&apos; on it..
        /// </summary>
        internal static string SAS013Description {
            get {
                return ResourceManager.GetString("SAS013Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service operation &apos;{0}&apos; has a request type that does not have a &apos;RouteAttribute&apos; on it.
        /// </summary>
        internal static string SAS013MessageFormat {
            get {
                return ResourceManager.GetString("SAS013MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing &apos;RouteAttribute&apos; on request type.
        /// </summary>
        internal static string SAS013Title {
            get {
                return ResourceManager.GetString("SAS013Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service operation has a route declared on its request that is different from other service operations in this class..
        /// </summary>
        internal static string SAS014Description {
            get {
                return ResourceManager.GetString("SAS014Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service operation &apos;{0}&apos; is required to have a request with a route for the same primary resource as the other service operations in this class.
        /// </summary>
        internal static string SAS014MessageFormat {
            get {
                return ResourceManager.GetString("SAS014MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong route group.
        /// </summary>
        internal static string SAS014Title {
            get {
                return ResourceManager.GetString("SAS014Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service operation uses the same request type as another service operation in this class..
        /// </summary>
        internal static string SAS015Description {
            get {
                return ResourceManager.GetString("SAS015Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service operation &apos;{0}&apos; uses the same type for its first parameter as does another service operation in this class. They must use different request types.
        /// </summary>
        internal static string SAS015MessageFormat {
            get {
                return ResourceManager.GetString("SAS015MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate request type.
        /// </summary>
        internal static string SAS015Title {
            get {
                return ResourceManager.GetString("SAS015Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service operation should return an appropriate Result type for the operation..
        /// </summary>
        internal static string SAS016Description {
            get {
                return ResourceManager.GetString("SAS016Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service operation &apos;{0}&apos; is defined as a &apos;{1}&apos; operation, and can only return one of these types: &apos;{2}&apos;.
        /// </summary>
        internal static string SAS016MessageFormat {
            get {
                return ResourceManager.GetString("SAS016MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected return type for operation.
        /// </summary>
        internal static string SAS016Title {
            get {
                return ResourceManager.GetString("SAS016Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request type should be declared with a &apos;RouteAttribute&apos; on it..
        /// </summary>
        internal static string SAS017Description {
            get {
                return ResourceManager.GetString("SAS017Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request type &apos;{0}&apos; should declare a &apos;RouteAttribute&apos;.
        /// </summary>
        internal static string SAS017MessageFormat {
            get {
                return ResourceManager.GetString("SAS017MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing &apos;RouteAttribute&apos;.
        /// </summary>
        internal static string SAS017Title {
            get {
                return ResourceManager.GetString("SAS017Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create() class factory method must return the correct type..
        /// </summary>
        internal static string SAS020Description {
            get {
                return ResourceManager.GetString("SAS020Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Factory method &apos;{0}&apos; must return one of these types: &apos;{1}&apos;.
        /// </summary>
        internal static string SAS020MessageFormat {
            get {
                return ResourceManager.GetString("SAS020MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong return type.
        /// </summary>
        internal static string SAS020Title {
            get {
                return ResourceManager.GetString("SAS020Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constructor must be private..
        /// </summary>
        internal static string SAS021Description {
            get {
                return ResourceManager.GetString("SAS021Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constructor &apos;{0}&apos; must be private.
        /// </summary>
        internal static string SAS021MessageFormat {
            get {
                return ResourceManager.GetString("SAS021MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong accessibility.
        /// </summary>
        internal static string SAS021Title {
            get {
                return ResourceManager.GetString("SAS021Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing &apos;Rehydrate&apos; method.
        /// </summary>
        internal static string SAS022CodeFixTitle {
            get {
                return ResourceManager.GetString("SAS022CodeFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class must implement the Rehydrate() method..
        /// </summary>
        internal static string SAS022Description {
            get {
                return ResourceManager.GetString("SAS022Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class &apos;{0}&apos; must implement the Rehydrate() method.
        /// </summary>
        internal static string SAS022MessageFormat {
            get {
                return ResourceManager.GetString("SAS022MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing Rehydrate() method.
        /// </summary>
        internal static string SAS022Title {
            get {
                return ResourceManager.GetString("SAS022Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing &apos;Dehydrate&apos; method.
        /// </summary>
        internal static string SAS023CodeFixTitle {
            get {
                return ResourceManager.GetString("SAS023CodeFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class must implement the Dehydrate() method..
        /// </summary>
        internal static string SAS023Description {
            get {
                return ResourceManager.GetString("SAS023Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class &apos;{0}&apos; must implement the Dehydrate() method.
        /// </summary>
        internal static string SAS023MessageFormat {
            get {
                return ResourceManager.GetString("SAS023MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing Dehydrate() method.
        /// </summary>
        internal static string SAS023Title {
            get {
                return ResourceManager.GetString("SAS023Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing &apos;[EntityName]&apos; attribute.
        /// </summary>
        internal static string SAS024CodeFixTitle {
            get {
                return ResourceManager.GetString("SAS024CodeFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class must declare the [EntityName] attribute..
        /// </summary>
        internal static string SAS024Description {
            get {
                return ResourceManager.GetString("SAS024Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class &apos;{0}&apos; must use the [EntityNameAttribute].
        /// </summary>
        internal static string SAS024MessageFormat {
            get {
                return ResourceManager.GetString("SAS024MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing [EntityName] attribute.
        /// </summary>
        internal static string SAS024Title {
            get {
                return ResourceManager.GetString("SAS024Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property must not have a public setter..
        /// </summary>
        internal static string SAS025Description {
            get {
                return ResourceManager.GetString("SAS025Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; must not have a public setter.
        /// </summary>
        internal static string SAS025MessageFormat {
            get {
                return ResourceManager.GetString("SAS025MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property must not be settable.
        /// </summary>
        internal static string SAS025Title {
            get {
                return ResourceManager.GetString("SAS025Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing &apos;Create&apos; method.
        /// </summary>
        internal static string SAS030CodeFixTitle {
            get {
                return ResourceManager.GetString("SAS030CodeFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aggregate roots must have at least one Create() class factory method..
        /// </summary>
        internal static string SAS030Description {
            get {
                return ResourceManager.GetString("SAS030Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aggregate root type &apos;{0}&apos; must implement a class factory method called Create() to create new instances.
        /// </summary>
        internal static string SAS030MessageFormat {
            get {
                return ResourceManager.GetString("SAS030MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing Create() method.
        /// </summary>
        internal static string SAS030Title {
            get {
                return ResourceManager.GetString("SAS030Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create() class factory method must call specific code..
        /// </summary>
        internal static string SAS032Description {
            get {
                return ResourceManager.GetString("SAS032Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Factory method &apos;{0}&apos; must make a call to method &apos;{1}&apos;.
        /// </summary>
        internal static string SAS032MessageFormat {
            get {
                return ResourceManager.GetString("SAS032MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing required call to method.
        /// </summary>
        internal static string SAS032Title {
            get {
                return ResourceManager.GetString("SAS032Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing &apos;Create&apos; method.
        /// </summary>
        internal static string SAS040CodeFixTitle {
            get {
                return ResourceManager.GetString("SAS040CodeFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entities must have at least one Create() class factory method..
        /// </summary>
        internal static string SAS040Description {
            get {
                return ResourceManager.GetString("SAS040Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity type &apos;{0}&apos; must implement a class factory method called Create() to create new instances.
        /// </summary>
        internal static string SAS040MessageFormat {
            get {
                return ResourceManager.GetString("SAS040MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing Create() method.
        /// </summary>
        internal static string SAS040Title {
            get {
                return ResourceManager.GetString("SAS040Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing &apos;Create&apos; method.
        /// </summary>
        internal static string SAS050CodeFixTitle {
            get {
                return ResourceManager.GetString("SAS050CodeFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ValueObjects must have at least one Create() class factory method..
        /// </summary>
        internal static string SAS050Description {
            get {
                return ResourceManager.GetString("SAS050Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ValueObject type &apos;{0}&apos; must implement a class factory method called Create() to create new instances.
        /// </summary>
        internal static string SAS050MessageFormat {
            get {
                return ResourceManager.GetString("SAS050MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing Create() method.
        /// </summary>
        internal static string SAS050Title {
            get {
                return ResourceManager.GetString("SAS050Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method must not mutate the ValueObject..
        /// </summary>
        internal static string SAS055Description {
            get {
                return ResourceManager.GetString("SAS055Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; must not mutate this ValueObject&apos;s state, and must return a new instance in one of these types: &apos;{1}&apos;.
        /// </summary>
        internal static string SAS055MessageFormat {
            get {
                return ResourceManager.GetString("SAS055MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method mutates ValueObject state.
        /// </summary>
        internal static string SAS055Title {
            get {
                return ResourceManager.GetString("SAS055Title", resourceCulture);
            }
        }
    }
}
