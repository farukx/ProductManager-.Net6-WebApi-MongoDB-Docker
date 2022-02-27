// <snippet_UsingSystemTextJsonSerialization>
using System.Text.Json.Serialization;
// </snippet_UsingSystemTextJsonSerialization>
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductManager.Models;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    // <snippet_ProductName>
    [BsonElement("Name")]
    [JsonPropertyName("Name")]
    public string ProductName { get; set; } = null!;
    // </snippet_ProductName>

    public decimal Price { get; set; }

    public string Category { get; set; } = null!;

    public string Author { get; set; } = null!;
}