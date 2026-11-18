---
"@neolution-ch/csag-workload-identity": minor
---

Add Azure SignalR Service as a third resource. The new `AzureSignalR` section has the same shape as `AzureSql` and `BlobStorage`, and `IAzureSignalRTokenProvider` returns access tokens for the scope `https://signalr.azure.com/.default`. The background refresh keeps its token fresh like those of the other resources.

Wrap the provider in `WorkloadIdentityTokenCredential` to authenticate the Azure SignalR Management SDK with a `ServiceEndpoint(Uri, TokenCredential)` instead of an access key. Resources that name the same identity share one credential, so an application on Cloud Run can use the identity it already has for Azure SQL. The identity needs the roles **SignalR REST API Owner** and **SignalR App Server** on the SignalR resource to publish and to negotiate client connections. The setup guide describes them.
