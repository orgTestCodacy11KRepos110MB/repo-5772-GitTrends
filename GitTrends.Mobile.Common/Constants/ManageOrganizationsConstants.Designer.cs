﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitTrends.Mobile.Common.Constants {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ManageOrganizationsConstants {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ManageOrganizationsConstants() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("GitTrends.Mobile.Common.Constants.ManageOrganizationsConstants", typeof(ManageOrganizationsConstants).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string GitHubOrganizationsTitle {
            get {
                return ResourceManager.GetString("GitHubOrganizationsTitle", resourceCulture);
            }
        }
        
        public static string GitHubOrganizationsDescription {
            get {
                return ResourceManager.GetString("GitHubOrganizationsDescription", resourceCulture);
            }
        }
        
        public static string GitTrendsAccessTitle {
            get {
                return ResourceManager.GetString("GitTrendsAccessTitle", resourceCulture);
            }
        }
        
        public static string GitTrendsAccessDescription {
            get {
                return ResourceManager.GetString("GitTrendsAccessDescription", resourceCulture);
            }
        }
        
        public static string EnableOrganizationsTitle {
            get {
                return ResourceManager.GetString("EnableOrganizationsTitle", resourceCulture);
            }
        }
        
        public static string EnableOrganizationsDescription {
            get {
                return ResourceManager.GetString("EnableOrganizationsDescription", resourceCulture);
            }
        }
    }
}