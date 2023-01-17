using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DemowithMysql
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=172.25.2.177;port=3306;username=rbc;password=mysql#123";
            //Display query  
            string Query = "select * from angularrbc.formmaster;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            grdTest.DataSource = dTable;
            grdTest.DataBind();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            

            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=mysql#123";
            //Display query  
            string Query = "select * from firstdb.employee;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
           MyAdapter.Fill(dTable);
            grdTest.DataSource = dTable;
            grdTest.DataBind();
        }
    }
}