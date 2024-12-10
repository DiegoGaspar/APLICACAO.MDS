using APLICACAO.MDS.App.Data.Context;
using APLICACAO.MDS.App.Models;
using APLICACAO.MDS.App.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APLICACAO.MDS.App.Services;

public class FuncionarioService : IFuncionarioService
{
    private readonly Contexto _dbContext;

    public FuncionarioService(Contexto dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Funcionario>> GetAllFuncionariosAsync()
    {
        return await _dbContext.Funcionarios.ToListAsync();
    }

    public async Task<Funcionario> GetFuncionarioByIdAsync(int id)
    {
        return await _dbContext.Funcionarios.FindAsync(id);
    }

    public async Task AddFuncionarioAsync(Funcionario Funcionario)
    {
        _dbContext.Funcionarios.Add(Funcionario);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateFuncionarioAsync(Funcionario Funcionario)
    {
        _dbContext.Funcionarios.Update(Funcionario);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteFuncionarioAsync(int id)
    {
        var Funcionario = await _dbContext.Funcionarios.FindAsync(id);
        if (Funcionario != null)
        {
            _dbContext.Funcionarios.Remove(Funcionario);
            await _dbContext.SaveChangesAsync();
        }
    }
}
