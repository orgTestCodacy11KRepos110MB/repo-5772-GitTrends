﻿using System;
using GitTrends.Mobile.Common.Constants;

namespace GitTrends.Mobile.Common
{
	public class MaximumApiRequestsReachedEventArgs : PullToRefreshFailedEventArgs
	{
		public MaximumApiRequestsReachedEventArgs(DateTimeOffset resetDateTime)
			: base(PullToRefreshFailedConstants.UsageLimitExceeded,
					$"{PullToRefreshFailedConstants.GitHubApiLimit}.\n\n{string.Format(PullToRefreshFailedConstants.MinutesReset, GetMinutesRemaining(resetDateTime))}",
					"OK", PullToRefreshFailedConstants.LearnMore)
		{

		}

		public MaximumApiRequestsReachedEventArgs(long resetTime_UnixEpochSeconds) : this(DateTimeOffset.FromUnixTimeSeconds(resetTime_UnixEpochSeconds).ToLocalTime())
		{

		}

		static double GetMinutesRemaining(DateTimeOffset resetDateTime) =>
			Math.Round(resetDateTime.AddMinutes(1).Subtract(DateTimeOffset.UtcNow).TotalMinutes, MidpointRounding.AwayFromZero);
	}
}