using System;
using System.Collections.Generic;

namespace Expert_core.Models;

public partial class ResumeSkill
{
    public int ResumeSkillId { get; set; }

    public int SkillId { get; set; }

    public int ResumeId { get; set; }

    public virtual Resume Resume { get; set; } = null!;

    public virtual Skill Skill { get; set; } = null!;
}
