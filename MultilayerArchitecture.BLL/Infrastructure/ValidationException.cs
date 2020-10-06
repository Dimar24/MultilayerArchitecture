using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultilayerArchitecture.BLL.Infrastructure
{
    class ValidationException : Exception
    {
        public string Property { get; protected set; }
        ValidationException(string message, string prop) : base(message)
        {
            Property = prop;
        }
    }
}
