namespace EventStore.Serialization
{
	using System.IO;

	/// <summary>
	/// Provides the ability to serialize and deserialize an object graph.
	/// </summary>
	public interface ISerialize
	{
		/// <summary>
		/// Serializes the object graph provided and writes a serialized representation to the output stream provided.
		/// </summary>
		/// <param name="output">The stream into which the serialized object graph should be written.</param>
		/// <param name="graph">The object graph to be serialized.</param>
		void Serialize(Stream output, object graph);

		/// <summary>
		/// Deserializes the stream provided and reconstructs the corresponding object graph.
		/// </summary>
		/// <param name="input">The stream of bytes from which the object will be reconstructed.</param>
		/// <returns>The reconstructed object.</returns>
		object Deserialize(Stream input);
	}
}