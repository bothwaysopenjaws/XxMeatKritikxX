using XxMeatKritikxX.App.Model.DAO;
using XxMeatKritikxX.App.Windows;

namespace XxMeatKritikxX.App
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
            UserDAO userDAO = new UserDAO();
            userDAO.Create(new Model.User("Test)"));
            userDAO.Delete(new Model.User("Test)") { Id = 1});
            Application.Run(new MainForm());
        }
    }
}