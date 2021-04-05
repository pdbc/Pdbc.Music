using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pdbc.Music.Data;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;

namespace Pdbc.Music.Core.IntegrationTests
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
