﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryLegacy
{
    public struct ViewMediaMetadata
    {
        public string YID { get; set; }
        public string Title { get; set; }
        public Uri ThumbUri { get; set; }
        public string Quality { get; set; }
        public string MediaType { get; set; }
        public long Size { get; set; }
    }
}
