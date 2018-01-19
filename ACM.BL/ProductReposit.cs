using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductReposit
    {
        public Product Retrieve(int productId)
        {
           Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.96M;
            }
           return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges && product.IsValid)
            {
                if(product.IsNew)
                {

                }
                else
                {

                }
            }
            return success;

        }

       
    }
}
