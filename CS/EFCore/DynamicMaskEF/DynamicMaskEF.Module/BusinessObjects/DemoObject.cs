using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Model;

namespace DynamicMask.Module.BusinessObjects {
    [DefaultClassOptions]
    public class DemoObject : BaseObject {
        [ImmediatePostData]
        public virtual EditMask Mask { get; set; }

        [ModelDefault("EditMask", "(000) 000-0000")]
        public virtual string TestString { get; set; }
    }
    public enum EditMask {
        Date,
        Time,
        Numeric,
        String
    }
}
