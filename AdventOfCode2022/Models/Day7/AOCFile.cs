namespace AdventOfCode2022.Models.Day7
{
    public class AOCFile
    {
        public string FileName { get; set; }

        public double FileSize { get; set; }

        public AOCDirectory Father { get; set; }
    }
}
