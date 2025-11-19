using eCommerce.BusinessLogicLayer.DTO;
using eCommerce.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace eCommerce.BusinessLogicLayer.ServiceContracts;

public interface IProductsService
{
    Task<List<ProductResponse?>> GetProducts();
    Task<List<ProductResponse?>> GetProductsByCondition(Expression<Func<Product, bool>> conditionExpresssion);
    Task<ProductResponse?> GetProductByCondition(Expression<Func<Product, bool>> conditionExpression);
    Task<ProductResponse?> AddProduct(ProductAddRequest productAddRequest);
    Task<ProductResponse?> UpdateProduct(ProductUpdateRequest productUpdateRequest);
    Task<bool> DeleteProduct(Guid productID);
}
