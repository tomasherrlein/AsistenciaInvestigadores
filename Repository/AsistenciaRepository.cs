using ApplicationBussines;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AsistenciaRepository : IAsistenciaRepository
    {
        private readonly AppDbContext _dbContext;

        public AsistenciaRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Asistencia asistencia)
        {
            var asistenciaModel = new AsistenciaModel
            {
                Idinvestigador = asistencia.IDInvestigador,
                Fecha = asistencia.Fecha,
                HoraEntrada = asistencia.HoraEntrada,
                HoraSalida = asistencia.HoraSalida
            }; 

            await _dbContext.AddAsync(asistenciaModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Asistencia>> GetAllAsync()
        {
            var asistenciasModels = await _dbContext.Asistencias.ToListAsync();

            var asistencias = new List<Asistencia>();

            foreach (var asistenciaModel in asistenciasModels)
            {
                asistencias.Add(new Asistencia
                {
                    IDInvestigador = asistenciaModel.Idinvestigador,
                    Fecha = asistenciaModel.Fecha,
                    HoraEntrada = asistenciaModel.HoraEntrada,
                    HoraSalida = asistenciaModel.HoraSalida
                });
            }

            return asistencias;
        }

        public async Task<Asistencia> GetByIdAsync(int id)
        {
            var asistenciaModel = await _dbContext.Asistencias.FindAsync(id);

            return new Asistencia
            {
                IDInvestigador = asistenciaModel.Idinvestigador,
                Fecha = asistenciaModel.Fecha,
                HoraEntrada = asistenciaModel.HoraEntrada,
                HoraSalida = asistenciaModel.HoraSalida
            };
        }

        public async Task EditAsync(Asistencia asistencia)
        {
            var asistenciaModel = await _dbContext.Asistencias.FindAsync(asistencia.IDAsistencia);

            if (asistenciaModel != null)
            {
                asistenciaModel.Fecha = asistencia.Fecha;
                asistenciaModel.HoraEntrada = asistencia.HoraEntrada;
                asistenciaModel.HoraSalida = asistencia.HoraSalida;

                _dbContext.Entry(asistenciaModel).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var asistenciaModel = await _dbContext.Asistencias.FindAsync(id);
            _dbContext.Remove(asistenciaModel);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Asistencia>> GetAsistenciasDeInvestigadorPorMesAsync(int IdInvestigador, int año, int mes)
        {
            DateOnly fechaInicio = new DateOnly(año, mes, 1);
            DateOnly fechaFin = fechaInicio.AddMonths(1).AddDays(-1);

            return await _dbContext.Asistencias
                            .Where(a => a.Idinvestigador == IdInvestigador &&
                                        a.Fecha >= fechaInicio &&
                                        a.Fecha <= fechaFin)
                            .Select (a => new Asistencia
                            {
                                IDInvestigador = a.Idinvestigador,
                                Fecha = a.Fecha,
                                HoraEntrada = a.HoraEntrada,
                                HoraSalida = a.HoraSalida
                            })
                            .ToListAsync();
        }
    }
}
