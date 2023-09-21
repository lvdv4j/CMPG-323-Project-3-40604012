using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using EcoPower_Logistics.Service.Services;
using EcoPower_Logistics.Data.Models;

namespace Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            // Display a list of all products.
            return View(_productService.GetAllProducts().ToList());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve product details by ID for viewing.
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            // Display a form to create a new product.
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductDescription,UnitsInStock")] Product product)
        {
            // Create a new product.
            _productService.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve product details by ID for editing.
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("ProductId,ProductName,ProductDescription,UnitsInStock")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            try
            {
                // Update product details.
                _productService.UpdateProduct(product);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(product.ProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve product details by ID for deletion confirmation.
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            // Delete a product.
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _productService.RemoveProduct(product);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(short id)
        {
            return _productService.GetProductById(id) != null;
        }
    }
}
