﻿using System;
using Newtonsoft.Json;

namespace faceTodoApplication.Models
{
    [JsonObject]
    public class TodoDetail
    {
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}