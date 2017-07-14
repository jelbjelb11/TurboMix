
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaService : IRecetaService
    {
        public IRecetaRepository recetaRepository { get; set; }

        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public void Aniadir(Receta receta)
        {
            recetaRepository.Crear(receta);
        }
    }
}
