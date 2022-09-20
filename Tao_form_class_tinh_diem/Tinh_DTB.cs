using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_form_class_tinh_diem
{
    internal class Tinh_DTB
    {
        public float a, b, c;

       public string hoten, msv, namsinh;

   
        
            public float tinhdtb()
            {
                return (a + b + c)/3;
            }





       public string diemtl()
        {
          
                if (tinhdtb() >= 8.5)
                {

                    return "4";
                }

                if (tinhdtb() >= 6.5)
                {
                    return "3";
                }
                if (tinhdtb() >= 5)
                {
                    return "2";
                }
                if (tinhdtb() >= 0)
                {
                    return "1";
                }
                else return "Học Lại";

            

        }
        
        public string xeploai()
        {

            if (tinhdtb() >= 8.5)
            {

                return "Giỏi";
            }

            if (tinhdtb() >= 6.5)
            {
                return "Khá";
            }
            if (tinhdtb() >= 5)
            {
                return "Trung Bình";
            }
            if (tinhdtb() >= 0)
            {
                return "Yếu";
            }
            else return "Kém";

        }
        public string diemchu()
        {

            if (tinhdtb() >= 8.5)
            {

                return "A";
            }

            if (tinhdtb() >= 6.5)
            {
                return "B";
            }
            if (tinhdtb() >= 5)
            {
                return "C";
            }
            if (tinhdtb() >= 0)
            {
                return "D";
            }
            else return "E";

        }





    }
}
    

