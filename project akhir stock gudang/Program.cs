namespace project_akhir_stock_gudang
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
            Application.Run(new Form1());

            Application.SetUnhandledExceptionMode(
               UnhandledExceptionMode.CatchException
           );

            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show(
                    e.Exception.ToString(),
                    "Kesalahan Aplikasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = e.ExceptionObject as Exception;

                MessageBox.Show(
                    ex?.ToString() ?? e.ExceptionObject.ToString(),
                    "Kesalahan Sistem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            };

            try
            {
                ApplicationConfiguration.Initialize();

               
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error Saat Membuka Aplikasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

       
    }
}