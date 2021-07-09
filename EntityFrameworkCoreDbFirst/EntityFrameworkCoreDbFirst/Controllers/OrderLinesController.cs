using EntityFrameworkCoreDbFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCoreDbFirst.Controllers {
    public class OrderLinesController {
        readonly AppDbContext _context;

        public List<OrderLine> GetAll() {
            return _context.OrderLines.ToList();
        }

        public OrderLine GetById(int id) {
            return _context.OrderLines.Find(id);
        }

        public OrderLine Add(OrderLine orderLine) {
            if (orderLine == null) {
                return null;
            }
            _context.OrderLines.Add(orderLine);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                return null;
            }
            return orderLine;
        }

        public bool Update(OrderLine orderLine) {
            if (orderLine == null) {
                return false;
            }
            _context.Entry(orderLine).State = EntityState.Modified;
            var rc = _context.SaveChanges();
            if (rc != 1) {
                return false;
            }
            return true;
        }

        public OrderLine Delete(int Id) {
            var orderLine = _context.OrderLines.Find(Id);
            if (orderLine == null) {
                return null;
            }
            _context.Remove(orderLine);
            var rc = _context.SaveChanges();
            if (rc != 1) {
                return null;
            }
            return orderLine;

        }



        public OrderLinesController() {
            _context = new AppDbContext();
        }
    }
}