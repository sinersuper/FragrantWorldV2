using System;
using System.Collections.Generic;

namespace FragrantWorld.Modeles;

public partial class Customer
{
    public int ClientOrderId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Patronymic { get; set; }

    public virtual Order ClientOrder { get; set; } = null!;
}
