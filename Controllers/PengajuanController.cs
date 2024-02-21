using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PDPBCA_Test.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Threading.Tasks;

namespace PDPBCA_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PengajuanController : ControllerBase
    {
        private readonly IConfiguration _config;
        public PengajuanController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("InputPengajuan")]
        public async Task<IActionResult<List<Pinjaman>>> InputPengajuan(Pinjaman inputPinjaman)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("insert into pinjaman (dealer, downpayment, lamakredit, angsuran) values (@Dealer, @DownPayment, @LamaKredit, @Angsuran)", inputPinjaman);
            await connection.ExecuteAsync("insert into pinjaman (nik, tanggallahir, statusperkawinan, namapasangan) values (@NIK, @TanggalLahir, @StatusPerkawinan, @NamaPasangan)", inputPinjaman.Konsumen);
            await connection.ExecuteAsync("insert into pinjaman (dealer, merkkendaraan, modelkendaraan, tipekendaraan, warnakendaraan, hargakendaraan) values (@Dealer, @MerkKendaraan, @ModelKendaraan, @TipeKendaraan, @WarnaKendaraan, @HargaKendaraan)", inputPinjaman.Kendaraan);
            return Ok(await SelectAllPinjaman(connection));
        }

        private static async Task<IEnumerable<Pinjaman>> SelectAllPinjaman(SqlConnection connection)
        {
            return await connection.QueryAsync<Pinjaman>("select * from pinjaman");
        }
    }
}
