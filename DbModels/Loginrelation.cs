using System;
using System.Collections.Generic;

namespace CocoaLib.DbModels;

public partial class Loginrelation
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;
}
