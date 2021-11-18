using REGISTRODEAUSENCIAS.Blazor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Services
{
    public class EmployeeServices
    {
        private readonly DBEMPLEADOSContext _context;

        public EmployeeServices(DBEMPLEADOSContext context)
        {
            _context = context;
        }

        public List<EmployeeModel> ListEmployees()
        {
            var query = _context.Employees.ToList();

            var list = query.Select(x => new EmployeeModel
            {
                Id = x.Id,
                Names = x.Names,
                Surnames = x.Surnames

            }).ToList();

            return list;
        }
        public EmployeeModel Employee(int idEmployee)
        {
            var query = _context.Employees
                .Where(x=>x.Id == idEmployee)
                .ToList();

            var model = query.Select(x => new EmployeeModel
            {
                Id = x.Id,
                Names = x.Names,
                Surnames = x.Surnames

            }).FirstOrDefault();

            return model;
        }
        public MsgResult Register(EmployeeModel model)
        {
            var res = new MsgResult();

            //var entity = _context.Employees.FirstOrDefault(x => x.Surnames == model.Surnames);
            //if (entity!=null)
            //{
            //    res.IsSuccess = false;
            //    res.Message = "Ya existe este empleado";
            //    return res;
            //}

            var entity = new Employee
            {
                Names = model.Names,
                Surnames = model.Surnames
            };

            _context.Employees.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Empleado registrado correctamente.";
                res.Code = entity.Id;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar al empleado.";
                res.Error = ex;
            }

            return res;
        }
        public MsgResult Update(EmployeeModel model)
        {
            var res = new MsgResult();

            var entity = _context.Employees.FirstOrDefault(x => x.Id == model.Id);
            
            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "Empleado que intenta modificar no existe.";
                return res; 
            }

            entity.Names = model.Names;
            entity.Surnames = model.Surnames;

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Empleado modificado correctamente.";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar al empleado.";
                res.Error = ex;
            }

            return res;
        }
        public MsgResult Delete(int idEmployee)
        {
            var res = new MsgResult();

            var entity = _context.Employees.FirstOrDefault(x => x.Id == idEmployee);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar al empleado porque no existe.";
                return res;
            }

            _context.Employees.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Empleado eliminado correctamente.";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar al empleado.";
                res.Error = ex;
            }

            return res;
        }
    }
}
