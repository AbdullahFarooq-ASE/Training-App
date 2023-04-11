using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Training_App.Models
{
    public class Date
    {
        [DisplayName(displayName:"DATE")]
        public int date_time { get; set; }
    }
}