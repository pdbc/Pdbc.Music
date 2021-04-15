




using Pdbc.Music.Common;
using System;

namespace Pdbc.Music.Core.CQRS.ErrorMessages.Get
{
    public partial class GetErrorMessageQueryBuilder : ObjectBuilder<Pdbc.Music.Core.CQRS.ErrorMessages.Get.GetErrorMessageQuery>
    {
        protected System.String Language { get; set; }
        public GetErrorMessageQueryBuilder WithLanguage(System.String language)
        {
            this.Language = language;
            return this;
        }
        protected System.String Key { get; set; }
        public GetErrorMessageQueryBuilder WithKey(System.String key)
        {
            this.Key = key;
            return this;
        }



        public override GetErrorMessageQuery Build()
        {
            var item = (GetErrorMessageQuery)Activator.CreateInstance(typeof(GetErrorMessageQuery));


            item.Language = Language;


            item.Key = Key;

            return item;
        }

    }
}

namespace Pdbc.Music.Core.CQRS.ErrorMessages.Get
{
    public partial class GetErrorMessageViewModelBuilder : ObjectBuilder<Pdbc.Music.Core.CQRS.ErrorMessages.Get.GetErrorMessageViewModel>
    {
        protected System.String Message { get; set; }
        public GetErrorMessageViewModelBuilder WithMessage(System.String message)
        {
            this.Message = message;
            return this;
        }



        public override GetErrorMessageViewModel Build()
        {
            var item = (GetErrorMessageViewModel)Activator.CreateInstance(typeof(GetErrorMessageViewModel));


            item.Message = Message;

            return item;
        }

    }
}

namespace Pdbc.Music.Core.CQRS.ErrorMessages.List
{
    public partial class ListErrorMessagesQueryBuilder : ObjectBuilder<Pdbc.Music.Core.CQRS.ErrorMessages.List.ListErrorMessagesQuery>
    {
        protected System.String Language { get; set; }
        public ListErrorMessagesQueryBuilder WithLanguage(System.String language)
        {
            this.Language = language;
            return this;
        }



        public override ListErrorMessagesQuery Build()
        {
            var item = (ListErrorMessagesQuery)Activator.CreateInstance(typeof(ListErrorMessagesQuery));


            item.Language = Language;

            return item;
        }

    }
}

namespace Pdbc.Music.Core.CQRS.ErrorMessages.List
{
    public partial class ListErrorMessagesViewModelBuilder : ObjectBuilder<Pdbc.Music.Core.CQRS.ErrorMessages.List.ListErrorMessagesViewModel>
    {
        protected System.Collections.Generic.IDictionary<System.String, System.String> Resources { get; set; }
        public ListErrorMessagesViewModelBuilder WithResources(System.Collections.Generic.IDictionary<System.String, System.String> resources)
        {
            this.Resources = resources;
            return this;
        }



        public override ListErrorMessagesViewModel Build()
        {
            var item = (ListErrorMessagesViewModel)Activator.CreateInstance(typeof(ListErrorMessagesViewModel));


            item.Resources = Resources;

            return item;
        }

    }
}

namespace Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning
{
    public partial class IsServiceRunningQueryBuilder : ObjectBuilder<Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning.IsServiceRunningQuery>
    {



        public override IsServiceRunningQuery Build()
        {
            var item = (IsServiceRunningQuery)Activator.CreateInstance(typeof(IsServiceRunningQuery));

            return item;
        }

    }
}

namespace Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning
{
    public partial class IsServiceRunningViewModelBuilder : ObjectBuilder<Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning.IsServiceRunningViewModel>
    {



        public override IsServiceRunningViewModel Build()
        {
            var item = (IsServiceRunningViewModel)Activator.CreateInstance(typeof(IsServiceRunningViewModel));

            return item;
        }

    }
}
