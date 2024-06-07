using System;
using System.Collections.Generic;

namespace BLL.Models;

public partial class Conformite
{
    public int Id { get; set; }

    public string Libelle { get; set; } = null!;

    public virtual ICollection<Etablissement> Etablissements { get; } = new List<Etablissement>();
}
