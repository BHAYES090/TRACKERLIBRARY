﻿using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.DataAndSQL
{
    public interface IDataConnection
    {
        ReportModel CreateReport(ReportModel model);
    }
}
