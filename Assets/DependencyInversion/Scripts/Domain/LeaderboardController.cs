
namespace CaseStudyDependencyInversion.Unity.Domain
{
	using CaseStudyDependencyInversion.Unity.Domain.Model;
	using System.Collections.Generic;
	using UnityEngine;

	public class LeaderboardController
	{
		private IScoreSorter _leadBoard;

		public void setSort(IScoreSorter _leadBoardSort){
			this._leadBoard = _leadBoardSort;
		}
		public IEnumerable<LeaderboardItem> GetItems()
		{

			var leaderboardProvider = new FakeLeaderboardProvider();
			//var sortType = PlayerPrefs.GetInt("SortType", 0);

			return _leadBoard.Sort(leaderboardProvider);

			//if (sortType == 0)
			//{
				
				//dip
			//	return _leadBoard.SortByScore(leaderboardProvider);
			//}

			//dip
			//return _leadBoard.SortByName(leaderboardProvider);
		}
	}
}
