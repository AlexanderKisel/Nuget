using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStory_Men_Cher.Models
{
    public enum FormStudy
    {
        [Description("Очная")]
        Och,
        [Description("Заочная")]
        Zaoch,
        [Description("Очно-заочная")]
        Och_Zaoch,
    }
}
