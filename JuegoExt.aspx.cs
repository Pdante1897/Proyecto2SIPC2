using Proyecto2SIPC2.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2SIPC2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        
        private List<Button> botonesM = new List<Button>();
        public List<Ficha> fichasM = new List<Ficha>();
        public Ficha ultimaM = new Ficha();
        public int[,] matrizM = new int[8, 8];
        public Boolean partida;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["movimientosJ1"] = 0;
            Session["movimientosJ2"] = 0;
            Session["partida"] = true;
            Session["botones"] = botonesM;
            Session["matriz"] = matrizM;
            Session["fichas"] = fichasM;
            Session["ultima"] = ultimaM;
            Session["turno"] = false;
            Tablero(int.Parse(DropDownList1.SelectedValue), int.Parse(DropDownList1.SelectedValue));
            Juego a = new Juego();
            a.Inicio();
        }
        public void Tablero(int fila, int columna) 
        {
            List<Button> lista = new List<Button>();
            Table tab = new Table();
            for (int j = 0; j < fila+2; j++)
            {
                TableRow fil = new TableRow();
                tab.Rows.Add(fil);
                for (int i = 0; i < columna+2; i++)
                {
                    TableCell col = new TableCell();
                    if (i == 0 && j == 0 || i == columna + 1 && j == fila + 1 || i == 0 && j == fila + 1 || i == columna + 1 && j == 0)
                    {
                        Label label = new Label();
                        label.Width = 60;
                        label.Height = 60;
                        col = new TableCell();
                        col.Controls.Add(label);
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: red; ");
                        fil.Cells.Add(col);
                        continue;

                    }
                    else if (i == 1 && j == 0)
                    {
                        for (int k = 0; k < columna; k++)
                        {
                            Label label = new Label();
                            col = new TableCell();
                            char letras = Boton(k, 1).ElementAt(0);
                            label.Text = ".     " + letras.ToString();
                            label.Font.Size = 20;

                            col.Controls.Add(label);
                            col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: red; ");
                            fil.Cells.Add(col);
                        }
                        i = columna;
                        continue;
                    }
                    else if (i == 1 && j == fila+1)
                    {
                        for (int k = 0; k < columna; k++)
                        {
                            Label label = new Label();
                            col = new TableCell();
                            char letras = Boton(k, 1).ElementAt(0);
                            label.Text = ".     " + letras.ToString();
                            label.Font.Size = 20;

                            col.Controls.Add(label);
                            col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: red; ");
                            fil.Cells.Add(col);
                        }
                        i = columna;
                        continue;


                    }
                    else if (i == 1 && j == fila + 1)
                    {
                        for (int k = 0; k < columna; k++)
                        {
                            Label label = new Label();
                            col = new TableCell();
                            char letras = Boton(k, 1).ElementAt(0);
                            label.Text = ".     " + letras.ToString();
                            label.Font.Size = 20;
                            col.Controls.Add(label);
                            col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: red; ");
                            fil.Cells.Add(col);
                            

                        }
                        i = columna;
                        continue;


                    }
                    else if (i == 0 && (j >= 1 && j < fila+1))
                    {
                        Label label = new Label();
                        col = new TableCell();
                        try
                        {
                            char letra = Boton(i, j - 1).ElementAt(1);
                            char letra2 = Boton(i, j - 1).ElementAt(2);
                            label.Text =".   "+letra.ToString()+letra2.ToString();
                        }
                        catch (Exception)
                        {

                            char letras = Boton(i, j - 1).ElementAt(1);
                            label.Text = ".     "+ letras.ToString();
                        }
                        label.Font.Size=20;
                        label.Width = 60;
                        col.Controls.Add(label);
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: red; ");
                        fil.Cells.Add(col);
                         
                        continue;


                    }
                    else if (i == columna+1 && (j >= 1 && j < fila + 1))
                    {
                        Label label = new Label();
                        col = new TableCell();
                        try
                        {
                            char letra = Boton(1, j - 1).ElementAt(1);
                            char letra2 = Boton(1, j - 1).ElementAt(2);
                            label.Text = ".   " + letra.ToString() + letra2.ToString();
                        }
                        catch (Exception)
                        {

                            char letras = Boton(1, j - 1).ElementAt(1);
                            label.Text = ".     " + letras.ToString();
                        }
                        label.Font.Size = 20;
                        label.Width = 60;
                        col.Controls.Add(label);
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: red; ");
                        fil.Cells.Add(col);

                        continue;


                    }
                    else if (i>0)
                    {
                        col = new TableCell();
                        col.Attributes.Add("style", "height: 60px; border: 1px solid black; width: 60px; background-color: White; ");
                        Button boton = new Button();
                        boton.ID = Boton(i-1, j - 1);
                        System.Diagnostics.Debug.Write(boton.ID + " ");
                        boton.Attributes.Add("style", "height: 60px; border: none; width: 60px; border-radius: 100%; background-color: Transparent; ");
                        lista.Add(boton);
                        col.Controls.Add(boton);
                        fil.Cells.Add(col);
                    }


                    

                }
                System.Diagnostics.Debug.WriteLine("");

            }
            Panel1.Controls.Add(tab);
            Session["botones"] = lista;
            foreach (Button item in lista)
            {
                System.Diagnostics.Debug.WriteLine(item.ID);

            }
        }
        protected void UpdatePanel1_Load(object sender, EventArgs e)
        {
            
        }

        public string Boton(int i, int k)
        {
            int j = k + 1;
            string boton = null;
            switch (i)
            {
                case 0:
                    boton = "A" + j;
                    break;
                case 1:
                    boton = "B" + j;

                    break;
                case 2:
                    boton = "C" + j;

                    break;
                case 3:
                    boton = "D" + j;

                    break;
                case 4:
                    boton = "E" + j;

                    break;
                case 5:
                    boton = "F" + j;

                    break;
                case 6:
                    boton = "G" + j;

                    break;
                case 7:
                    boton = "H" + j;

                    break;
                case 8:
                    boton = "I" + j;
                    break;
                case 9:
                    boton = "J" + j;

                    break;
                case 10:
                    boton = "K" + j;

                    break;
                case 11:
                    boton = "L" + j;
                    
                    break;
                case 12:
                    boton = "M" + j;

                    break;
                case 13:
                    boton = "N" + j;

                    break;
                case 14:
                    boton = "O" + j;

                    break;
                case 15:
                    boton = "P" + j;

                    break;
                case 16:
                    boton = "Q" + j;
                    break;
                case 17:
                    boton = "R" + j;

                    break;
                case 18:
                    boton = "S" + j;

                    break;
                case 19:
                    boton = "T" + j;
                    break;
                default:
                    break;
            }
            return boton;
        }

        
    }
}