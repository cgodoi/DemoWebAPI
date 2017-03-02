using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DemoWebApi.Models
{
        public class Usuario
        {
        [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
            public string User { get; set; }
            public string Password { get; set; }

        }

}