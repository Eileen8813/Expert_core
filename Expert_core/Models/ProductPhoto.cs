using System;
using System.Collections.Generic;

namespace Expert_core.Models;

public partial class ProductPhoto
{
    public int ProductPhotoId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductPhoto1 { get; set; }

    public virtual Product? Product { get; set; }
}
