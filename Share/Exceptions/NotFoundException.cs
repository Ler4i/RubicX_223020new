﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Exceptions
{
    public class NotFoundException : Exception 
    {
        public NotFoundException(string message) : base(message)//конструктор для ошибки 404
        {

        }
    }
}
