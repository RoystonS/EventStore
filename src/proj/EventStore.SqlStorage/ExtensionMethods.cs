namespace EventStore.SqlStorage
{
	using System;
	using System.Data;
	using System.IO;

	public static class ExtensionMethods
	{
		public static IDataParameter AddParameter(this IDbCommand command, string parameterName, object value)
		{
			if (value is Guid)
				value = ((Guid)value).ToByteArray();

			var parameter = command.CreateParameter();
			parameter.ParameterName = parameterName;
			parameter.Value = value ?? DBNull.Value;

			if (parameter.Value == DBNull.Value || value is byte[])
				parameter.DbType = DbType.Binary;

			command.Parameters.Add(parameter);
			return parameter;
		}

		internal static object Deserialize(this ISerializeObjects serializer, byte[] serialized)
		{
			using (var stream = new MemoryStream(serialized))
				return serializer.Deserialize(stream);
		}
	}
}