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
    internal class MsSqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MsSqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventStore.SqlStorage.DynamicSql.DialectAdapters.MsSqlStatements", typeof(MsSqlStatements).Assembly);
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
        ///SELECT @id, @initial_version{0},@command_id, @payload{0} UNION ALL.
        /// </summary>
        internal static string InsertEvent {
            get {
                return ResourceManager.GetString("InsertEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO [Aggregates]
        ///     ( [Id], [TenantId], [Version], [Snapshot], [RuntimeType] )
        ///SELECT @id,
        ///       COALESCE(@tenant_id, 0x0),
        ///       @current_version,
        ///       CASE WHEN @payload IS NULL THEN 0 ELSE @current_version END AS [Snapshot],
        ///       @type
        /// WHERE @initial_version = 0;
        ///
        ///IF @@ERROR &gt; 0 RETURN;
        ///
        ///INSERT
        ///  INTO [Commands]
        ///SELECT @command_id, @command_payload
        /// WHERE @command_id IS NOT NULL;
        ///
        ///IF @@ERROR &gt; 0 RETURN;
        ///
        ///INSERT
        ///  INTO [Events]
        ///     ( [Id], [Version], [CommandId], [ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertEvents {
            get {
                return ResourceManager.GetString("InsertEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Payload]
        ///  FROM [Events]
        /// WHERE [Id] = @id
        ///   AND [Version] &gt;
        ///     ( SELECT COALESCE(MAX([Version]), 0)
        ///         FROM [Snapshots]
        ///        WHERE [Id] = @id
        ///          AND @current_version &gt; 0
        ///          AND [Version] &lt;= @current_version )
        /// ORDER BY [Version];
        /// 
        ///SELECT TOP 1
        ///       [Payload],
        ///       [Version]
        ///  FROM [Snapshots]
        /// WHERE [Id] = @id
        ///   AND @current_version &gt; 0
        ///   AND [Version] &lt;= @current_version
        /// ORDER BY [Version] DESC;.
        /// </summary>
        internal static string SelectEvents {
            get {
                return ResourceManager.GetString("SelectEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Payload]
        ///  FROM [Events]
        /// WHERE [CommandId] = @id
        /// ORDER BY [Version];.
        /// </summary>
        internal static string SelectEventsForCommand {
            get {
                return ResourceManager.GetString("SelectEventsForCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Payload]
        ///  FROM [Events]
        /// WHERE [Id] = @id
        ///   AND [Version] &gt; @current_version
        ///   AND EXISTS
        ///     ( SELECT *
        ///         FROM [Aggregates]
        ///        WHERE [Id] = @id
        ///          AND [TenantId] = COALESCE(@tenant_id, [TenantId]) )
        /// ORDER BY [Version];.
        /// </summary>
        internal static string SelectEventsSinceVersion {
            get {
                return ResourceManager.GetString("SelectEventsSinceVersion", resourceCulture);
            }
        }
    }
}
