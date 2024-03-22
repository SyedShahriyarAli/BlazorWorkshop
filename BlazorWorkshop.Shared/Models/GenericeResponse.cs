using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWorkshop.Shared.Models
{
    public class GenericeResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string? Message { get; set; }
    }
}
