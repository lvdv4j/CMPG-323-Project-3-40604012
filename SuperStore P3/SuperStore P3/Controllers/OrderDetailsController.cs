using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Service.Services;

namespace Controllers
{
    [Authorize]
    public class OrderDetailsController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IOrderDetailsService _orderDetailsService;

        public OrderDetailsController(IOrderService orderService, IProductService productService, IOrderDetailsService orderDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _orderDetailsService = orderDetailsService;
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index()
        {
            // Display a list of all order details.
            var orderDetails = _orderDetailsService.GetAllOrderDetails();
            return View(orderDetails);
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve order detail by ID for viewing.
            var orderDetail = _orderDetailsService.GetOrderDetailById(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public IActionResult Create()
        {
            // Display a form to create a new order detail.
            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId");
            return View();
        }

        // POST: OrderDetails/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailsId,OrderId,ProductId,Quantity,Discount")] OrderDetail orderDetail)
        {
            // Create a new order detail.
            if (ModelState.IsValid)
            {
                _orderDetailsService.AddOrderDetail(orderDetail);
                return RedirectToAction(nameof(Index));
            }

            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve order detail by ID for editing.
            var orderDetail = _orderDetailsService.GetOrderDetailById(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("OrderDetailsId,OrderId,ProductId,Quantity,Discount")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailsId)
            {
                return NotFound();
            }

            // Update order detail.
            if (ModelState.IsValid)
            {
                try
                {
                    _orderDetailsService.UpdateOrderDetail(orderDetail);
                }
                catch
                {
                    if (!OrderDetailExists(orderDetail.OrderDetailsId))
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

            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve order detail by ID for deletion confirmation.
            var orderDetail = _orderDetailsService.GetOrderDetailById(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            // Delete an order detail.
            var orderDetail = _orderDetailsService.GetOrderDetailById(id);

            if (orderDetail != null)
            {
                _orderDetailsService.RemoveOrderDetail(orderDetail);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailExists(short id)
        {
            return _orderDetailsService.GetOrderDetailById(id) != null;
        }
    }
}
