using System;
using System.Collections.Generic;

namespace PersonalDiary.Models
{
    public partial class DiaryEntry
    {
        public int EntryId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
