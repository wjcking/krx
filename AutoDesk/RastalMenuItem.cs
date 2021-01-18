using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDesk
{

    public class RastalMenuItem
    {
        public RastalMenuItem()
        {
            TargetType = typeof(RastalDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}