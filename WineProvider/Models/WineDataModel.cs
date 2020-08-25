using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace WineProvider.Models
{
    [DataContract()]
    public class WineDataModel
    {
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public string Fruit { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public string Tannin { get; set; }
    }
}

