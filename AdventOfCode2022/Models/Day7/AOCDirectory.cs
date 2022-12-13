using System.Runtime.CompilerServices;

namespace AdventOfCode2022.Models.Day7
{
    public class AOCDirectory
    {
        public AOCDirectory()
        {
            Directories = new List<AOCDirectory>();
        }

        
        public string DirectoryName { get; set; }

        public List<AOCFile> Files { get; set; }

        public List<AOCDirectory> Directories { get; set; }

        public AOCDirectory Father { get; set; }

        public void AddDirectory(AOCDirectory directory)
        {
            Directories.Add(directory);
        }

        public void AddDirectories(List<AOCDirectory> directories)
        {
            Directories.AddRange(directories);
        }

        public void SetFather(AOCDirectory father)
        {
            Father = father;
        }

        public List<AOCDirectory> GetDirectories()
        {
            if (Directories == null) 
            {
                return new List<AOCDirectory>();
            }

            return Directories.Concat(Directories.SelectMany(d => d.GetDirectories()).ToList()).ToList();
        }

        public double GetSize()
        {
            if (Files == null)
                return 0;

            return Files.Sum(f => f.FileSize) + Directories.Sum(d => d.GetSize());
        }
    }
}
