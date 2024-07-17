using Trabalho3_carteira.Controller;
using Trabalho3_carteira.Model;
using Trabalho3_carteira.View;

namespace Trabalho3_carteira
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //desabilitei a tela de senha apenas para realizar testes

            //Application.Run(new TelaMovimentacao());


            ApplicationConfiguration.Initialize();
            List<Carteira> carteirauser = new List<Carteira>();
            carteirauser = CarteiraController.vercarteira();

            if (carteirauser.Count == 0)
            {
                TelaInicial ti = new TelaInicial();
                Application.Run(ti);

            }
            else
            {
                Application.Run(new TelaSenha());

            }
            
            
            //Application.Run(new TelaPrincipal());

            
            //To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


        }
    }
}