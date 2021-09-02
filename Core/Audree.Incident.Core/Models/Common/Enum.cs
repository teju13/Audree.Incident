using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Audree.Incident.Core.Models.Common
{
   public class Enum
    {
        public enum EnumUserActions
        {
            [Display(Name = "Standard Data")]
            Std = 0,
            [Display(Name = "Created")]
            Created = 1,
            [Display(Name = "Modified")]
            Modified = 2,
            [Display(Name = "Enabled")]
            Enabled = 3,
            [Display(Name = "Disabled")]
            Disabled = 4,
            [Display(Name = "Permanent Disabled")]
            PermanentDisable = 5,
            [Display(Name = "Standard Data")]
            Standard = 6,
            [Display(Name = "Update")]
            Update = 7,

        }
    }
}
