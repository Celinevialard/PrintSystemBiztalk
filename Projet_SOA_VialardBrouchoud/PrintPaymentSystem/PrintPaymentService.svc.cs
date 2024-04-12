using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;
using DAL;
using BLL;
namespace PrintPaymentSystem
{
    public class PrintPaymentService : IPrintPaymentService
    {
        private IManager manager;
        public PrintPaymentService()
        {
            ISapDB sapDB = new SapDB();
            IPrintAccountDB printAccountDB = new PrintAccountDB();
            manager = new Manager(sapDB, printAccountDB);
        }

        /// <summary>
        /// Permet d'ajouter un montant en CHF à partir du cardId
        /// </summary>
        /// <param name="cardId">le numéro de la carte</param>
        /// <param name="chf">le montant en CHF à ajouter</param>
        public QuotaReturn AddChfByCardId(string cardId, decimal chf)
        {
            return manager.AddChfByCardId(cardId, chf);
        }

        /// <summary>
        /// Permet d'ajouter un montant en CHF à partir d'un utilisateur
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <param name="chf">le montant en CHF à ajouter</param>
        public QuotaReturn AddChfByUsername(string username, decimal chf)
        {
            return manager.AddChfByUsername(username, chf);
        }
        
    }
}
