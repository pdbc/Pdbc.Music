using Pdbc.Music.Core.CQRS.Errors.Get;

namespace Pdbc.Music.Core.CQRS.ErrorMessages.Get
{
    public class GetErrorMessageQuery : IQuery<GetErrorMessageViewModel>
    {
        public string Language { get; set; }

        public string Key { get; set; }
    }
}