using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace customerloggersupport.Models
{
    public class CustLogInfoModel
    {
        
            public int LogId { get; set; }

            [Display(Name = "CustEmail:")]
            [Required(AllowEmptyStrings = false, ErrorMessage = "CustEmail is required")]
            [DataType(DataType.EmailAddress)]
            public string CustEmail { get; set; }

            [Display(Name = "CustName: ")]
            [Required(AllowEmptyStrings = false, ErrorMessage = "CustName is required")]
            public string CustName { get; set; }
            public string LogStatus { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public string SuccessMessage { get; internal set; }
        }
    }
