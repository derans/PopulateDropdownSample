using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PopulateDropdownSample.Core.Queries;

namespace PopulateDropdownSample.Helpers.SelectListProviders
{
    public class CommunitySelectListProvider : ISelectListProvider
    {
        private readonly IGetCommunitiesQuery _getCommunitiesQuery;

        public CommunitySelectListProvider(IGetCommunitiesQuery getCommunitiesQuery)
        {
            _getCommunitiesQuery = getCommunitiesQuery;
        }

        public IEnumerable<SelectListItem> Provide()
        {
            var communities = _getCommunitiesQuery.Execute();

            return communities.Select(community => new SelectListItem { Text = community.Name, Value = community.CommunityId.ToString() }).ToList();
        }
    }
}