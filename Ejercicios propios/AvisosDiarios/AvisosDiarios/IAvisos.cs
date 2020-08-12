using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosDiarios
{
    interface IAvisos                  // Otro pogramador que quiera reutilizar este codigo esta obligado a usar estos 2 metodos
    {
        void mostrarAviso();
        DateTime mostrarFecha();
    }
}
