using System;
using System.Collections.Generic;

namespace SwaggerAPi.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Usernanme { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }
}
