using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inTime.TimeKeeper
{
    public struct ActivityEvent
    {
        public DateTime start { get; set; } 
        public DateTime stop { get; set; }
    }

    class Activity
    {
        public string name;
        public string category;
        public bool isActive;

        protected Stack<ActivityEvent> events;

        private Guid id;
        private Guid user;

        public Activity(string name ="", string category = "")
        {
            this.name = name;
            this.category = category;
        }

        public void changeActivityName(string name)
        {
            this.name = name;
        }

        public void setActivityCategory(string category)
        {
            this.category = category;
        }

        public ActivityEvent getLastEvent()
        {
           return events.Peek();
        }

        public void cancelEvent()
        {
            events.Pop();
        }

        public void createEvent()
        {
            if (!isActive)
            {
                ActivityEvent newEvent = new ActivityEvent();
                newEvent.start = DateTime.Now;
                events.Push(newEvent);
                isActive = true;
            }
        }

        public void endEvent()
        {
            if (isActive)
            {
                ActivityEvent currentEvent = events.Pop();
                currentEvent.stop = DateTime.Now;
                events.Push(currentEvent);
                isActive = false;
            }
        }


    }
}
