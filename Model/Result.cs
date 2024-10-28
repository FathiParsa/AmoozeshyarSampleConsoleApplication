using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Result
    {
        public string Message { get; set; }
        public Exception Exeption { get; set; }
        public bool IsSuccess { get; set; }
    }
}
