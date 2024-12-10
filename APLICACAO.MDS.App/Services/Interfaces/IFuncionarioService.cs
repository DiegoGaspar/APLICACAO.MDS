using APLICACAO.MDS.App.Models;
using Microsoft.EntityFrameworkCore;

namespace APLICACAO.MDS.App.Services.Interfaces
{
    public interface IFuncionarioService
    {
        Task<List<Funcionario>> GetAllFuncionariosAsync();
        Task<Funcionario> GetFuncionarioByIdAsync(int id);
        Task AddFuncionarioAsync(Funcionario Funcionario);
        Task UpdateFuncionarioAsync(Funcionario Funcionario);
        Task DeleteFuncionarioAsync(int id);

    }
}
