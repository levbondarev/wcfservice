using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfax_text
{
    public class interfax_text
    {
        public  List<string[]> if_read()
        {
            try
            {
                List<string[]> templist = new List<string[]>();
                string[] t = System.IO.File.ReadAllLines("interfax_text.x", System.Text.Encoding.Default);
                for (int i = 0; i < t.Length; i++) {
                    string search_token_t = t[i].ToString();
                    string V_date = search_token_t.Substring(search_token_t.IndexOf("#"));
                    search_token_t = search_token_t.Replace(V_date + "#", "");
                    string V_memory = search_token_t;
                    templist.Add(new string[] {  V_date, V_memory });
                }
                return templist;
            }
            catch (Exception)
            {
                List<string[]> templist = new List<string[]>();
                templist.Add(new string[] { "error", "error" });
                return templist;
            }
        }
        public  bool if_write(string date, string memory)
        {
            try
            {
                System.IO.File.AppendAllText("interfax_text.x", date+"#"+memory + Environment.NewLine,System.Text.Encoding.Default);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
