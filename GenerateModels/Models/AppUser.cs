using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class AppUser
{
    public Guid Id { get; set; }

    public string? NetworkId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public byte? Status { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public byte UserType { get; set; }

    public bool? IsActive { get; set; }
}
