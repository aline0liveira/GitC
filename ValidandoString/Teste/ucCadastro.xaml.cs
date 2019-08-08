using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ValidandoString.Teste
{
    /// <summary>
    /// Interação lógica para ucCadastro.xam
    /// </summary>
    public partial class ucCadastro : UserControl
    {
        public ucCadastro()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var email = txtEmail.Text;
            var telefone = txtFone.Text;

            var regEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            var regTel= @"";

            Regex regexEmail = new Regex(regEmail);
                var matchEmail = regexEmail.IsMatch(email);

               Regex regexTel = new Regex(regTel);
               var matchTel = regexTel.IsMatch(telefone);


            if (matchEmail)
            {
                MessageBox.Show("E-mail válido!");
                //matchNumber = MessageBox.Show("Número válido!");
            }
            else
            {
                MessageBox.Show("E-mail inválido!");
            }



            if (matchTel)
            {
                MessageBox.Show("Telefone válido!");
                //matchNumber = MessageBox.Show("Número válido!");
            }
            else
            {
                MessageBox.Show("Telefone inválido!");
            }



        }

        
              

    }
}

