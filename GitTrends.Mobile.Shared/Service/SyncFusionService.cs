﻿using System.ComponentModel;
using System.Threading.Tasks;
using GitTrends.Shared;
using Xamarin.Essentials;

namespace GitTrends.Mobile.Shared
{
    public static class SyncFusionService
    {
        public static async Task Initialize()
        {
#if __IOS__
            Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer.Init();
#endif
            string syncFusionLicense;

            try
            {
                var syncFusionDto = await AzureFunctionsApiService.GetSyncFusionInformation().ConfigureAwait(false);

                syncFusionLicense = syncFusionDto.License;

                await SaveSyncFusionLicense(syncFusionLicense).ConfigureAwait(false);
            }
            catch
            {
                syncFusionLicense = await GetSyncFusionLicense().ConfigureAwait(false);
            }

            if (!string.IsNullOrWhiteSpace(syncFusionLicense))
                Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncFusionLicense);
        }

        public static Task<string> GetSyncFusionLicense() => SecureStorage.GetAsync(nameof(SyncFusionDTO.License));

        static Task SaveSyncFusionLicense(string license) => SecureStorage.SetAsync(nameof(SyncFusionDTO.License), license);
    }
}
