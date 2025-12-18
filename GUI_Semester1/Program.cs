using GUI_Semester1.Tambahan;
using GUI_Semester1.week13;
using GUI_Semester1.week13B;
using GUI_Semester1.week14A;
using GUI_Semester1.week14B;

namespace GUI_Semester1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDataProduk());
        }
    }
}