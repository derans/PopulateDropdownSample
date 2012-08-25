using System.ComponentModel;
using PopulateDropdownSample.Helpers.Attributes;
using PopulateDropdownSample.Helpers.SelectListProviders;

namespace PopulateDropdownSample.Models
{
    public class HomeModel
    {
        [SelectListProvider(typeof(CommunitySelectListProvider))]
        [DisplayName("Community")]
        public int CommunityId { get; set; }

        [SelectListProvider(typeof(StateSelectListProvider))]
        [DisplayName("State")]
        public string State { get; set; }
    }
}