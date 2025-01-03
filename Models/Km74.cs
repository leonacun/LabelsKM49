﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Labels_KM49.Models;

[Table("KM74")]
public partial class Km74
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public long? Sequence { get; set; }

    [Unicode(false)]
    public string Vin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Creation { get; set; }

    [Unicode(false)]
    public string FullVin { get; set; }

    [Unicode(false)]
    public string Color { get; set; }

    [Unicode(false)]
    public string Type { get; set; }

    [Unicode(false)]
    public string Enviado { get; set; }

    [Column("NEmpleado")]
    public int? Nempleado { get; set; }

    [Unicode(false)]
    public string NoParte { get; set; }

    [Unicode(false)]
    public string FrtLwrFascia { get; set; }

    [Unicode(false)]
    public string RrLwrFascia { get; set; }

    [Unicode(false)]
    public string FrUppEyeBrow { get; set; }
}