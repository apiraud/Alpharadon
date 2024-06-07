using System;
using System.Collections.Generic;

namespace BLL.Models;

public partial class Etablissement
{
    public int Id { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public string FormeJuridique { get; set; } = null!;

    public string Siret { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public int? IdConformite { get; set; }

    public int IdTechnicien { get; set; }

    public virtual ICollection<Detecteur> Detecteurs { get; } = new List<Detecteur>();

    public virtual Conformite? IdConformiteNavigation { get; set; }

    public virtual Utilisateur IdTechnicienNavigation { get; set; } = null!;

    public override string ToString()
    {
        return RaisonSociale;
    }
}
