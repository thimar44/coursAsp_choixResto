using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choixResto.Models
{
    interface IDal : IDisposable
    {
        void CreerRestaurant(string nom, string telephone);
        List<Resto> ObtientTousLesRestaurants();
    }
}
