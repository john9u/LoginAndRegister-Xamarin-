﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegister.Services
{
    public interface IAlertService
    {
        Task Alert(string title, string description, string ok);
    }
}
