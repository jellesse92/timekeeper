using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inTime.TimeKeeper
{
    public struct ActivityEvent
    { 
        public Guid user { get; set; }
        public int activityID { get; set; }
        public DateTime start { get; set; } 
        public DateTime stop { get; set; }
    }

    class Activity
    {
        public Guid user { get; private set; }
        public int id { get; private set; }
        public string name { get; set; }
        public string category { get; set; }
        public Stack<ActivityEvent> events { get; private set; }

        private bool isActive = false;


        public Activity(int id)
        {
            this.id = id;
            loadActivity(this.id);
            
        }
        public Activity(string name ="", string category = "")
        {
            this.name = name;
            this.category = category;
            this.events = new Stack<ActivityEvent>();
        }

        private void saveActivity()
        {
            
        }

        private void loadActivity(int id)
        {

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
                newEvent.activityID = this.id;
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
