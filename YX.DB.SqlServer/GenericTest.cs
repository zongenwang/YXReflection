using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YX.DB.SqlServer
{

   public class GenericClass<T ,W ,X >
    {
        public void Show(T t,W w,X x)
        { 
        Console.WriteLine("t.type={0},w.type={1},x.type={2}",t.GetType().Name,w.GetType().Name,x.GetType().Name);
        }
    }

    public class GenericMethod
    {
        public void Show<T, W, X>(T t, W w, X x)
        {
            Console.WriteLine("t.type={0},w.type={1},x.type={2}", t.GetType().Name, w.GetType().Name,x.GetType().Name);
        }
    }

    public class GernericDouble<T>
    {
        public void Show<W, X>(T t, W w, X x)
        {
            Console.WriteLine("t.type={0},w.type={1},x.type{2}",t.GetType().Name,w.GetType().Name,w.GetType());
        }
    }
}
