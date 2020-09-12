using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2SIPC2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void basedeDatos()
        {
            string cadena;
            cadena = ("insert into usuario values (@user, @nom, @ape, @pass, @fecha, @correo, @pais)");

            try
            {
                string connectionString = @"Data Source=DESKTOP-KTTU0OF; Initial Catalog = othello; Integrated Security=True;";

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlDa = new SqlCommand(cadena, sqlCon);
                    sqlDa.Parameters.AddWithValue("@nom", TextBox1.Text);
                    sqlDa.Parameters.AddWithValue("@ape", TextBox2.Text);
                    sqlDa.Parameters.AddWithValue("@correo", TextBox3.Text);
                    sqlDa.Parameters.AddWithValue("@user", TextBox4.Text);
                    sqlDa.Parameters.AddWithValue("@pass", TextBox5.Text);
                    sqlDa.Parameters.AddWithValue("@fecha", TextBox6.Text);
                    sqlDa.Parameters.AddWithValue("@pais", TextBox7.Text);
                    sqlDa.ExecuteNonQuery();
                    sqlCon.Close();
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Se ha registrado correctamente!" + "');</script>");

                }
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Error verificar datos" + "');</script>");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            basedeDatos();
        }
    }
}