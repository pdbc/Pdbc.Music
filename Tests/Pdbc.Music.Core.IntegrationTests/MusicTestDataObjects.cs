using Pdbc.Music.Data;
using Pdbc.Music.Data.Seed;

namespace Pdbc.Music.Core.IntegrationTests
{
    public class MusicTestDataObjects : IHaveDataObjects
    {
        public MusicDataObjects MusicDataObjects { get; private set; }

        public MusicTestDataObjects(MusicDbContext musicDbContext)
        {
            MusicDataObjects = new MusicDataObjects(musicDbContext);
        }

        public void LoadObjects()
        {
            MusicDataObjects.LoadObjects();
        }
    }
}