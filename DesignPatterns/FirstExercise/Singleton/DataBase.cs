using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.Singleton
{
    public sealed class DataBase
    {
        private static DataBase _instance = null;
        private static readonly object _lockObject = new object();

        private DataBase()
        {}

        public static DataBase Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new DataBase();
                    }

                    return _instance;
                }
            }
        }
    }
}
