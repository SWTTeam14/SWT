﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakes2
{
    public interface IDoor
    {
        void Open();
        void Closed();
    }
    public class Door : IDoor
    {
        public void Open()
        {

        }

        public void Closed()
        {

        }
    }
}
