﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperVoters.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=tcp:supervoters.database.windows.net,1433;Initial Catalog=SuperVoters;Pers" +
            "ist Security Info=False;User ID=supervotersadmin;Password=Supervoters1!;Multiple" +
            "ActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Time" +
            "out=30;")]
        public string SuperVotersConnectionString {
            get {
                return ((string)(this["SuperVotersConnectionString"]));
            }
            set {
                this["SuperVotersConnectionString"] = value;
            }
        }
    }
}
