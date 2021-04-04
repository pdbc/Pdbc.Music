using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.UnitTest.Helpers.Domain.Model
{
    public class FileInformationTestDataBuilder : FileInformationBuilder
    {
        public FileInformationTestDataBuilder()
        {
            Directory = @"c:\temp";
            Extension = "mp3";
            Filename = "song";

            CurrentFullPath = $"{Directory}\\{Filename}.{Extension}";
        }

    }
}