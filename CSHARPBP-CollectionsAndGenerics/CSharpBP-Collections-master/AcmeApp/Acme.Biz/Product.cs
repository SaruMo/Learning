using Acme.Common;
using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        #region Constructors

        public Product()
        {
            //var ColourOptions = new string[4];
            //ColourOptions[ 0 ] = "Red";
            //ColourOptions[1] = "Espresso";
            //ColourOptions[2] = "White";
            //ColourOptions[3] = "Navy";

            string[] ColourOptions = { "Red", "Espresso", "White", "Navy" };
            
            Console.WriteLine(ColourOptions);
        }
        public Product(int productId,
                        string productName,
                        string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
        }
        #endregion

        #region Properties
        public DateTime? AvailabilityDate { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        private string productName;
        public string ProductName
        {
            get {
                var formattedValue = productName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";

                }
                else
                {
                    productName = value;

                }
            }
        }

        private Vendor productVendor;
        public Vendor ProductVendor
        {
            get {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }

        public string ValidationMessage { get; private set; }

        #endregion

        /// <summary>
        /// Calculates the suggested retail price
        /// </summary>
        /// <param name="markupPercent">Percent used to mark up the cost.</param>
        /// <returns></returns>
        public OperationResult<decimal> CalculateSuggestedPrice( decimal markupPercent )
        {
            var operationResult = new OperationResult<decimal>();
            operationResult.Message = "";
            if ( markupPercent <= 0m )
            {
                operationResult.Message = "Invalid Markup Percentage";
            }
            else if ( markupPercent < 10 )
            {
                operationResult.Message = "Below Recommended Markup Percentage";
            }

            operationResult.Result = this.Cost + (this.Cost * markupPercent / 100);
            return operationResult;
        }
          

        public override string ToString()
        {
            return this.ProductName + " (" + this.ProductId + ")";
        }
    }
}
