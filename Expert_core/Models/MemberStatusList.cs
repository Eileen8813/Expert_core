using System;
using System.Collections.Generic;

namespace Expert_core.Models;

public partial class MemberStatusList
{
    public int StatusChangeId { get; set; }

    public int AccountId { get; set; }

    public int UpdateUser { get; set; }

    public DateTime UpdateTime { get; set; }

    public int StatusChangeReasonId { get; set; }

    public virtual StatusChangeReasonList StatusChangeReason { get; set; } = null!;

    public virtual MemberAccount UpdateUserNavigation { get; set; } = null!;
}
