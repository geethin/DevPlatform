﻿namespace EntityFramework.IdentityModels;

public partial class OpenIddictAuthorization
{
    public OpenIddictAuthorization()
    {
        OpenIddictTokens = new HashSet<OpenIddictToken>();
    }

    public string Id { get; set; } = null!;
    public string? ApplicationId { get; set; }
    public string? ConcurrencyToken { get; set; }
    public DateTime? CreationDate { get; set; }
    public string? Properties { get; set; }
    public string? Scopes { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }

    public virtual OpenIddictApplication? Application { get; set; }
    public virtual ICollection<OpenIddictToken> OpenIddictTokens { get; set; }
}
