﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    interface IServerManager
    {
        Server GetServer(int id);
        void AddServer(Server server);
    }
}