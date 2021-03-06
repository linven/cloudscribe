﻿
using cloudscribe.Web.Pagination;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace cloudscribe.Core.IdentityServerIntegration.Models
{
    public class ScopeListViewModel
    {
        public ScopeListViewModel()
        {
            Scopes = new List<Scope>();
            Paging = new PaginationSettings();
        }

        public string SiteId { get; set; } = string.Empty;

        public IList<Scope> Scopes { get; set; }

        public PaginationSettings Paging { get; set; }

    }
}
