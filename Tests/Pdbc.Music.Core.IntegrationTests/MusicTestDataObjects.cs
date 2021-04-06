﻿using Pdbc.Music.Data;
using Pdbc.Music.Data.Seed;
using Pdbc.Music.Tests.Seed;

namespace Pdbc.Music.Core.IntegrationTests
{
    public class MusicObjects : IHaveDataObjects
    {
        public MusicDataObjects MusicDataObjects { get; private set; }
        public MusicTestsDataObjects MusicTestsDataObjects { get; private set; }

        public MusicObjects(MusicDbContext musicDbContext)
        {
            MusicDataObjects = new MusicDataObjects(musicDbContext);
            MusicTestsDataObjects = new MusicTestsDataObjects(musicDbContext);
        }

        public void LoadObjects()
        {
            MusicDataObjects.LoadObjects();
            MusicTestsDataObjects.LoadObjects();
        }
    }
}