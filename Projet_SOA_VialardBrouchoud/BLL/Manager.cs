using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager : IManager
    {
        private const decimal PRINT_PRICE_CHF = 0.08m;
        ISapDB SapDb { get; }
        IPrintAccountDB PrintAccountDb { get; }
        public Manager(ISapDB sapDb, IPrintAccountDB printAccountDb)
        {
            SapDb = sapDb;
            PrintAccountDb = printAccountDb;
        }

        /// <summary>
        /// Calcul permettant de convertir le montant en CHF en quantité d'impressions
        /// </summary>
        /// <param name="amoutChf"></param>
        /// <returns></returns>
        private decimal ConvertChfToQuantity(decimal amoutChf)
        {
            return amoutChf / PRINT_PRICE_CHF;
        }

        /// <summary>
        /// Ajoute un motant en CHF à partir d'un username
        /// </summary>
        /// <param name="username"></param>
        /// <param name="amountChf"></param>
        /// <returns></returns>
        public QuotaReturn AddChfByUsername(string username, decimal amountChf)
        {
            int quota = (int)ConvertChfToQuantity(amountChf);
            return new QuotaReturn()
            {
                username = username,
                quota = quota
            };
        }

        /// <summary>
        /// Ajoute un motant en CHF à partir du cardId
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="amountChf"></param>
        /// <returns></returns>
        public QuotaReturn AddChfByCardId(string cardId, decimal amountChf)
        {
            string username = SapDb.GetUsernameByCardId(cardId);
            int quota = (int) ConvertChfToQuantity(amountChf);
            return new QuotaReturn()
            {
                username = username,
                quota = quota
            };
        }

        public bool CreateUser(string username, string cardId)
        {
            return SapDb.CreateUser(username, cardId);
        }
    }
}
