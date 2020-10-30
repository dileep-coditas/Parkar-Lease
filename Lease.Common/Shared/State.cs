using System;
using System.Collections.Generic;
using System.Text;

namespace Lease.Common.Shared
{
    public class State
    {
        public State()
        {

        }

        public State(int stateId, string stateName)
        {
            StateId = stateId;
            StateName = stateName;
        }
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
