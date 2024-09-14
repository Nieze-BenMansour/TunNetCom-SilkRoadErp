﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TunNetCom.SilkRoadErp.Sales.Domain.Entites;

public partial class Produit
{
    public string Refe { get; private set; } = null!;

    public string Nom { get; private set; } = null!;

    public int Qte { get; private set; }

    public int QteLimite { get; private set; }

    public double Remise { get; private set; }

    public double RemiseAchat { get; private set; }

    public double Tva { get; private set; }

    public decimal Prix { get; private set; }

    public decimal PrixAchat { get; private set; }

    public bool Visibilite { get; private set; }

    public virtual ICollection<LigneAvoirFournisseur> LigneAvoirFournisseur { get; set; } = new List<LigneAvoirFournisseur>();

    public virtual ICollection<LigneAvoirs> LigneAvoirs { get; set; } = new List<LigneAvoirs>();

    public virtual ICollection<LigneBl> LigneBl { get; set; } = new List<LigneBl>();

    public virtual ICollection<LigneBonReception> LigneBonReception { get; set; } = new List<LigneBonReception>();

    public virtual ICollection<LigneCommandes> LigneCommandes { get; set; } = new List<LigneCommandes>();

    public virtual ICollection<LigneDevis> LigneDevis { get; set; } = new List<LigneDevis>();
}