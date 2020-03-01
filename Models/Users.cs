using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public byte[] Nick { get; set; }
        public byte[] Password { get; set; }
    }
}
