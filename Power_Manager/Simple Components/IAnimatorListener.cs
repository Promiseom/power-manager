using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleComponents
{
    public interface IAnimatorListener
    {
        void OnStart();
        void OnPause();
        void OnResume();
        void OnStop();
        void OnComplete();
    }
}
