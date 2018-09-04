
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YX.Model
{
    class Company:BaseModel
    {
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }

        public int CreatorId { get; set; }

        public int? LastModifierId { get; set; }

        public DateTime? LastModifyTime { get; set; }

    }
}