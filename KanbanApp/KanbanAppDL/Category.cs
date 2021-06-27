using System;

namespace KanbanAppDL
{
    public class Category
    {
        public string unopened;
        public string opened;
        public string finished;
        public string late;

        public Category(string unopened, string opened, string finished, string late)
        {
            this.unopened = unopened;
            this.opened = opened;
            this.finished = finished;
            this.late = late;
        }
        public string Unopened
        {
            get { return unopened; }
            set { unopened = value; }
        }

        public string Opened
        {
            get { return opened; }
            set { opened = value; }
        }

        public string Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        public string Late
        {
            get { return late; }
            set { late = value; }
        }
    }
}
