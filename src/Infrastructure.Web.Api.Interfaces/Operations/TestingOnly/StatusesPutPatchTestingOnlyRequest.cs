#if TESTINGONLY
using JetBrains.Annotations;

namespace Infrastructure.Web.Api.Interfaces.Operations.TestingOnly;

[Route("/testingonly/statuses/putpatch", ServiceOperation.PutPatch, true)]
[UsedImplicitly]
public class StatusesPutPatchTestingOnlyRequest : IWebRequest<StatusesTestingOnlyResponse>
{
}
#endif