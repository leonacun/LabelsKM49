﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Labels_KM49.Models;

[Table("KM49_FA")]
public partial class Km49Fa
{
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

    [Key]
    [Column("id")]
    public int Id { get; set; }
}