using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Models
{
    public class MsgResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
        public int Count { get; set; }
        public Exception Error { get; set; }
        public Object Objeto { get; set; }
    }
}
