using DataContractTormund.Comercial.Branches;
using DataContractTormund.Comercial.Customers;
using DataContractTormund.Comercial.Services;
using DataContractTormund.Dates;
using DataContractTormund.HumanResource.Employees;
using DataContractTormund.Solution.Users;
using Model.Dates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLogic.Dates
{
   public static class DatesManager
    {

             
        public static List<DateDC> dates_search(Model.Configuration.Context _context, DateDC date)
        {

            var dates = _context.Dates;

            var datesFiltrados = dates.Where
                (p =>
                     (date.Id == 0 || date.Id > 0 && date.Id == p.Id) &&
                     (date.Customer_id == 0 || date.Customer_id > 0 && date.Customer_id == p.Customer.Id)

                );

           

            var selec = datesFiltrados.Select(p => new DateDC
            {
                Id = p.Id,
                Description = p.Description,
                Branch = p.Branch != null ? new BranchDC() { branch_id = p.Branch.Id, branchName = p.Branch.Name } : null,
                AppointmentDate = p.AppointmentDate,
                DueDate = p.DueDate,
                CreatedBy = p.CreatedBy != null ? new UserDC() { user_id = p.CreatedBy.Id, name = p.CreatedBy.Name } : null,
                ModifiedBy = p.ModifiedBy != null ? new UserDC() { user_id = p.ModifiedBy.Id, name = p.ModifiedBy.Name } : null,
                LastModified = p.LastModified,
                Customer_id=p.Customer!=null?p.Customer.Id:0,
                Employee_id=p.Employee!=null?p.Employee.Id:0,
                Branch_id = p.Branch != null ? p.Branch.Id : 0,
                Status=(int)p.Status,
                Service=(p.Service!=null ?new ServiceDC() {service_id=p.Service.Id,name=p.Service.Name,cost= p.Service.Cost,price=p.Service.Price}:null),
                Employee = (p.Employee != null ? new EmployeeDC() { employee_id = p.Employee.Id, employeeName = p.Employee.Name } : null)


            }).ToList();

            return selec;
        }

        public static List<DateDC> date_newPending(Model.Configuration.Context _context, DateDC dateDC)
        {
            var date = new Date();
            if (dateDC.AppointmentDate > DateTime.MinValue)
            {
                date.AppointmentDate = dateDC.AppointmentDate;
            }
            if (dateDC.DueDate > DateTime.MinValue)
            {
                date.DueDate = dateDC.DueDate;
            }
            if (!string.IsNullOrEmpty(date.FromApp))
            {
                date.FromApp = dateDC.FromApp;
            }
            if (dateDC.Customer_id > 0)
            {
                var customer = _context.Customers.FirstOrDefault(p => p.Id == dateDC.Customer_id);
                if (customer != null)
                {
                    date.Customer = customer;
                }
            }
            if (dateDC.Branch_id > 0)
            {
                var branch = _context.Branches.FirstOrDefault(p => p.Id == dateDC.Branch_id);
                if (branch != null)
                {
                    date.Branch = branch;
                }
            }
            if (dateDC.Employee_id > 0)
            {
                var employee = _context.Employees.FirstOrDefault(p => p.Id == dateDC.Employee_id);
                if (employee != null)
                {
                    date.Employee = employee;
                }
            }

            date.CreationDate = DateTime.Now;
            date.Status = Status.Pending;
            _context.Dates.Add(date);
            _context.SaveChanges();
            _context.Entry(date).Reload();
            var list = new List<DateDC>();
            list.Add(new DateDC() { Id = date.Id, AppointmentDate = date.AppointmentDate, CreationDate = date.CreationDate, Description = date.Description });
            return list;


        }

        public static List<DateDC> dates_update(Model.Configuration.Context _context, DateDC dateDC)
        {
            var dates = _context.Dates;
            var list = new List<DateDC>();
            var datesFilter = dates.Where
                (p =>
                     (dateDC.Id == p.Id)

                );

            var date = datesFilter.FirstOrDefault();
            if (date != null)
            {
                if (dateDC.Customer_id > 0)
                {
                    var customer = _context.Customers.FirstOrDefault(p => p.Id == dateDC.Customer_id);
                    if (customer != null)
                    {
                        date.Customer = customer;
                    }
                }
                if (dateDC.Branch_id > 0)
                {
                    var branch = _context.Branches.FirstOrDefault(p => p.Id == dateDC.Branch_id);
                    if (branch != null)
                    {
                        date.Branch = branch;
                    }
                }
                if (dateDC.Employee_id > 0)
                {
                    var employee = _context.Employees.FirstOrDefault(p => p.Id == dateDC.Employee_id);
                    if (employee != null)
                    {
                        date.Employee = employee;
                    }
                }

                date.AppointmentDate = dateDC.AppointmentDate;
                date.Description = dateDC.Description;
                date.FromApp = dateDC.FromApp;
                date.LastModified = DateTime.Today;
                if (dateDC.Status > 0) {
                    date.Status = (Status)dateDC.Status;
                }
                

                _context.SaveChanges();
                _context.Entry(date).Reload();



                list.Add(new DateDC() { Id = date.Id
                                        , AppointmentDate = date.AppointmentDate
                                        , CreationDate = date.CreationDate
                                        , Description = date.Description
                                        ,FromApp=date.FromApp
                                        ,Customer_id = date.Customer.Id

                });
                return list;
            }


            return list;


        }


    }
}
