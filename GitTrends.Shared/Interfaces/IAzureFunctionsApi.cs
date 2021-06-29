﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace GitTrends.Shared
{
    [Headers("Accept-Encoding: gzip", "Accept: application/json")]
    public interface IAzureFunctionsApi
    {
        [Get("/GetGitHubClientId")]
        Task<GetGitHubClientIdDTO> GetGitTrendsClientId();

        [Post("/GenerateGitHubOAuthToken")]
        Task<GitHubToken> GenerateGitTrendsOAuthToken([Body(true)] GenerateTokenDTO generateTokenDTO);

        [Get("/GetSyncfusionInformation/{licenseVersion}")]
        Task<SyncFusionDTO> GetSyncfusionInformation(long licenseVersion, [AliasAs("code")] string functionKey = AzureConstants.GetSyncFusionInformationApiKey);

        [Get("/GetTestToken")]
        Task<GitHubToken> GetTestToken([AliasAs("code")] string functionKey = AzureConstants.GetTestTokenApiKey);

        [Get("/GetChartStreamingUrl")]
        Task<StreamingManifest> GetChartStreamingUrl();

        [Get("/GetNotificationHubInformation")]
        Task<NotificationHubInformation> GetNotificationHubInformation([AliasAs("code")] string functionKey = AzureConstants.GetNotificationHubInformationApiKey);

        [Get("/GetLibraries")]
        Task<IReadOnlyList<NuGetPackageModel>> GetLibraries();

        [Get("/GetGitTrendsStatistics")]
        Task<GitTrendsStatisticsDTO> GetGitTrendsStatistics();
    }
}
