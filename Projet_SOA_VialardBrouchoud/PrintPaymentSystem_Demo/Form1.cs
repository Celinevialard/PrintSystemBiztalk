using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintPaymentSystem_Demo.ServicePrintPayment;

namespace PrintPaymentSystem_Demo
{
    public partial class Form1 : Form
    {
        private PrintPaymentServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new PrintPaymentServiceClient();

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            // Contrôle s'il s'agit d'un numéro => Selon la donnée : pas de consultation du montant à partir du numéro de carte.
            if (Regex.IsMatch(account, @"^\d+$"))
            {
                MessageBox.Show("Il n'est pas possible de consulter un compte à partir d'un numéro de carte.");
                return;
            }
           
        }
        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;

            //Remplacement du point par la virgule comme séparateur 
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            //Montant arrondi à deux décimales vers le bas
            amount = Math.Floor(amount * 100m) / 100m;

            if (amount <= 0)
            {
                client.RemoveQuota(account, (int)amount);

                MessageBox.Show("Le montant ne peut pas être négatif.");
                return;
            }

           
                client.AddChfByUsername(account, amount);
                MessageBox.Show($"Nous avons ajouté {amount} CHF au compte avec le nom d'utilisateur suivant : {account}.");
            
        }
    }
}
