using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcoPower_Logistics.Service.Services;
using EcoPower_Logistics.Data.Models;

namespace Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;

        public OrdersController(ICustomerService customerService, IOrderService orderService)
        {
            _customerService = customerService;
            _orderService = orderService;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            // Display a list of all orders with customer information.
            ViewData["CustomerId"] = new SelectList(_customerService.GetAllCustomers(), "CustomerId", "CustomerId");
            return View(_orderService.GetAllOrders().ToList());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve order details by ID for viewing, including customer information.
            ViewData["CustomerId"] = new SelectList(_customerService.GetAllCustomers(), "CustomerId", "CustomerId");
            var order = _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            // Display a form to create a new order.
            ViewData["CustomerId"] = new SelectList(_customerService.GetAllCustomers(), "CustomerId", "CustomerId");
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,OrderDate,CustomerId,DeliveryAddress")] Order order)
        {
            // Create a new order.
            _orderService.AddOrder(order);
            return RedirectToAction("Index");
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve order details by ID for editing, including customer information.
            var order = _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            ViewData["CustomerId"] = new SelectList(_customerService.GetAllCustomers(), "CustomerId", "CustomerId");
            return View(order);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,OrderDate,CustomerId,DeliveryAddress")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            try
            {
                // Update order details.
                _orderService.UpdateOrder(order);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(order.OrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve order details by ID for deletion confirmation, including customer information.
            ViewData["CustomerId"] = new SelectList(_customerService.GetAllCustomers(), "CustomerId", "CustomerId");
            var order = _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Delete an order.
            var order = _orderService.GetOrderById(id);
            _orderService.RemoveOrder(order);
            return RedirectToAction("Index");
        }

        private bool OrderExists(int id)
        {
            return _orderService.GetOrderById(id) != null;
        }
    }
}
