﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class CreateleatureForTrainVm
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid IdTrain { get; set; }
    }
}
