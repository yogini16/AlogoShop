﻿using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDataAccess.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
