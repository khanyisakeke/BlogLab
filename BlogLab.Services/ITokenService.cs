﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogLab.models.Account;

namespace BlogLab.Services
{
    public interface ITokenService
    {

        public string CreateToken(ApplicationUserIdentity user);

    }
}
