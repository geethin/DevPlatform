﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Http.Application.DataStore;

public class StoreContext<TContext> where TContext : DbContext
{
    public StoreContext()
    {

    }
}
