﻿using System.Text;

namespace SmsGateway.MeApiWrapper.Responses {
  public class MessageResponse : SingleResult<Message> {
    
    public string PrettyPrint() {
      if (success) {
        var str = new StringBuilder();
        str.AppendLine("--------------------------------------------------------------------------------");
        str.AppendLine("Device");
        str.Append(result.PrettyPrint());

        return str.ToString();
      }

      return "error";
    }
  }
}