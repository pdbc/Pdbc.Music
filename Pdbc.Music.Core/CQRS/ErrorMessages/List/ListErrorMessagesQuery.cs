namespace Pdbc.Music.Core.CQRS.ErrorMessages.List
{
    public class ListErrorMessagesQuery : IQuery<ListErrorMessagesViewModel>
    {
        public string Language { get; set; }
    }
}