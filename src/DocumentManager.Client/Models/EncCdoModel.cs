﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentExportUtility_API.Models
{
    public class EncCdoModel
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("dataObject")]
        public byte[] dataObject { get; set; }
    }
}
