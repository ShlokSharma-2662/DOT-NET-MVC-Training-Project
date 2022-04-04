using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    
        public class UserChartRequestModel
        {
            public string SelectAsLabel { get; set; }
            public string GroupBy { get; set; }
        }
        public class UserChartResponseModel
        {
            public string Label { get; set; }
            public int Value { get; set; }

            public void setLabel(string Label)
            {
                this.Label = Label;
            }
            public string getLabel()
            {
                return this.Label;
            }

            public void setValue(int Value)
            {
                this.Value = Value;
            }
            public int getValue()
            {
                return this.Value;
            }
        }    
}