using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_entity
{
    class Singleton
    {
        private static WaterWayContext context;//tek contexten iletişim sağlayabilmek için bu classı oluşturduk.
        public static WaterWayContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new WaterWayContext();
                }
                return context;
            }
        }
    }
}
