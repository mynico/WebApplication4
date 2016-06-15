using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows;
using System.Web;


namespace WebApplication4
{
    public partial class linq2enteties
    {

        public List<persgroepoverzicht> myList;

        public linq2enteties()
        {
            using (WebApplication4.press2009Entities context = new press2009Entities())
            {
                IQueryable<persgroepoverzicht> sortedDates =
                    (from n in context.persgroepoverzicht
                     where n.wykno.Equals(10)
                     orderby n.date ascending
                     select n).Distinct();

                myList = new List<persgroepoverzicht>();

                myList.Clear();

                foreach (var item in sortedDates.AsEnumerable())
                {

                    myList.Add(item);




                }





            };

        }

        public List<persgroepoverzicht> GetList()
        {

            return myList;
        }



    }

        


    }

    


