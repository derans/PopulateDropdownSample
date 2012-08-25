using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PopulateDropdownSample.Helpers.SelectListProviders
{
    public class StateSelectListProvider : ISelectListProvider
    {
        public static List<string> StateAbbreviations = new List<string> { "AE", "AK", "AL", "AP", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "FM", "GA", "GU", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MH", "MI", "MN", "MO", "MP", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "PR", "PW", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VI", "VT", "WA", "WI", "WV", "WY" };
        public IEnumerable<SelectListItem> Provide()
        {
            return StateAbbreviations.Select(x => new SelectListItem {Text = x, Value = x});
        }
    }
}