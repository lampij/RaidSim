using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Model.PlayerObjects.Internals
{
    /// <summary>
    /// Contains information surrounding the Resource of a character.
    /// Resource, in this contaxt, meaning HP
    /// </summary>
    public class Resource
    {
        public Resource(int MaxResource)
        {
            this.Max = MaxResource;
            this._Current = Max;
        }
        private int _Current;

        public int Current
        {
            get { return _Current; }
            set
            {
                if (_Current + value <= Max)
                {
                    _Current = value;
                }
                else if (_Current + value > Max)
                {
                    _Current = Max;
                }
            }
        }

        public int Max { get; set; }
    }
}
