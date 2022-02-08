using System;
using System.Windows.Forms;
using Borker.Controllers;
using Borker.PresentationLayer;
using Borker.MemoryBasedDAL;

namespace Borker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            UserRepository _userRepository = new UserRepository();
            BorkerRepository _borkerRepository = new BorkerRepository();

            MainFormController mainController = new MainFormController(_borkerRepository, _userRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm(mainController));
        }
    }
}
