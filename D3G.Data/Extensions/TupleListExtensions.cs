﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3G.Data.Extensions {
    public static class TupleListExtensions {
        public static void Add<T1, T2>(this IList<Tuple<T1, T2>> list, T1 item1, T2 item2) {
            list.Add(Tuple.Create(item1, item2));
        }
    }
}
