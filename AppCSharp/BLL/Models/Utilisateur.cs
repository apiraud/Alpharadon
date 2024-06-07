using System;
using System.Collections.Generic;

namespace BLL.Models;

public partial class Utilisateur
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool EstTechnicien { get; set; }

    public virtual ICollection<Etablissement> Etablissements { get; } = new List<Etablissement>();

    public override string ToString()
    {
        return Nom + " " + Prenom;
    }
}
