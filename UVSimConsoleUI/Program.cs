using System;

namespace UVSimConsoleUI
{
    // GIT Tutorial
        // 1. <git pull> - pulls down latest version
        // 2. Do some work
        // 3. <git add .>
        // 4. <git commit -m "Message goes here">
        // 5. <git push>

    // Note: <git status> will give you the current status
    class Program
    {
        static void Main(string[] args)
        {
            UVSim.DisplayUserManual();

            UVSim.AcceptUserProgram();

            UVSim.DisplayRegisterStats();

            UVSim.DisplayMemory();
        }
    }
}
