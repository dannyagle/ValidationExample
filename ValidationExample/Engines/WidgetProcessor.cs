using System;
using ValidationExample.Models;

namespace ValidationExample.Engines
{
    public class WidgetProcessor
    {

        public void Process(Incoming incoming)
        {
            if(incoming == null)
            {
                throw new ArgumentNullException("incoming", "Cannot pass a null to WidgetProcessor.Process()");
            }

            if(incoming.Workflow == null)
            {
                throw new ArgumentNullException("incoming.Workflow", "incoming.Workflow cannot be null");
            }

            if (incoming.LastName == null)
            {
                throw new ArgumentNullException("incoming.LastName", "incoming.LastName cannot be null");
            }

            if (incoming.BirthDate == null)
            {
                throw new ArgumentNullException("incoming.BirthDate", "incoming.BirthDate cannot be null");
            }

            // Do some awesome work ...

        }

    }
}
