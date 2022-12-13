namespace FSH.BackEnd.Application.Catalog.Products;

public class ProductByNameSpec : Specification<Product>, ISingleResultSpecification
{
    public ProductByNameSpec(string name) =>
        Query.Where(p => p.Name == name);
}