using System.Collections.Generic;
using System.Web.Mvc;

namespace PopulateDropdownSample.Helpers.SelectListProviders
{
    public interface ISelectListProvider
    {
        IEnumerable<SelectListItem> Provide();
    }
}