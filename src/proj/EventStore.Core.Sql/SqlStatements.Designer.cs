﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventStore.Core.Sql {
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
    internal class SqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventStore.Core.Sql.SqlStatements", typeof(SqlStatements).Assembly);
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
        ///   Looks up a localized string similar to INSERT
        ///  INTO [Events]
        ///     ( [Id], [Version], [CorrelationId], [Payload] )
        ///VALUES
        ///     ( @id, @initial_version{0}, @correlation_id, @payload{0} );.
        /// </summary>
        internal static string InsertEvent {
            get {
                return ResourceManager.GetString("InsertEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO [Aggregates]
        ///     ( [Id], [Version], [Snapshot], [RuntimeType] )
        ///SELECT @id,
        ///       @current_version,
        ///       CASE WHEN @payload IS NULL THEN 0 ELSE @current_version END AS [Snapshot],
        ///       @type
        /// WHERE @initial_version = 0;
        ///
        ///UPDATE [Aggregates]
        ///   SET [Version] = @current_version,
        ///       [Snapshot] = CASE WHEN @payload IS NULL THEN [Snapshot] ELSE @current_version END,
        ///       [RuntimeType] = COALESCE(@type, [RuntimeType])
        /// WHERE [Id] = @id
        ///   AND [Version] = @initial_version
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertEvents {
            get {
                return ResourceManager.GetString("InsertEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Payload]
        ///  FROM [Events]
        /// WHERE [CorrelationId] = @id
        /// ORDER BY [Version];.
        /// </summary>
        internal static string SelectEventsForCorrelation {
            get {
                return ResourceManager.GetString("SelectEventsForCorrelation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Payload]
        ///  FROM [Events]
        /// WHERE [Id] = @id
        ///   AND [Version] &gt;= @current_version
        /// ORDER BY [Version];.
        /// </summary>
        internal static string SelectEventsForVersion {
            get {
                return ResourceManager.GetString("SelectEventsForVersion", resourceCulture);
            }
        }
    }
}
