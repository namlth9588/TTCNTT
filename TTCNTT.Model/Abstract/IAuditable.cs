using System;

namespace TTCNTT.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string Updateby { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}