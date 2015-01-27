﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class ThrottlePositionSendMessage : SendMessage
    {
        public ThrottlePositionSendMessage()
        {
            this.ResponseMessage = new ThrottlePositionResponse();
            Command = "01";
            Data = "11";
        }
    }
}