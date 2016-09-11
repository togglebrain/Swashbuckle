using Newtonsoft.Json;
using System;
using System.Net;

namespace Swashbuckle.Swagger.Annotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SwaggerResponseAttribute : Attribute
    {
        public SwaggerResponseAttribute(HttpStatusCode statusCode)
        {
            StatusCode = (int)statusCode;
        }

        public SwaggerResponseAttribute(HttpStatusCode statusCode, string description = null, Type type = null, string example = null)
            : this(statusCode)
        {
            Description = description;
            Type = type;
            if (!string.IsNullOrEmpty(example))
                Example = JsonConvert.DeserializeObject(example);
        }

        public SwaggerResponseAttribute(int statusCode)
        {
            StatusCode = statusCode;
        }

        public SwaggerResponseAttribute(int statusCode, string description = null, Type type = null, string example = null)
            : this(statusCode)
        {
            Description = description;
            Type = type;
            if (!string.IsNullOrEmpty(example))
                Example = JsonConvert.DeserializeObject(example);
        }

        public int StatusCode { get; private set; }

        public string Description { get; set; }

        public Type Type { get; set; }
        public object Example { get; set; }
    }
}