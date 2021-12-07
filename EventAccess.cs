using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMaker
{
    class EventAccess
    {
        DataAccess ds;
        public EventAccess()
        {
            ds = new DataAccess();
        }
        public List<Event> GetAllComponents()
        {
            string sql = "SELECT * FROM DOCUMENTS WHERE UserId =" + Program.User_Id;
            SqlDataReader sc = ds.GetEvents(sql);
            List <Event> list= new List<Event>();
            while(sc.Read())
            {
                Event ev = new Event();
                ev.EventNo = (int)sc["EventNo"];
                ev.EventFile = sc["EventFile"].ToString();
                ev.EventDate = sc["EventDate"].ToString();
                ev.EventImportance= sc["EventImportance"].ToString();
                ev.EventPic = sc["EventPic"].ToString();
                ev.UserId = (int)sc["UserId"];
                //ev.ModificationDate = sc["ModificationDate"].ToString();
                list.Add(ev);
            }
            return list;
        }
        
    }
}
