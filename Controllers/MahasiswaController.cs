using Microsoft.AspNetCore.Mvc;
using tpmodul9_103082400028.Models;

namespace tpmodul9_103082400028.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa
            {
                Nama = "Edward Adventus Dembo",
                Nim = "103082400028"
            }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(daftarMahasiswa);
        }

        // GET: api/mahasiswa/0
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound("Data mahasiswa tidak ditemukan");
            }

            return Ok(daftarMahasiswa[index]);
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        // DELETE: api/mahasiswa/0
        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound("Data mahasiswa tidak ditemukan");
            }

            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}