using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketManagement.Application.Responses
{
    public class BaseResponse
    {
        public BaseResponse() 
        {
            Success = true;
        }
        public BaseResponse(string message)
        {
            Success = true;
            Message = message;
        }

        public BaseResponse(string message, bool success)
        {
            Success = success;
            Message = message;
        }

//testing

        public bool Success { get; internal set; }
        public string Message { get; set; } =string.Empty;
        public List<string> ValidationErrors { get; internal set; }
    }
}
