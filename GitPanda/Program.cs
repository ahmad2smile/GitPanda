using LibGit2Sharp;
using System;
using System.IO;

namespace GitPanda
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var routeToRepo = "./";

            if (args.Length != 0)
            {
                routeToRepo = args[0];
            }

            var repoDirectory = Path.GetFullPath(routeToRepo);

            try
            {
                using (var repo = new Repository(repoDirectory))
                {
                    var commits = repo.Commits;

                    foreach (var commit in commits)
                    {
                        Console.WriteLine($"Commit: {commit.Message}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
