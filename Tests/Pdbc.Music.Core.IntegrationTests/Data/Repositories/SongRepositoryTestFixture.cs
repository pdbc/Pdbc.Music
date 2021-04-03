﻿using System;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class SongRepositoryTestFixture : BaseRepositoryTestFixture<Song>
    {
        protected override Song CreateExistingItem()
        {
            return new SongTestDataBuilder()
                .Build();
        }

        protected override Song CreateNewItem()
        {
            return new SongTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Song entity)
        {
            //entity.Name = UnitTestValueGenerator.GenerateRandomCode();
        }
    }
}
