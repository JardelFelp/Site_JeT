using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JeT.Models
{
    public class Card
    {
        public int _id { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public int students { get; set; }
        public string long_description { get; set; }
        public string short_description { get; set; }
        public List<string> partners { get; set; }
        public ParticipantInstituitions participant_instituitions { get; set; }
    }
}