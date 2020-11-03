using System;

namespace Common.Models
{
    /// <summary>
    /// Just inheriting the IMyMessage here.  for future stuff. the Writing would be done at the API and handled accorningly . 
    /// </summary>
    public class MyMessage :IMyMessage
    {

        public string Greeting { get; set; } = "Greeting not set";
            
    }
}
