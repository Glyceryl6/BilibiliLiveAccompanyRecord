using System;
using System.Reflection;
using System.Windows.Forms;

namespace BilibiliLiveAccompanyRecord {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => {
                string resourceName = "BilibiliLiveAccompanyRecord." + new AssemblyName(args.Name).Name + ".dll";
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)) {
                    byte[] assemblyData = new byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}