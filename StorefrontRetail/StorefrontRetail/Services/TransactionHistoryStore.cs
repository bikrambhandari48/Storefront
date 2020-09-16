using System;
using System.Collections.Generic;
using System.Text;
using StorefrontRetail.Models;

namespace StorefrontRetail.Services
{
    public class TransactionHistoryStore
    {
        public TransactionHistory GetTransactions()
        {
            TransactionHistory transaction = new TransactionHistory
            {
                ShowDescriptionColumn = true,
                ShowQuantityColumn = true,
                ShowDateRaisedColumn = true,
                ShowExtensionColumn = true,
                ShowTransactionNumberColumn = true,
                TransactionHistories = new List<History>
                {
                    new History
                    {
                        DateRaised = DateTime.Now.ToShortDateString(),
                        Description = "SMITH CHIPS ",
                        Extension = 2.25M,
                        FormattedExtension = 2.25.ToString("C"),
                        Quantity = 2,
                        TransactionNumber = "1234"
                    },
                    new History
                    {
                        DateRaised = DateTime.Now.ToShortDateString(),
                        Description = "SMITH CHIPS ",
                        Extension = 2.25M,
                        FormattedExtension = 2.25.ToString("C"),
                        Quantity = 2,
                        TransactionNumber = "1234"
                    },
                    new History
                    {
                        DateRaised = DateTime.Now.ToShortDateString(),
                        Description = "SMITH CHIPS ",
                        Extension = 2.25M,
                        FormattedExtension = 2.25.ToString("C"),
                        Quantity = 2,
                        TransactionNumber = "1234"
                    }
                }
            };

            return transaction;
        }
    }
}