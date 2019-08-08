﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Model.Player.Internals
{
    /// <summary>
    /// Contains information surrounding the health of a character.
    /// Health, in this contaxt, meaning HP
    /// </summary>
    public class Health
    {
        private int _Current;

        public int Current
        {
            get { return _Current; }
            set { if (_Current + value <= Max)
                {
                    _Current = value;
                } else if (_Current + value > Max)
                {
                    _Current = Max;
                }
            }
        }

        public int Max { get; set; }
    }
}
