using System;
using System.Collections.Generic;

namespace Expert_core.Models;

public partial class CheckIn
{
    public int CheckId { get; set; }

    public int AccountId { get; set; }

    public DateTime CheckDate { get; set; }

    public int CheckPoint { get; set; }

    public virtual MemberAccount Account { get; set; } = null!;
}
