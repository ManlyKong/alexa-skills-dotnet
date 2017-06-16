﻿using System;
using Newtonsoft.Json;

namespace Alexa.NET.Response.Directive
{
    public class DialogConfirmSlot: IDirective
    {
		[JsonProperty("type")]
        public string Type => "Dialog.ConfirmSlot";

        [JsonProperty("slotToConfirm"),JsonRequired]
        public string SlotName { get; set; }

		[JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
		public Intent UpdatedIntent { get; set; }
    }
}
