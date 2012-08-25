using System.Collections.Generic;

namespace PopulateDropdownSample.Core.Queries
{
    public interface IGetCommunitiesQuery
    {
        IEnumerable<CommunityInfo> Execute();
    }

    public class GetCommunitiesQuery : IGetCommunitiesQuery
    {
        public IEnumerable<CommunityInfo> Execute()
        {
            //Assume DB call here
            return new List<CommunityInfo>
                       {
                           new CommunityInfo {CommunityId = 1, Name = "Community 1"},
                           new CommunityInfo {CommunityId = 2, Name = "Community 2"},
                           new CommunityInfo {CommunityId = 3, Name = "Community 3"},
                           new CommunityInfo {CommunityId = 4, Name = "Community 4"},
                           new CommunityInfo {CommunityId = 5, Name = "Community 5"},
                       };
        } 
    }

    public class CommunityInfo
    {
        public int CommunityId { get; set; }
        public string Name { get; set; }
    }
}