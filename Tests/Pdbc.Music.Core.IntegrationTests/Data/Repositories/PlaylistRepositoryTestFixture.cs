using System;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class PlaylistRepositoryTestFixture : BaseRepositoryTestFixture<Playlist>
    {
        protected override Playlist CreateExistingItem()
        {
            return new PlaylistTestDataBuilder()
                .Build();
        }

        protected override Playlist CreateNewItem()
        {
            return new PlaylistTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Playlist entity)
        {
            //entity.Name = UnitTestValueGenerator.GenerateRandomCode();
        }
    }
}
