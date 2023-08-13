using System;
using System.Collections.Generic;

namespace Expert_core.Models;

public partial class ExpertWorkList
{
    public int WorksListId { get; set; }

    public int? WorksId { get; set; }

    public int? ResumeId { get; set; }

    public virtual ExpertResume? Resume { get; set; }

    public virtual ExpertWork? Works { get; set; }
}
