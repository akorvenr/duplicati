﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.CommandLine.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Program {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Program() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.CommandLine.Strings.Program", typeof(Program).Assembly);
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
        ///   Looks up a localized string similar to Added folders.
        /// </summary>
        internal static string AddedFoldersHeader {
            get {
                return ResourceManager.GetString("AddedFoldersHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Control files.
        /// </summary>
        internal static string ControlFilesHeader {
            get {
                return ResourceManager.GetString("ControlFilesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted files.
        /// </summary>
        internal static string DeletedFilesHeader {
            get {
                return ResourceManager.GetString("DeletedFilesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted folders.
        /// </summary>
        internal static string DeletedFoldersHeader {
            get {
                return ResourceManager.GetString("DeletedFoldersHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicati options:.
        /// </summary>
        internal static string DuplicatiOptionsHeader {
            get {
                return ResourceManager.GetString("DuplicatiOptionsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Duplicati.CommandLine /home/user/ ftp://host/folder --exclude=/file.txt
        ///
        ///  In this example the file &quot;/home/user/file.txt&quot; is excluded.
        ///.
        /// </summary>
        internal static string ExampleLinux {
            get {
                return ResourceManager.GetString("ExampleLinux", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Duplicati.CommandLine C:\Documents\Files ftp://host/folder --exclude=\file.txt
        ///
        ///  In this example the file &quot;C:\Documents\Files\file.txt&quot; is excluded.
        ///.
        /// </summary>
        internal static string ExampleWindows {
            get {
                return ResourceManager.GetString("ExampleWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supported generic modules:.
        /// </summary>
        internal static string GenericModulesHeader {
            get {
                return ResourceManager.GetString("GenericModulesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse &quot;{0}&quot; into a number.
        /// </summary>
        internal static string IntegerParseError {
            get {
                return ResourceManager.GetString("IntegerParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The option --{0} was supplied, but it is reserved for internal use and may not be set on the commandline.
        /// </summary>
        internal static string InternalOptionUsedError {
            get {
                return ResourceManager.GetString("InternalOptionUsedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modified files.
        /// </summary>
        internal static string ModifiedFilesHeader {
            get {
                return ResourceManager.GetString("ModifiedFilesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module is loaded atomatically, use --disable-module to prevent this.
        /// </summary>
        internal static string ModuleIsLoadedAutomatically {
            get {
                return ResourceManager.GetString("ModuleIsLoadedAutomatically", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module is not loaded atomatically, use --enable-module to load it.
        /// </summary>
        internal static string ModuleIsNotLoadedAutomatically {
            get {
                return ResourceManager.GetString("ModuleIsNotLoadedAutomatically", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New files.
        /// </summary>
        internal static string NewFilesHeader {
            get {
                return ResourceManager.GetString("NewFilesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New/Modified files.
        /// </summary>
        internal static string NewOrModifiedFilesHeader {
            get {
                return ResourceManager.GetString("NewOrModifiedFilesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: Duplicati uses the character : as the time seperator as that makes the filenames easier to read. However, that character is not supported on Windows filesystems. To work around this issue, Duplicati has adjusted the timeseperator char to &apos;. Use the commandline option --time-separator=&quot;:&quot; to prevent this from happening..
        /// </summary>
        internal static string SettingDefaultTimeSeperatorWarning {
            get {
                return ResourceManager.GetString("SettingDefaultTimeSeperatorWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supported backends:.
        /// </summary>
        internal static string SupportedBackendsHeader {
            get {
                return ResourceManager.GetString("SupportedBackendsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supported compression modules:.
        /// </summary>
        internal static string SupportedCompressionModulesHeader {
            get {
                return ResourceManager.GetString("SupportedCompressionModulesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supported encryption modules:.
        /// </summary>
        internal static string SupportedEncryptionModulesHeader {
            get {
                return ResourceManager.GetString("SupportedEncryptionModulesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supported options:.
        /// </summary>
        internal static string SupportedOptionsHeader {
            get {
                return ResourceManager.GetString("SupportedOptionsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse &quot;{0}&quot; into a time offset: {1}.
        /// </summary>
        internal static string TimeParseError {
            get {
                return ResourceManager.GetString("TimeParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured: {0}.
        /// </summary>
        internal static string UnhandledException {
            get {
                return ResourceManager.GetString("UnhandledException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The inner error message is: {0}.
        /// </summary>
        internal static string UnhandledInnerException {
            get {
                return ResourceManager.GetString("UnhandledInnerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ********** Duplicati v. {0} **********
        ///
        ///Usage:
        ///
        /// Backup (make a full or incremental backup):
        ///  Duplicati.CommandLine [full] [options] &lt;sourcefolder&gt; &lt;backend&gt;
        ///
        /// Restore (restore all or some files):
        ///  Duplicati.CommandLine [options] &lt;backend&gt; &lt;destinationfolder&gt;
        ///
        /// Cleanup (remove partial and unused files):
        ///  Duplicati.CommandLine cleanup [options] &lt;backend&gt;
        ///
        /// List files (backup volume sets):
        ///  Duplicati.CommandLine list [options] &lt;backend&gt;
        ///
        /// List content files (files that can be restored):
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Usage {
            get {
                return ResourceManager.GetString("Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong number of aguments.
        /// </summary>
        internal static string WrongNumberOfArgumentsError {
            get {
                return ResourceManager.GetString("WrongNumberOfArgumentsError", resourceCulture);
            }
        }
    }
}
