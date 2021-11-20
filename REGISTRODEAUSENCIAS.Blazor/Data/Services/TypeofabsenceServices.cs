using REGISTRODEAUSENCIAS.Blazor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Services
{
    public class TypeofabsenceServices
    {
        private readonly DBEMPLEADOSContext _context;

        public TypeofabsenceServices(DBEMPLEADOSContext context) {

            _context = context;
        }

        public List<TypeofabsenceModel> ListType()
        {
            var query = _context.TypeOfAbsences.ToList();

            var list = query.Select(x => new TypeofabsenceModel 
            { 
                Id = x.Id,
                Name = x.Name

            }).ToList();

            return list;
        }
        public TypeofabsenceModel Typeofabsence(int idTypeofabsence)
        {
            var query = _context.TypeOfAbsences
            .Where(x => x.Id == idTypeofabsence)
            .ToList();

            var model = query.Select(x => new TypeofabsenceModel
            {
                Id = x.Id,
                Name = x.Name
            }).FirstOrDefault();

            return model;
        }
        public MsgResult RegisterType(TypeofabsenceModel model)
        {
            var res = new MsgResult();

            var entity = new TypeOfAbsence
            {
                Id = model.Id,
                Name = model.Name
            };

            _context.TypeOfAbsences.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Tipo de ausencia registrado correctamente.";
                res.Code = entity.Id;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar el tipo de ausencia.";
                res.Error = ex;
            }

            return res;
        }
        public MsgResult UpdateType(TypeofabsenceModel model)
        {
            var res = new MsgResult();

            var entity = _context.TypeOfAbsences.FirstOrDefault(x => x.Id == model.Id);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "El tipo de ausencia que intenta modificar no existe.";
                return res;
            }

            entity.Name = model.Name;

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Tipo de ausencia modificado correctamente.";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar el tipo de ausencia.";
                res.Error = ex;
            }

            return res;
        }
        public MsgResult DeleteType(int idTypeofabsence)
        {
            var res = new MsgResult();

            var entity = _context.TypeOfAbsences.FirstOrDefault(x => x.Id == idTypeofabsence);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar el tipo de ausencia porque no existe.";
                return res;
            }

            _context.TypeOfAbsences.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Tipo de ausencia eliminada correctamente.";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar el tipo de ausencia.";
                res.Error = ex;
            }

            return res;
        }
    }
}
