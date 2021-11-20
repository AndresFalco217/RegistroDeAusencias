using REGISTRODEAUSENCIAS.Blazor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Services
{
    public class AbsenceServices
    {
        private readonly DBEMPLEADOSContext _context;

        public AbsenceServices(DBEMPLEADOSContext context)
        {
            _context = context;
        }


        public AbsenceModel Absence(int idAbsence)
        {
            var model = _context.Absences
            .Where(x => x.Id == idAbsence)
            .Select(x => new AbsenceModel
            {
                Id = x.Id,
                IdEmployee = x.IdEmployee,
                Date = x.Date,
                IdAbsence = x.IdAbsence,
                Hours = x.Hours,
                ObservationsObservationsObservations = x.ObservationsObservationsObservations

            }).FirstOrDefault();

            return model;
        }
        public List<AbsenceModel> ListAsence()
        {
            var model = _context.Absences
            .Select(x => new AbsenceModel
            {
                Id = x.Id,
                IdEmployee = x.IdEmployee,
                Date = x.Date,
                IdAbsence = x.IdAbsence,
                Hours = x.Hours,
                ObservationsObservationsObservations = x.ObservationsObservationsObservations

            }).ToList();

            return model;
        }
        public MsgResult RegisterAbsence(AbsenceModel model)
        {
            var result = new MsgResult();
            var entity = new Absence
            {
                IdEmployee = model.IdEmployee,
                Date = model.Date,
                IdAbsence = model.IdAbsence,
                Hours = model.Hours,
                ObservationsObservationsObservations = model.ObservationsObservationsObservations
            };

            _context.Absences.Add(entity);

            try
            {
                _context.SaveChanges();

                result.IsSuccess = true;
                result.Message = "ausencia registrado correctamente.";
                result.Code = entity.Id;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Error al registrar la ausencia.";
                result.Error = ex;
            }

            return result;
        }
        public MsgResult UpdateAbsence(AbsenceModel model)
        {
            var result = new MsgResult();
            var entity = _context.Absences.FirstOrDefault(x => x.Id == model.Id);

            entity.IdEmployee = model.IdEmployee;
            entity.Date = model.Date;
            entity.IdAbsence = model.IdAbsence;
            entity.Hours = model.Hours;
            entity.ObservationsObservationsObservations = model.ObservationsObservationsObservations;

            try
            {
                _context.SaveChanges();

                result.IsSuccess = true;
                result.Message = "ausencia modificada correctamente.";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Error al modificar la ausencia.";
                result.Error = ex;
            }

            return result;
        }
        public MsgResult DeleteAbsence(int idAbsence)
        {
            var result = new MsgResult();

            var entity = _context.Absences.FirstOrDefault(x => x.Id == idAbsence);
            if (entity==null)
            {
                result.IsSuccess = false;
                result.Message = $"No se encontro la ausencia que intenta eliminar.";
                return result;
            }

            _context.Absences.Remove(entity);

            try
            {
                _context.SaveChanges();

                result.IsSuccess = true;
                result.Message = "ausencia eliminada correctamente.";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Error al eliminar la ausencia.";
                result.Error = ex;
            }

            return result;
        }
    }
}
