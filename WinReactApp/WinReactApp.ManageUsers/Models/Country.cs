﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WinReactApp.ManageUsers.Models
{
    public partial class Country
    {
        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public bool? IsActive { get; set; }
    }
}
