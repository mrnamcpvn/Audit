using System;

namespace Audit_API.Models
{
    public class Kind
    {
        public int id { get; set; }
        public string name { get; set; }
        public string definition { get; set; }
        public bool active { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_time { get; set; }
    }
}