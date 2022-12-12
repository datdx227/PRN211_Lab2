using System;
using System.Collections.Generic;

namespace Dictionary_EF.Models
{
    public partial class Dictionary
    {
        public int WordId { get; set; }
        public string Word { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public string Meaning { get; set; } = null!;
        public int Id { get; set; }

        public virtual WordType IdNavigation { get; set; } = null!;
    }
}
