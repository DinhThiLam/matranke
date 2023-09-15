using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matranke
{
    class Hien
    {
        public void HienMT(string filename)
        {
            MTK mtk = new MTK(filename);
            mtk.Show();
            bool Doixung = true;
            for( int i=0; i<mtk.n && Doixung; ++i)
            {
                int j;
                for (j = i + 1; j < mtk.n && mtk.a[i, j] == mtk.a[j, i]; ++j)
                    if (j < mtk.n)
                        Doixung = false;

            }
            if (Doixung == false)
                Console.WriteLine(" Ma tran khong doi xung( day la man tran co huong)");
            else
                Console.WriteLine(" Ma tran doi xung ( day la ma tran vo huong)");
        }
    }
}
