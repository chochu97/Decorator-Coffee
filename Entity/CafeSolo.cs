using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CafeSolo : BebidaComponent
    {
        public override double Costo => 150;

        public override string Descripcion => "Cafe solo";
    }
}
