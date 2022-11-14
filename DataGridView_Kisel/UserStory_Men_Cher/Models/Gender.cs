using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStory_Men_Cher.Models
{
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        [Description("Мужской")]
        Male,
        /// <summary>
        /// Женский
        /// </summary>
        [Description("Женский")]
        Female,
    }
}
