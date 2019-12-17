﻿using RTDataManager.Library.Internal.DataAccess;
using RTDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id) 
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup1", p,
                "REPORTSDATASQL");

            return output;
        }
    }
}
