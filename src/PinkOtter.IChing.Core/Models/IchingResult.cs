using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinkOtter.IChing.Core.Models
{
    public class IchingResult
    {
        public string Question { get; set; } = "";
        public int[] Lines { get; set; } = new int[6];
    }
}
