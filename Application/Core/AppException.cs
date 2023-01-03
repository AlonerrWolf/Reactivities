using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class AppException
    {
        public AppException(string message, int statusCode, string? details = null)
        {
            Message = message;
            Details = details;
            StatusCode = statusCode;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
