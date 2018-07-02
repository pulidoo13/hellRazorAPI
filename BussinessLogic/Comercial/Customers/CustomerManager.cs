using DataContractTormund.Comercial.Branches;
using DataContractTormund.Comercial.Customers;
using DataContractTormund.Dates;
using DataContractTormund.Solution.Users;
using Model.Dates;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BussinessLogic
{
    public static class CustomerManager
    {


        public static List<CustomerDC> customers_search(Model.Configuration.Context _context, CustomerDC customer) {

            var clientes = _context.Customers;

            var clientesfiltrados = clientes.Where
                (p =>
                     (customer.customer_id == 0 || customer.customer_id > 0 && customer.customer_id == p.Id) &&
                     (customer.user_id == 0 || customer.user_id > 0 && customer.user_id == p.User.Id) &&
                     (string.IsNullOrEmpty(customer.customerName) || (!string.IsNullOrEmpty(customer.customerName) && customer.customerName == p.Name)) &&
                     (customer.branch == null || (p.Branch != null && p.Branch.Id == customer.branch.branch_id))

                );

            var selec=clientesfiltrados.Select(p => new CustomerDC
            {
                customer_id = p.Id,
                customerName = p.Name,
                branch = p.Branch != null ? new BranchDC() { branch_id = p.Branch.Id, branchName = p.Branch.Name } : null,
                user_id = p.User != null ? p.User.Id : 0
            }).ToList();

            return selec;
        }

       


    }

}
