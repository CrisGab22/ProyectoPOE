using ProyectoPOE.Presentacion.Pantallas;

namespace ProyectoPOE
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
            var login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                login.Close();
                Application.Run(new frmMenuAdministrador());
            }
        }
    }
}