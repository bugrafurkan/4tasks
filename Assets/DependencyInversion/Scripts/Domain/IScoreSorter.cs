namespace CaseStudyDependencyInversion.Unity.Domain
{
using CaseStudyDependencyInversion.Unity.Domain.Model;
using System.Collections.Generic;
using System.Linq;

    public interface IScoreSorter
    {
            IEnumerable<LeaderboardItem> Sort(FakeLeaderboardProvider leaderboardProvider);
    }

}