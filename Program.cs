using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Requisicao.DBActions;
using Requisicao.Models;

var db = new DBCliente();




findAll().Result.ForEach(x =>
{
    Console.WriteLine(JsonSerializer.Serialize<Cliente>(x, new JsonSerializerOptions{
        WriteIndented=true
    }));
});

async Task<List<Cliente>> findAll()
{
    return await db.Clientes.ToListAsync();
}