using System;
using System.Collections.Generic;

namespace PersonalDiary.Models
{
    public partial class Setting
    {
        public Setting()
        {
            Users = new HashSet<User>();
        }

        public int SettingId { get; set; }
        public string? SettingGroup { get; set; }
        public string? SettingName { get; set; }
        public int? SettingValue { get; set; }
        public int? DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
