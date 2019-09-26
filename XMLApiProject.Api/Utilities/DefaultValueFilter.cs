using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace XMLApiProject.Api.Utilities
{
    public class DefaultValueFilter : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaFilterContext context)
        {
            if(schema.Properties == null)
            {
                return;
            }

            foreach(PropertyInfo propertyInfo in context.SystemType.GetProperties())
            {
                var attribute = propertyInfo.GetCustomAttribute<DefaultValueAttribute>();

                if(attribute != null)
                {
                    foreach(var property in schema.Properties)
                    {
                        if(char.ToLowerInvariant(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1) == property.Key)
                        {
                            property.Value.Example = attribute.Value;
                            break;
                        }
                    }
                }
            }
        }
    }
}
