﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loger.Common.Other
{
    public class LikedLogo
    {
        public int FromUserId { get; set; }
        public int ToLogoId { get; set; }
        public bool Liked { get; set; }
    }
}
