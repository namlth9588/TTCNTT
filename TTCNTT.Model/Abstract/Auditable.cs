using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCNTT.Model.Abstract
{
    public abstract class Auditable : IAuditable 
    {
        public DateTime CreatedDate { set; get; }
        
        [MaxLength(256)]
        public string CreateBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        
        [MaxLength(256)]
        public string Updateby { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
