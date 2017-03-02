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
        public class Dispositivo
        {
        [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
            public string id_usuario { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }

        }

}