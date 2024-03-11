using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_MovieNotification
{
    public interface IMovieObserver
    {
        void Update(string movie);
    }
}
