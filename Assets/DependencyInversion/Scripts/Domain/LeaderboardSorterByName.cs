namespace CaseStudyDependencyInversion.Unity.Domain
{
	using CaseStudyDependencyInversion.Unity.Domain.Model;
	using System.Collections.Generic;
	using System.Linq;

	public class LeaderboardSorterByName : IScoreSorter
	{
		public IEnumerable<LeaderboardItem> Sort(FakeLeaderboardProvider leaderboardProvider) =>
			leaderboardProvider.GetItems().OrderBy(i => i.Name);
	}
}
