namespace Csag.WorkloadIdentity.Abstractions
{
    /// <summary>
    /// Provides access tokens for Azure SignalR Service. Wrap it in a <see cref="WorkloadIdentityTokenCredential"/> to
    /// authenticate the Azure SignalR SDK, for example a <c>ServiceEndpoint</c> of the Management SDK.
    /// </summary>
    public interface IAzureSignalRTokenProvider : IAccessTokenProvider
    {
        /// <summary>
        /// Gets a valid access token for Azure SignalR Service.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>The access token as a string.</returns>
        Task<string> GetAzureSignalRAccessTokenAsync(CancellationToken cancellationToken);
    }
}
