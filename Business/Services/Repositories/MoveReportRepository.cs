using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Business.Models.DTO;
using SIV_Pokemons_LL.Models.Reports;
using SIV_Pokemons_LL.Services.Interfaces;

namespace SIV_Pokemons_LL.Services.Repositories
{
    public class MoveReportRepository : Repository<MoveReport, MoveReportDTO>, IMoveReportRepository
    {
        public MoveReportRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
