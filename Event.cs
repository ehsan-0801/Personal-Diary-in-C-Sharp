using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMaker
{
    class Event
    {
        public int EventNo { get; set; }
        public string EventFile { get; set; }
        public string EventImportance { get; set; }
        public string EventDate { get; set; }
        public string EventPic { get; set; }
        public int UserId { get; set; }
        //public string ModificationDate { get; set; }

    }
}
