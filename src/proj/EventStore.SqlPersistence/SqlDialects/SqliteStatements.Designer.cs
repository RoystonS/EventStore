﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventStore.SqlPersistence.SqlDialects {
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
    internal class SqliteStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqliteStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventStore.SqlPersistence.SqlDialects.SqliteStatements", typeof(SqliteStatements).Assembly);
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
        ///   Looks up a localized string similar to BEGIN TRANSACTION;
        ///
        ///INSERT
        ///  INTO Streams
        ///     ( StreamId, Name, HeadRevision )
        ///SELECT @StreamId, COALESCE(@StreamName, &apos;&apos;), @StreamRevision
        /// WHERE @ExpectedRevision = 0
        ///   AND NOT EXISTS
        ///     ( SELECT *
        ///         FROM Streams
        ///        WHERE StreamId = @StreamId );
        ///
        ///INSERT OR REPLACE
        ///  INTO Streams
        ///     ( StreamId, Name, HeadRevision)
        ///SELECT @StreamId, COALESCE(@StreamName, &apos;&apos;), @StreamRevision
        /// WHERE @ExpectedRevision &gt; 0
        ///   AND StreamId = @StreamId
        ///   AND HeadRevision = @ExpectedRevision
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PersistCommitAttempt {
            get {
                return ResourceManager.GetString("PersistCommitAttempt", resourceCulture);
            }
        }
    }
}
