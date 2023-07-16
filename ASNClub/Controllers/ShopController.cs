﻿using ASNClub.Services.CategoryServices.Contracts;
using ASNClub.Services.ColorServices.Contracts;
using ASNClub.Services.Models;
using ASNClub.Services.ProductServices.Contracts;
using ASNClub.Services.TypeServices.Contracts;
using ASNClub.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace ASNClub.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IColorService colorService;
        private readonly ITypeService typeService;
        public ShopController(IProductService _productService, ICategoryService _categoryService, IColorService _colorService, ITypeService _typeService)
        {
            this.productService = _productService;
            this.categoryService = _categoryService;
            this.colorService = _colorService;
            this.typeService = _typeService;
        }
        public async Task<IActionResult> All([FromQuery] AllProductQueryModel queryModel)
        {
            AllProductsSortedModel serviceModel = await productService.GetAllProductsAsync(queryModel);
            queryModel.Products = serviceModel.Products;
            queryModel.TotalProducts = serviceModel.TotalProducts;
            queryModel.Categories = await categoryService.AllCategoryNamesAsync();
            queryModel.Types = await typeService.AllTypeNamesAsync();
            queryModel.Makes = await productService.AllMakeNamesAsync();
            if (queryModel.Make != null)
            {
                queryModel.Models = await productService.AllModelNamesAsync(queryModel.Make);
            }
            return this.View(queryModel);
        }
        public async Task<IActionResult> Details (int id)
        {
            var model = await productService.GetProductDetails(id);

            return this.View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ProductFormModel formModel = new ProductFormModel();
            formModel.Categories = await categoryService.AllCategoriesAsync();
            formModel.Colors = await colorService.AllColorsAsync();
            formModel.Types = await typeService.AllTypesAsync();
            return this.View(formModel);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                formModel.Categories = await categoryService.AllCategoriesAsync();
                formModel.Colors = await colorService.AllColorsAsync();
                formModel.Types = await typeService.AllTypesAsync();
                return this.View(formModel);
            }
            await productService.AddProductAsync(formModel);
            return RedirectToAction("All");
        }
    }
}
