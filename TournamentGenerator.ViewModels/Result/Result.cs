﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournametGenerator.ViewModels.Result
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class Result<T> : Result
    {
         public T Data { get; set; }
    }
}