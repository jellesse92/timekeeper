using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inTime.TimeKeeper
{
    public struct ActivityEvent
    {
        DateTime start;
        DateTime stop;
    }
    class Activity
    {
        public string name;
        public string category;

        protected ActivityEvent[] events;

        private Guid id;
        private Guid user;


    }
}
