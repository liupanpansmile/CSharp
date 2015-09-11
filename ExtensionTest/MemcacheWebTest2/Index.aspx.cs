using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Enyim.Caching;
using Enyim.Caching.Memcached;

namespace MemcacheWebTest2
{
   
    public partial class Index : System.Web.UI.Page
    {
        private static readonly MemcachedClient MemClient = new MemcachedClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void storeBtn_Click(object sender, EventArgs e)
        {
            string value = this.inputTxtBox.Text;
            MemClient.Store(StoreMode.Set, "MyKey", value);
            this.resultLbl.Text =  MemClient.Get("MyKey").ToString();
        }

    }
}