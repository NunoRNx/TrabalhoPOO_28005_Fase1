using RPG;
namespace RPGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SQL db_connection = SQL.Instance;
            Application.Run(new Menu());
        }
    }
}