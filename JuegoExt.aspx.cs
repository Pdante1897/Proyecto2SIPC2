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
            AgregarCheck();
            if (!(Boolean)Session["partida"])
            {
                Session["movimientosJ1"] = 0;
                Session["movimientosJ2"] = 0;
                Session["partida"] = true;
                Session["matriz"] = matrizM;
                Session["fichas"] = fichasM;
                Session["ultima"] = ultimaM;
                Session["turno"] = false;
                Session["tablero"] = null;
            }
            else
            {
                if (Session["tablero"]!=null)
                {
                    Tablero(int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList1.SelectedValue));
                    ImprimirBotones();
                }                
            }
        }
        public void ImprimirBotones()
        {
            Juego metodos = new Juego();
            List<Button> lista = (List<Button>)Session["Botones"];
            foreach (Button item in lista)
            {
                item.Width = 60;
                item.Height = 60;
            }
            metodos.ImprimirFichas();

        }
        public void Tablero(int columna, int fila) 
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
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
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
                            label.Font.Size = 18;

                            col.Controls.Add(label);
                            col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
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
                            label.Font.Size = 18;

                            col.Controls.Add(label);
                            col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
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
                            label.Font.Size = 18;
                            col.Controls.Add(label);
                            col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
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
                        label.Font.Size=18;
                        label.Width = 60;
                        col.Controls.Add(label);
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
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
                        label.Font.Size = 18;
                        label.Width = 60;
                        col.Controls.Add(label);
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
                        fil.Cells.Add(col);

                        continue;


                    }
                    else if (i>0)
                    {
                        col = new TableCell();
                        col.Attributes.Add("style", "height: 60px; border: 1px solid black; width: 60px; background-color: rgb(129,75,27); ");
                        Button boton = new Button();
                        boton.Click += new EventHandler(Click);
                        boton.ID = Boton(i-1, j - 1);
                        System.Diagnostics.Debug.Write(boton.ID + " ");
                        boton.CssClass = "ficha";
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
            Session["tablero"] = tab;
            foreach (Button item in lista)
            {
                System.Diagnostics.Debug.WriteLine(item.ID);

            }
        }
        public void Click(object sender, EventArgs args)
        {
            Juego metodos = new Juego();
            Button button = sender as Button;
            if (metodos.ValidadAccion(button))
            {
               
                Accion(button);
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
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["movimientosJ1"] = 0;
            Session["movimientosJ2"] = 0;
            Session["partida"] = true;
            Session["botones"] = botonesM;
            Session["matriz"] = new int[int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList1.SelectedValue)];
            Session["fichas"] = fichasM;
            Session["ultima"] = ultimaM;
            Session["turno"] = false;
            Session["tablero"] = null; 
            Tablero(int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList1.SelectedValue));
            Session["columnas"] = int.Parse(DropDownList2.SelectedValue)-1;
            Session["filas"] = int.Parse(DropDownList1.SelectedValue)-1;
            AperturaPersonalizada(true);
            ImprimirBotones();
            Juego metodos = new Juego();
            ImprimirMatriz((int[,])Session["matriz"], (int)Session["columnas"]+1, (int)Session["filas"]+1);
        }
        public void ImprimirMatriz(int[,] matriz, int columnas, int filas)
        {
            for (int j = 0; j < filas; j++)
            {
                for (int i = 0; i < columnas; i++)
                {
                    System.Diagnostics.Debug.Write(matriz[i, j] + " ");

                }
                System.Diagnostics.Debug.WriteLine(" ");

            }
            System.Diagnostics.Debug.WriteLine(" ");
        }
        public void Accion(Button button)
        {
            Juego metodos = new Juego();
            Ficha ultima = (Ficha)Session["ultima"];
            Boolean turno = (Boolean)Session["turno"];
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            int[,] matriz = (int[,])Session["matriz"];
            Ficha ficha = new Ficha();
            int[] posicionM = metodos.Coordenada(button.ID);
            if (turno)
            {
                ficha.color = "blanco";
                matriz[posicionM[0], posicionM[1]] = 1;

            }
            else
            {
                ficha.color = "negro";
                matriz[posicionM[0], posicionM[1]] = 2;

            }
            char[] posicion = button.ID.ToCharArray();
            ficha.columna = posicion[0].ToString();
            string numero;
            try
            {
                numero = posicion[1].ToString() + posicion[2].ToString();

            }
            catch (Exception)
            {
                numero = posicion[1].ToString();
            }
            ficha.fila = numero;
            fichas.Add(ficha);
            //Movimiento(ficha, (Boolean)Session["turno"], matriz);
            metodos.ImprimirFicha(ficha);

            if (!turno)
            {
                ultima.color = "negra";
            }
            else
            {
                ultima.color = "blanca";
            }

            Session["fichas"] = fichas;
            Session["ultima"] = ultima;
            Session["turno"] = !turno;
        }
        public Boolean AperturaPersonalizada(Boolean estado) 
        {
            List<Button> lista = (List<Button>)Session["botones"];
            int columnas=(int)Session["columnas"]+1,  filas = (int)Session["filas"]+1;
            int centroC = (columnas) / 2;
            int centroF = (filas) / 2;
            int[,] matriz = (int[,])Session["matriz"];
            if (estado)
            {
                for (int i = 0; i < columnas; i++)
                {
                    for (int j = 0; j < filas; j++)
                    {
                        matriz[i, j] = 0;
                    }
                }
                matriz[centroC - 1, centroF - 1] = 3;
                matriz[centroC, centroF - 1] = 3;
                matriz[centroC - 1, centroF] = 3;
                matriz[centroC, centroF] = 3;
                string boton1 = Boton(centroC - 1, centroF - 1);
                string boton2 = Boton(centroC, centroF - 1);
                string boton3 = Boton(centroC - 1, centroF);
                string boton4 = Boton(centroC, centroF);

                foreach (Button item in lista)
                {
                    if (item.ID==boton1|| item.ID == boton2|| item.ID == boton3|| item.ID == boton4)
                    {
                        item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                    }

                }
                Session["botones"] = lista;
                return false;
            }
            return true;
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e) 
        {
            CheckBox check = sender as CheckBox;
            List<CheckBox> lista = (List<CheckBox>)Session["check"];
            foreach (CheckBox item in lista)
            {
                if (item.ID==check.ID)
                {
                    continue;
                }
                if (item.ID != check.ID && item.Text==check.Text && check.Checked)
                {
                    item.Enabled = false;
                    
                }
                if (item.ID != check.ID && item.Text == check.Text && !check.Checked)
                {
                    item.Enabled = true;

                }
            }
        }
        public void AgregarCheck() 
        {
            List<CheckBox> lista = new List<CheckBox>();
            lista.Add(CheckBox1);
            lista.Add(CheckBox2);
            lista.Add(CheckBox3);
            lista.Add(CheckBox4);
            lista.Add(CheckBox5);
            lista.Add(CheckBox6);
            lista.Add(CheckBox7);
            lista.Add(CheckBox8);
            lista.Add(CheckBox9);
            lista.Add(CheckBox10);
            lista.Add(CheckBox11);
            lista.Add(CheckBox12);
            lista.Add(CheckBox13);
            lista.Add(CheckBox14);
            lista.Add(CheckBox15);
            lista.Add(CheckBox16);
            lista.Add(CheckBox17);
            lista.Add(CheckBox18);
            lista.Add(CheckBox19);
            lista.Add(CheckBox20);
            Session["check"] = lista;
        }
    }
    

}