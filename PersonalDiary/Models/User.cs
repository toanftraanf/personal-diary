﻿using System;
using System.Collections.Generic;

namespace PersonalDiary.Models
{
    public partial class User
    {
        public User()
        {
            DiaryEntryCreatedByNavigations = new HashSet<DiaryEntry>();
            DiaryEntryUpdatedByNavigations = new HashSet<DiaryEntry>();
            DiaryEntryUsers = new HashSet<DiaryEntry>();
            SettingCreatedByNavigations = new HashSet<Setting>();
            SettingUpdatedByNavigations = new HashSet<Setting>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? UserRole { get; set; }

        public virtual Setting? UserRoleNavigation { get; set; }
        public virtual ICollection<DiaryEntry> DiaryEntryCreatedByNavigations { get; set; }
        public virtual ICollection<DiaryEntry> DiaryEntryUpdatedByNavigations { get; set; }
        public virtual ICollection<DiaryEntry> DiaryEntryUsers { get; set; }
        public virtual ICollection<Setting> SettingCreatedByNavigations { get; set; }
        public virtual ICollection<Setting> SettingUpdatedByNavigations { get; set; }
    }
}
