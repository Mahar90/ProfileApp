﻿using ProfileApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileApp.Interfaces
{
    interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
