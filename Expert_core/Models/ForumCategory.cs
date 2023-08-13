using System;
using System.Collections.Generic;

namespace Expert_core.Models;

public partial class ForumCategory
{
    public int CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Depiction { get; set; } = null!;

    public DateTime Created { get; set; }

    public byte[]? Icon { get; set; }

    public bool? IsVisible { get; set; }

    public virtual ICollection<ForumPostCategory> ForumPostCategories { get; set; } = new List<ForumPostCategory>();
}
