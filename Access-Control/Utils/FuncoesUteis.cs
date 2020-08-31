using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neomot_Access_Control.Screens;

namespace Neomot_Access_Control.Utils {
    class FuncoesUteis {

        //função que coverte DateTime para long
        public static long ConvertToTimestamp(DateTime value) {
            DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            TimeSpan elapsedTime = value - Epoch;
            return (long)elapsedTime.TotalSeconds;// + 10800;
        }

        //função que necerra a aplicação
        public void FecharAplicacao(FormClosingEventArgs e) {
            if (MessageBox.Show("Você quer mesmo fechar o programa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Environment.Exit(0);
            }
            else {
                e.Cancel = true;
            }                                                                                
        }

        //função que formata um texto comum (com números) para um texto de CPF
        public string FormataCPF(string CPF, int keyCode) {
            if (CPF.Length == 3 || CPF.Length == 7)                                                             //verifca se o comprimento do textBox do CPF é igual a 3 ou 7 
                CPF += ".";                                                                                     //insere '.' no final do texto do CPF
            else if ((CPF.Length == 11) && (keyCode != 8))                                                      //verifica se o comprimento do textBox do CPF é igual a 11 e se não foi utilizado 'backspace' para isso
                CPF += "-";                                                                                     //insere '-' no final do txto do CPF
            
            return CPF;                                                                                         //retorna o texto do CPF já formatado
        }

        //função que sublinha e muda de cor o texto de um label 
        public void FormataLabelMouseEnter(Label label) {
            label.Font = new Font(label.Font, FontStyle.Underline);                                             //sublinha o texto do label
            label.ForeColor = Color.FromArgb(36, 52, 92);                                                       //coloca a cor (36,52,92) no texto do label 
        }

        //função que tira o sublinhado e muda de cor o texto de um albel
        public void FormataLabelMouseLeave(Label label) {
            label.Font = new Font(label.Font, FontStyle.Regular);                                               //tira o sublinhado do texto do label
            label.ForeColor = Color.FromArgb(71, 136, 199);                                                     //coloca a cor (71,136,199) no texto do label
        }


    }
}
