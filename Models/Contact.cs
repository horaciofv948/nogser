﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace nogtstapi.Models;

public partial class Contact
{
    public string FullName { get; set; }

    public string OfficeNumber { get; set; }

    public string Email { get; set; }

    public int? CustomerId { get; set; }

    public virtual Customer Customer { get; set; }
}