using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace INVZAV.lib.Classes
{
	/// <summary>
	/// static class that used to read and write json files.
	/// </summary>
	public static class Json
	{
		#region options
		/// <summary>
		/// json saving options.
		/// </summary>
		private static readonly JsonSerializerOptions jsonOptions;
		/// <summary>
		/// static ctor.
		/// </summary>
		static Json() => jsonOptions = new JsonSerializerOptions()
		{
			WriteIndented = false,
			IgnoreReadOnlyProperties = false,
			PropertyNameCaseInsensitive = true
		};
		#endregion
		#region make file
		/// <summary>
		/// making json file and writing object <typeparamref name="T"/> into it.
		/// </summary>
		/// <typeparam name="T">object of type <typeparamref name="T"/> that will be saved in file.</typeparam>
		/// <param name="path">path to json file where will be saved object <typeparamref name="T"/>.</param>
		/// <param name="saveToJson">object <typeparamref name="T"/> to save.</param>
		public static void WriteFile<T>(string path, T saveToJson)
		{
			using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			JsonSerializer.Serialize(fs, saveToJson, typeof(T), jsonOptions);
		}
		/// <summary>
		/// making json file and writing object <typeparamref name="T"/> into it.
		/// </summary>
		/// <remarks>
		/// opens <see cref="FileStream"/> with <see cref="FileMode.Truncate"/>, for rewriting all file.
		/// </remarks>
		/// <typeparam name="T">object of type <typeparamref name="T"/> that will be saved in file.</typeparam>
		/// <param name="path">path to json file where will be saved object <typeparamref name="T"/>.</param>
		/// <param name="saveToJson">object <typeparamref name="T"/> to save.</param>
		/// <returns></returns>
		public static void RewriteFile<T>(string path, T saveToJson)
		{
			FileMode fm = File.Exists(path) ? FileMode.Truncate : FileMode.Create;
			using (FileStream fs = new FileStream(path, fm)) JsonSerializer.Serialize(fs, saveToJson, typeof(T), jsonOptions);
		}
		/// <summary>
		/// async making json file and writing object <typeparamref name="T"/> into it.
		/// </summary>
		/// <typeparam name="T">object of type <typeparamref name="T"/> that will be saved in file.</typeparam>
		/// <param name="path">path to json file where will be saved object <typeparamref name="T"/>.</param>
		/// <param name="saveToJson">object <typeparamref name="T"/> to save.</param>
		public static async Task WriteFileAsync<T>(string path, T saveToJson)
		{
			using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			await JsonSerializer.SerializeAsync(fs, saveToJson, typeof(T), jsonOptions);
		}
		/// <summary>
		/// async making json file and writing object <typeparamref name="T"/> into it.
		/// </summary>
		/// <remarks>
		/// opens <see cref="FileStream"/> with <see cref="FileMode.Truncate"/>, for rewriting all file.
		/// </remarks>
		/// <typeparam name="T">object of type <typeparamref name="T"/> that will be saved in file.</typeparam>
		/// <param name="path">path to json file where will be saved object <typeparamref name="T"/>.</param>
		/// <param name="saveToJson">object <typeparamref name="T"/> to save.</param>
		/// <returns></returns>
		public static async Task RewriteFileAsync<T>(string path, T saveToJson)
		{
			FileMode fm = File.Exists(path) ? FileMode.Truncate : FileMode.Create;
			using FileStream fs = new FileStream(path, fm);
			await JsonSerializer.SerializeAsync(fs, saveToJson, typeof(T), jsonOptions);
		}
		#endregion
		#region read file
		/// <summary>
		/// reading json file and deserializing it to object <typeparamref name="T"/>.
		/// </summary>
		/// <remarks>
		/// if json data file is corrupted, throws <see cref="JsonException"/>.
		/// </remarks>
		/// <typeparam name="T">type of object in json file.</typeparam>
		/// <param name="path">path to json file.</param>
		/// <returns>object read in json file.</returns>
		/// <exception cref="JsonException"/>
		/// <exception cref="NullReferenceException"/>
		/// <exception cref="IOException"/>
		public static T ReadFile<T>(string path)
		{
			try
			{
				using FileStream fs = new FileStream(path, FileMode.Open);
				return JsonSerializer.Deserialize<T>(fs, jsonOptions) ?? throw new NullReferenceException($"file with path {{{path}}} returned null.");
			}
			catch (JsonException) { throw; }
			catch (IOException) { throw; }
		}
		/// <summary>
		/// async reading json file and deserializing it to object <typeparamref name="T"/>.
		/// </summary>
		/// <remarks>
		/// if json data file is corrupted, throws <see cref="JsonException"/>.
		/// </remarks>
		/// <typeparam name="T">type of object in json file.</typeparam>
		/// <param name="path">path to json file.</param>
		/// <returns>object read in json file.</returns>
		/// <exception cref="JsonException"/>
		/// <exception cref="NullReferenceException"/>
		public static async Task<T> ReadFileAsync<T>(string path)
		{
			try
			{
				using FileStream fs = new FileStream(path, FileMode.Open);
				return await JsonSerializer.DeserializeAsync<T>(fs, jsonOptions) ?? throw new NullReferenceException($"file with path {{{path}}} returned null.");
			}
			catch (JsonException) { throw; }
			catch (IOException) { throw; }
		}
		#endregion
	}
}