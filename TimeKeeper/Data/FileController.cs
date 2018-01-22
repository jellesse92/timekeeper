using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace inTime.TimeKeeper
{
    class FileController
    {
        private string activityList = "activities.csv";
        private string eventList = "events.csv";
        CsvWriter activityWriter;
        CsvWriter eventWriter;

        public FileController()
        {
            if (!File.Exists(activityList))
            {
                File.Create(activityList).Dispose();
            }
            if (!File.Exists(eventList))
            {
                File.Create(eventList).Dispose();
            }
        } 

        public void writeActivity(Activity activity)
        {
            using (StreamWriter sw = new StreamWriter(activityList))
            {

                CsvWriter activityWriter = new CsvWriter(sw);
                activityWriter.Configuration.AutoMap<Activity>();
                activityWriter.Configuration.IncludePrivateMembers = true;
                activityWriter.WriteRecord(activity);
                activityWriter.Flush();
                activityWriter.NextRecord();
            }
            this.writeActivityEvent(activity.events);
        }

        public void writeActivityEvent(Stack<ActivityEvent> events)
        {
            using (StreamWriter sw = File.AppendText(activityLog))
            {

                CsvWriter activityWriter = new CsvWriter(sw);
                activityWriter.Configuration.AutoMap<Activity>();
                activityWriter.Configuration.IncludePrivateMembers = true;
                activityWriter.WriteRecord();
                activityWriter.Flush();
                activityWriter.NextRecord();
            }
        }

        public List<Activity> readActivities()
        {
            return new List<Activity>();
        }

        public List<ActivityEvent> readActivityEvents()
        {
            return new List<ActivityEvent>();
        }

    }
}
