﻿using FSH.Framework.Core.Pagination;

namespace FluentPos.Catalog.Core.Products.Dtos;
public class ProductsParametersDto : PaginationParameters
{
    public string? Keyword { get; set; }
}
