﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TunNetCom.SilkRoadErp.Sales.Domain.Entites;

public partial class AvoirFournisseur
{
    public int Num { get; set; }

    public DateTime Date { get; set; }

    public int? FournisseurId { get; set; }

    public int? NumFactureAvoirFournisseur { get; set; }

    public int NumAvoirFournisseur { get; set; }

    public virtual Fournisseur? Fournisseur { get; set; }

    public virtual ICollection<LigneAvoirFournisseur> LigneAvoirFournisseur { get; set; } = new List<LigneAvoirFournisseur>();

    public virtual FactureAvoirFournisseur? NumFactureAvoirFournisseurNavigation { get; set; }
}