﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Models.RequestModels
{
    public class GetRecordParameter
    {
        public string User { get; set; }
        public int RecordId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
    }
}
