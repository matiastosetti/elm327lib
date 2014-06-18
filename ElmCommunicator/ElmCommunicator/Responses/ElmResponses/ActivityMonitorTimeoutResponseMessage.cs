﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
{
    public class ActivityMonitorTimeoutResponseMessage : ResponseMessage
    {
        public ActivityMonitorTimeoutResponseMessage()
        {
            this.Command = "AT AMT";
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Data = message;

            return this;
        }
    }
}
