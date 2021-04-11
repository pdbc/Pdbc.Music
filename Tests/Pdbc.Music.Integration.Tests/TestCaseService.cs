using Pdbc.Music.Data;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;

namespace Pdbc.Music.Integration.Tests
{
    public class TestCaseService
    {
        private readonly MusicDbContext _context;

        public TestCaseService(MusicDbContext context)
        {
            _context = context;
        }

        public FileInformation SetupFileInformation(Song song)
        {
            var fileInformation = new FileInformationTestDataBuilder()
                .WithSong(song)
                .Build();

            _context.FileInformations.Add(fileInformation);
            _context.SaveChanges();

            return fileInformation;
        }
    }
}
