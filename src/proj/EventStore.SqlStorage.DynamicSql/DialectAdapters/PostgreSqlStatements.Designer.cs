﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventStore.SqlStorage.DynamicSql.DialectAdapters {
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
    internal class PostgreSqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PostgreSqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventStore.SqlStorage.DynamicSql.DialectAdapters.PostgreSqlStatements", typeof(PostgreSqlStatements).Assembly);
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
        ///   Looks up a localized string similar to 
        ///SELECT @id, @committed_version{0}, @command_id, @payload{0} UNION ALL.
        /// </summary>
        internal static string InsertEvent {
            get {
                return ResourceManager.GetString("InsertEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO Aggregates
        ///     ( Id, TenantId, Version, Snapshot, RuntimeType )
        ///SELECT @id,
        ///       COALESCE(@tenant_id, E&apos;00000000-0000-0000-0000-000000000000&apos;::uuid),
        ///       @new_version,
        ///       CASE WHEN @payload IS NULL THEN 0 ELSE @new_version END AS Snapshot,
        ///       @type
        /// WHERE @committed_version = 0;
        ///
        ///INSERT
        ///  INTO Commands
        ///SELECT @command_id, @command_payload
        /// WHERE @command_id IS NOT NULL;
        ///
        ///INSERT
        ///  INTO Events
        ///     ( Id, Version, CommandId, Payload )
        ///{0}
        ///SELECT NULL, NULL, NULL,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertEvents {
            get {
                return ResourceManager.GetString("InsertEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Payload
        ///  FROM Events
        /// WHERE Id = @id
        ///   AND Version &gt;
        ///     ( SELECT COALESCE(MAX(Version), 0)
        ///         FROM Snapshots
        ///        WHERE Id = @id
        ///          AND @committed_version &gt; 0
        ///          AND Version &lt;= @committed_version )
        /// ORDER BY Version;
        /// 
        ///SELECT Payload,
        ///       Version
        ///  FROM Snapshots
        /// WHERE Id = @id
        ///   AND @committed_version &gt; 0
        ///   AND Version &lt;= @committed_version
        /// ORDER BY Version DESC
        /// LIMIT 1;.
        /// </summary>
        internal static string SelectEvents {
            get {
                return ResourceManager.GetString("SelectEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Payload
        ///  FROM Events
        /// WHERE CommandId = @id
        /// ORDER BY Version;.
        /// </summary>
        internal static string SelectEventsForCommand {
            get {
                return ResourceManager.GetString("SelectEventsForCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Payload
        ///  FROM Events
        /// WHERE Id = @id
        ///   AND Version &gt; @committed_version
        ///   AND EXISTS
        ///     ( SELECT *
        ///         FROM Aggregates
        ///        WHERE Id = @id
        ///          AND TenantId = COALESCE(@tenant_id, TenantId) )
        /// ORDER BY Version;.
        /// </summary>
        internal static string SelectEventsSinceVersion {
            get {
                return ResourceManager.GetString("SelectEventsSinceVersion", resourceCulture);
            }
        }
    }
}
