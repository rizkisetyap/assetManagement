﻿using assetManagement.Context;
using assetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Repositories.Data
{
    public class ConditionItemRepository : GeneralRepository<ConditionItem, MyContext, int>
    {
        private readonly MyContext myContext;
        public ConditionItemRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
