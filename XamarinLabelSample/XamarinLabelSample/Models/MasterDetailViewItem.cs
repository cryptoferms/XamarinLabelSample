using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinLabelSample.Models
{
   public class MasterDetailViewItem
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
