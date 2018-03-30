﻿using System.Collections.Generic;
using System.Collections.Specialized;
using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.Storefront.Model.Derivatives
{
    public partial class DerivativeSearchCriteria : PagedSearchCriteria
    {
        private static int _defaultPageSize = 20;

        public static int DefaultPageSize
        {
            get { return _defaultPageSize; }
            set { _defaultPageSize = value; }
        }
        public DerivativeSearchCriteria()
            : base(new NameValueCollection(), _defaultPageSize)
        {
        }

        public DerivativeSearchCriteria(NameValueCollection queryString)
            : base(queryString, DefaultPageSize)
        {
        }

        public IList<DerivativeType> Types { get; set; }
        public bool OnlyActive { get; set; }
        public string SortBy { get; set; }
    }
}
