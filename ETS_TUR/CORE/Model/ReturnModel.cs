using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Model
{
    public class ReturnModel<TData>
    {
        public bool Success { get; set; }
        public TData? Result { get; set; }
        public Exception? Exception { get; set; }
    }
}
