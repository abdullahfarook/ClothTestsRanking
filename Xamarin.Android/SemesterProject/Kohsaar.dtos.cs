/* Options:
Date: 2018-01-24 14:22:40
Version: 5.00
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: http://localhost:52303

//GlobalNamespace: 
//MakePartial: True
//MakeVirtual: True
//MakeInternal: False
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: False
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: True
//ExportValueTypes: False
//IncludeTypes: 
//ExcludeTypes: 
//AddNamespaces: 
//AddDefaultXmlNamespace: http://schemas.servicestack.net/types
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using System.IO;
using Kohsaar.Model.DTO.Core;
using Kohsaar.Model.Entity;
using Kohsaar.DTO;
using Kohsaar.Model.DTO.Catalog;
using Kohsaar.Catalog.Service;


namespace Kohsaar.Catalog.Service
{

    public partial class FindById
        : IReturn<FindByIdResponse>
    {
        public virtual float id { get; set; }
    }

    public partial class FindByIdResponse
    {
    }
}

namespace Kohsaar.DTO
{

    [Route("/admin/catalog/products/find/{Name}", "GET")]
    [Route("/admin/catalog/products/find/{Name}/{Skip}/{Page}", "GET")]
    public partial class FindProductbyName
        : IReturn<FindProductbyNameResponse>
    {
        public virtual string Name { get; set; }
        public virtual int? Skip { get; set; }
        public virtual int? Page { get; set; }
    }

    public partial class FindProductbyNameResponse
    {
        public FindProductbyNameResponse()
        {
            Products = new List<ProductAdminTrim> { };
        }

        public virtual List<ProductAdminTrim> Products { get; set; }
    }

    [Route("/admin/catalog/products", "GET")]
    public partial class GetAllProductsAdmin
        : IReturn<GetAllProductsAdminResponse>
    {
    }

    public partial class GetAllProductsAdminResponse
    {
        public GetAllProductsAdminResponse()
        {
            Products = new List<ProductAdminTrim> { };
        }

        public virtual List<ProductAdminTrim> Products { get; set; }
    }

    public partial class ProductAdminTrim
    {
        public virtual long Id { get; set; }
        public virtual DateTimeOffset CreatedOn { get; set; }
        public virtual bool IsPublished { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsCallForPricing { get; set; }
        public virtual bool IsAllowToOrder { get; set; }
    }
}

namespace Kohsaar.Model.DTO.Catalog
{

    public partial class CatalogCategoryTrim
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual long ParentId { get; set; }
    }

    [Route("/CatalogCategories", "GET")]
    public partial class GetAllCatalogCategory
        : IReturn<GetAllCatalogCategoryResponse>
    {
    }

    public partial class GetAllCatalogCategoryResponse
    {
        public GetAllCatalogCategoryResponse()
        {
            CatalogCategories = new List<CatalogCategoryTrim> { };
        }

        public virtual List<CatalogCategoryTrim> CatalogCategories { get; set; }
        public virtual ResponseStatus Status { get; set; }
    }

    ///<summary>
    ///Product Thumbnail
    ///</summary>
    [Route("/admin/catalog/products/thumbnail", "GET")]
    [Route("/admin/catalog/products/thumbnail/skip/{Skip}", "GET")]
    [Route("/admin/catalog/products/thumbnail/page/{Page}", "GET")]
    [Route("/admin/catalog/products/thumbnail/{Skip}/{Page}", "GET")]
    [Api(Description = "Product Thumbnail")]
    public partial class GetAllCatalogProductsThumbnail
        : IReturn<GetAllCatalogProductsThumbnailResponse>
    {
        public virtual int? Skip { get; set; }
        public virtual int? Page { get; set; }
    }

    public partial class GetAllCatalogProductsThumbnailResponse
    {
        public GetAllCatalogProductsThumbnailResponse()
        {
            ProductThumnails = new List<HomeThumbnail> { };
        }

        public virtual List<HomeThumbnail> ProductThumnails { get; set; }
        public virtual ResponseStatus Status { get; set; }
    }

    [Route("/textile/samples", "GET")]
    public partial class GetTextileSample
        : IReturn<GetTextileSampleResponse>
    {
    }

    public partial class GetTextileSampleResponse
    {
        public GetTextileSampleResponse()
        {
            Samples = new List<Sample> { };
        }

        public virtual List<Sample> Samples { get; set; }
    }

    [Route("/admin/catalog/brands", "GET")]
    public partial class GetVendorCatalogBrand
        : IReturn<GetVendorCatalogBrandResponse>
    {
    }

    public partial class GetVendorCatalogBrandResponse
    {
        public GetVendorCatalogBrandResponse()
        {
            Brands = new List<VendorCatalogBrandTrim> { };
        }

        public virtual List<VendorCatalogBrandTrim> Brands { get; set; }
    }

    [Route("/client/catalog/products/thumbnail", "POST")]
    public partial class PostProduct
        : IReturn<PostProductResponse>
    {
        public PostProduct()
        {
            CategoryIds = new List<long> { };
            Specification = new List<Specification> { };
            ProductImages = new List<PostImage> { };
        }

        public virtual long Id { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal? OldPrice { get; set; }
        public virtual decimal? SpecialPrice { get; set; }
        public virtual bool IsCallForPricing { get; set; }
        public virtual bool IsAllowToOrder { get; set; }
        public virtual bool IsOutOfStock { get; set; }
        public virtual List<long> CategoryIds { get; set; }
        public virtual string Name { get; set; }
        public virtual string SKU { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Specification> Specification { get; set; }
        public virtual bool IsPublished { get; set; }
        public virtual long BrandId { get; set; }
        public virtual PostImage ThumbnailImage { get; set; }
        public virtual List<PostImage> ProductImages { get; set; }
    }

    public partial class PostProductResponse
    {
        public virtual ResponseStatus Status { get; set; }
    }

    public partial class VendorCatalogBrandTrim
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
    }
}

namespace Kohsaar.Model.DTO.Core
{

    public partial class HomeThumbnail
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string SeoTitle { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal? OldPrice { get; set; }
        public virtual string FileName { get; set; }
        public virtual int ReviewsCount { get; set; }
        public virtual string FullContent { get; set; }
    }

    public partial class PostImage
    {
        public virtual string Name { get; set; }
        public virtual float Size { get; set; }
        public virtual string Base64Src { get; set; }
    }

    public partial class Resize
    {
        public virtual string Id { get; set; }
        public virtual string Size { get; set; }
    }
}

namespace Kohsaar.Model.Entity
{

    public partial class Sample
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual float TensileWarp { get; set; }
        public virtual float TensileWeft { get; set; }
        public virtual float TearWarp { get; set; }
        public virtual float TearWeft { get; set; }
        public virtual int Abration { get; set; }
        public virtual float WashingFastness { get; set; }
        public virtual float Value { get; set; }
    }

    public partial class Specification
    {
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }
}

