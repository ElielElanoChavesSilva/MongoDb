using MongoDb.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotation.Schema;
using System.Text.Json.Serialization;

namespace LojaCarrosServer.Colletions;

    [Table("products")]
    [BsonIgnoreExtraElements]
    
public class Product
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]

  public string Id { get; set; }

  [Bsonelement("name")]
  [JsonProperty("Nome")]
  public string Name { get; set; }  


  [Bsonelement("description")]
  [JsonProperty("Descricao")]
  public string Description { get; set; }  

  [Bsonelement("price")]
  [JsonProperty("Preco")]
  public string Price { get; set; }  
  
  [Bsonelement("name")]
  [JsonProperty("Nome")]
  public string Name { get; set; }  


}