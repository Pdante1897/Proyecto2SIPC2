using Proyecto2SIPC2.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proyecto2SIPC2
{
    public partial class Juego : System.Web.UI.Page
    {

        static List<Button> botones;
        static List<Ficha> fichas;
        static Ficha ultima;
        static Boolean turno=true;

        protected void Page_Load(object sender, EventArgs e)
        {
            ultima = new Ficha();
                        fichas = new List<Ficha>();

            botones = new List<Button>();
            agregarBotones();
        }

        protected void Pulsar(String hola)
        {
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Usuario o Contrasenia incorrectas!" + "');</script>");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        public void Click(object sender, EventArgs args)
        {

            Button button = sender as Button;
            button.Attributes.Add("style", "border-radius: 100%; background-color: Black;");
            

        }
        protected void agregarBotones()
        {
            botones.Add(A1);
            botones.Add(A2);
            botones.Add(A3);
            botones.Add(A4);
            botones.Add(A5);
            botones.Add(A6);
            botones.Add(A7);
            botones.Add(A8);
            botones.Add(B1);
            botones.Add(B2);
            botones.Add(B3);
            botones.Add(B4);
            botones.Add(B5);
            botones.Add(B6);
            botones.Add(B7);
            botones.Add(B8);
            botones.Add(C1);
            botones.Add(C2);
            botones.Add(C3);
            botones.Add(C4);
            botones.Add(C5);
            botones.Add(C6);
            botones.Add(C7);
            botones.Add(C8);
            botones.Add(D1);
            botones.Add(D2);
            botones.Add(D3);
            botones.Add(D4);
            botones.Add(D5);
            botones.Add(D6);
            botones.Add(D7);
            botones.Add(D8);
            botones.Add(E1);
            botones.Add(E2);
            botones.Add(E3);
            botones.Add(E4);
            botones.Add(E5);
            botones.Add(E6);
            botones.Add(E7);
            botones.Add(E8);
            botones.Add(F1);
            botones.Add(F2);
            botones.Add(F3);
            botones.Add(F4);
            botones.Add(F5);
            botones.Add(F6);
            botones.Add(F7);
            botones.Add(F8);
            botones.Add(G1);
            botones.Add(G2);
            botones.Add(G3);
            botones.Add(G4);
            botones.Add(G5);
            botones.Add(G6);
            botones.Add(G7);
            botones.Add(G8);
            botones.Add(H1);
            botones.Add(H2);
            botones.Add(H3);
            botones.Add(H4);
            botones.Add(H5);
            botones.Add(H6);
            botones.Add(H7);
            botones.Add(H8);
        }

        protected void Cargar()
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ext = Path.GetExtension(FileUpload1.FileName);
            Console.WriteLine(ext);
            if (FileUpload1.HasFile)
            {
                if (ext.Equals(".xml"))
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Xml/partida.xml"));
                    {
                        CargarPartida();
                        Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Se cargo la partida con exito!" + "');</script>");

                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Error! El archivo debe ser tipo XML" + "');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Error! Seleccione un archivo XML" + "');</script>");
            }
        }
        public void CargarPartida()
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load(Server.MapPath("~/Xml/partida.xml"));
            int numero = 0;
            foreach (XmlElement item in archivo.DocumentElement)
            {
                Ficha fi = new Ficha();
                for (int i = 0; i < item.ChildNodes.Count; i++)
                {
                    string valor = item.ChildNodes[i].InnerText.Trim();

                    switch (item.ChildNodes[i].Name.ToLower())
                    {
                        case "color":
                            fi.color = valor;
                            break;
                        case "columna":
                            fi.columna = valor;
                            break;
                        case "fila":
                            fi.fila = valor;
                            break;
                        default:
                            numero++;
                            Console.WriteLine(numero);
                            break;
                    }
                }
                if (fi.columna == null)
                {
                    ultima = fi;
                }
                else 
                {
                    fichas.Add(fi);
                }
                
            }
            imprimirFichas();
        }
        public void imprimirFichas() 
        {
            foreach (Button item in botones)
            {
                foreach(Ficha fi in fichas)
                {
                    if (item.ID.Equals(fi.columna+fi.fila))
                    {
                        if (fi.color.Equals("blanco"))
                        {
                            item.Attributes.Add("style", "border-radius: 100%; background-color: White;");

                        }
                        else
                        {
                            item.Attributes.Add("style", "border-radius: 100%; background-color: Black;");

                        }

                    }
                }
            }
            
        }

        public void Ingresar(string coordenada) 
        {
            Ficha ficha = new Ficha();
            if (turno)
            {
                ficha.color = "blanco";
            }
            else
            {
                ficha.color = "negro";
            }
            char[] posicion = coordenada.ToCharArray();
            ficha.columna = posicion[0].ToString();
            ficha.fila = posicion[1].ToString();

            fichas.Add(ficha);
            ImprimirFicha(ficha);
            if (turno)
            {
                ultima.color = "negra";
                turno = false;
            }
            else
            {
                turno = true;
                ultima.color = "blanca";
            }
            
        }

        public void ImprimirFicha(Ficha ficha)
        {
            foreach (Button item in botones)
            {
                if (item.ID.Equals(ficha.columna + ficha.fila))
                {
                    if (ficha.color.Equals("blanco"))
                    {
                        item.Attributes.Add("style", "border-radius: 100%; background-color: White;");

                    }
                    else
                    {
                        item.Attributes.Add("style", "border-radius: 100%; background-color: Black;");

                    }
                }
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Ingresar(TextBox1.Text);
        }
    }
}