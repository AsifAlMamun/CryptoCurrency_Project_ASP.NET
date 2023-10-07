using BLL.DTOs.Admin_DTOs;
using BLL.Services.Admin_Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoinVerse.Controllers.Admin_Controllers
{
    public class TaxReportController : ApiController
    {
        /*[HttpPost]
        [Route("api/admin/taxreport")]

        public HttpResponseMessage GenerateTaxReport(int userId, int taxYear)
        {
            try
            {
                var transactions = db.Transactions
                .Where(t => t.UserId == userId && t.Date.Year == taxYear)
                .ToList();
                decimal totalGains = CalculateGains(transactions);
                decimal totalLosses = CalculateLosses(transactions);

                // Save the tax report
                var taxReport = new TaxReport
                {
                    UserId = userId,
                    TotalGains = totalGains,
                    TotalLosses = totalLosses
                };

                dbContext.TaxReports.Add(taxReport);
                dbContext.SaveChanges();

                return Ok("Tax report generated successfully.");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        public IHttpActionResult GenerateTaxReport(int userId, int taxYear)
        {
            // Retrieve transactions for the specified user and year
            var transactions = dbContext.Transactions
                .Where(t => t.UserId == userId && t.Date.Year == taxYear)
                .ToList();

            // Calculate gains and losses based on transactions
            decimal totalGains = CalculateGains(transactions);
            decimal totalLosses = CalculateLosses(transactions);

            // Save the tax report
            var taxReport = new TaxReport
            {
                UserId = userId,
                TotalGains = totalGains,
                TotalLosses = totalLosses
            };

            dbContext.TaxReports.Add(taxReport);
            dbContext.SaveChanges();

            return Ok("Tax report generated successfully.");
        }

        private decimal CalculateGains(List<> transactions)
        {
            decimal totalGains = 0;

            foreach (var transaction in transactions)
            {
                if (transaction.TransactionType == "sell")
                {
                    // Calculate the gain for this transaction
                    decimal gain = (transaction.Price - GetBuyingPrice(transaction)) * transaction.Amount;
                    totalGains += gain;
                }
            }

            return totalGains;
        }

        private decimal CalculateLosses(List<Transaction> transactions)
        {
            decimal totalLosses = 0;

            foreach (var transaction in transactions)
            {
                if (transaction.TransactionType == "buy")
                {
                    // Calculate the loss for this transaction
                    decimal loss = (GetBuyingPrice(transaction) - transaction.Price) * transaction.Amount;
                    totalLosses += loss;
                }
            }

            return totalLosses;
        }*/
    }
}
