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
    public partial class JuegoExt : System.Web.UI.Page
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
                if (Session["tablero"] != null)
                {
                    Tablero(int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList1.SelectedValue));
                    ImprimirBotones();
                    List<Ficha> fichas = (List<Ficha>)Session["fichas"];
                    Juego metodos = new Juego();

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
            ImprimirFichas();

        }
        public void Tablero(int columna, int fila)
        {
            List<Button> lista = new List<Button>();
            Table tab = new Table();
            for (int j = 0; j < fila + 2; j++)
            {
                TableRow fil = new TableRow();
                tab.Rows.Add(fil);
                for (int i = 0; i < columna + 2; i++)
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
                    else if (i == 0 && (j >= 1 && j < fila + 1))
                    {
                        Label label = new Label();
                        col = new TableCell();
                        try
                        {
                            char letra = Boton(i, j - 1).ElementAt(1);
                            char letra2 = Boton(i, j - 1).ElementAt(2);
                            label.Text = ".   " + letra.ToString() + letra2.ToString();
                        }
                        catch (Exception)
                        {

                            char letras = Boton(i, j - 1).ElementAt(1);
                            label.Text = ".     " + letras.ToString();
                        }
                        label.Font.Size = 18;
                        label.Width = 60;
                        col.Controls.Add(label);
                        col.Attributes.Add("style", "Height: 60px; Width: 60px; background-color: rgb(158,131,106); ");
                        fil.Cells.Add(col);

                        continue;


                    }
                    else if (i == columna + 1 && (j >= 1 && j < fila + 1))
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
                    else if (i > 0)
                    {
                        col = new TableCell();
                        col.Attributes.Add("style", "height: 60px; border: 1px solid black; width: 60px; background-color: rgb(129,75,27); ");
                        Button boton = new Button();
                        boton.Click += new EventHandler(Click);
                        boton.ID = Boton(i - 1, j - 1);
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
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            Boolean turno = (Boolean)Session["turno"];
            Juego metodos = new Juego();
            Button button = sender as Button;
            Boolean apertura= AperturaPersonalizada(false);
            if (fichas.Count >= 4)
            {
                if (metodos.ValidadAccion(button))
                {
                    Accion(button);
                    metodos.Limpiar((int)Session["columnas"] + 1, (int)Session["filas"] + 1);
                    metodos.MovimientosPosibles((Boolean)Session["turno"], (int)Session["columnas"] + 1, (int)Session["filas"] + 1);

                }
            }
            else if (apertura)
            {
                if (metodos.ValidadAccion(button))
                {
                    Accion(button);
                    if (fichas.Count == 4)
                    {
                        metodos.MovimientosPosibles((Boolean)Session["turno"], (int)Session["columnas"] + 1, (int)Session["filas"] + 1);

                    }

                }
            }

            ImprimirMatriz((int[,])Session["matriz"], (int)Session["columnas"] + 1, (int)Session["filas"] + 1);
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
            if (ListadeColores())
            {
                Iniciar();
            }
            else
            {
                string script = "alert('Debe elegir la misma cantidad de colores!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }

        }
        public void Iniciar()
        {
            Session["movimientosJ1"] = 0;
            Session["movimientosJ2"] = 0;
            Session["partida"] = true;
            Session["botones"] = botonesM;
            Session["matriz"] = new int[int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList1.SelectedValue)];
            Session["fichas"] = fichasM;
            Session["ultima"] = ultimaM;
            Session["ultimaJ1"] = new Ficha();
            Session["ultimaFichaJ2"] = new Ficha();
            Session["turno"] = false;
            Session["tablero"] = null;
            Tablero(int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList1.SelectedValue));
            Session["columnas"] = int.Parse(DropDownList2.SelectedValue) - 1;
            Session["filas"] = int.Parse(DropDownList1.SelectedValue) - 1;
            AperturaPersonalizada(true);
            ImprimirBotones();
            ImprimirMatriz((int[,])Session["matriz"], (int)Session["columnas"] + 1, (int)Session["filas"] + 1);
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
            LinkedList<String> Listaj1 = (LinkedList<String>)Session["coloresJ1"];
            LinkedList<String> Listaj2 = (LinkedList<String>)Session["coloresJ2"];
            Color color = new Color();
            string nomColor;
            Juego metodos = new Juego();
            Ficha ultima = (Ficha)Session["ultima"];
            Ficha ultimaJ1 = (Ficha)Session["ultimaJ1"];
            Ficha ultimaJ2 = (Ficha)Session["ultimaFichaJ2"];
            Boolean turno = (Boolean)Session["turno"];
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            int[,] matriz = (int[,])Session["matriz"];
            Ficha ficha = new Ficha();
            int[] posicionM = metodos.Coordenada(button.ID);
            if (turno)
            {
                color = ColoresTurno(turno, Listaj2, ultimaJ2);
                nomColor = NomColor(color);
                ficha.color = nomColor;
                matriz[posicionM[0], posicionM[1]] = 1;
            }
            else
            {
                color = ColoresTurno(turno, Listaj1, ultimaJ1);
                nomColor = NomColor(color);
                ficha.color = nomColor;
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

            metodos.Movimiento(ficha, turno, (int[,])Session["matriz"], (int)Session["columnas"] + 1, (int)Session["filas"] + 1,ficha.color);
            ImprimirFicha(ficha, color);

            if (!turno)
            {
                ultima.color = nomColor;

            }
            else
            {
                ultima.color = nomColor;

            }
            Session["fichas"] = fichas;
            Session["ultima"] = ultima;
            Session["turno"] = !turno;
        }
        public Color ColoresTurno(Boolean turno, LinkedList<String> Lista, Ficha ficha)
        {
            Boolean estado= false;
            string color = null;
            if (ficha.color==null || Lista.Last() == ficha.color)
            {
                color = Lista.First();
                System.Diagnostics.Debug.WriteLine(Lista.Last());
            }
            else
            {
                foreach (String item in Lista)
                {
                    if (estado)
                    {
                        color = item;
                        break;
                    }
                    else
                    {
                        if (item==ficha.color)
                        {
                            estado = true;
                        }
                    }
                }
                
            }
            System.Diagnostics.Debug.WriteLine(color);
            if (turno)
            {
                ficha.color = color;
                Session["ultimaFichaJ2"] = ficha;

            }
            else 
            {
                ficha.color = color;
                Session["ultimaJ1"] = ficha;

            }

            return Colores(color);
        }

        public Color Colores(string color) 
        {
            Color ficha = Color.Transparent;
            switch (color) 
            {
                case "negro":
                    ficha= Color.Black;
                    break;
                case "blanco":
                    ficha = Color.White;
                    break;

                case "rojo":
                    ficha = Color.Red;
                    break;
                case "amarillo":
                    ficha = Color.Yellow;
                    break;
                case "azul":
                    ficha = Color.Blue;
                    break;
                case "anaranjado":
                    ficha = Color.Orange;
                    break;
                case "verde":
                    ficha = Color.Green;
                    break;
                case "violeta":
                    ficha = Color.Violet;
                    break;
                case "celeste":
                    ficha = Color.Cyan;
                    break;
                case "gris":
                    ficha = Color.Gray;
                    break;
                default:
                    break;
            }
            return ficha;
        }

        public string NomColor(Color color) 
        {
            string ficha = null;
            if (color == Color.Black)
            {
                ficha = "negro";
            }
            else if (color == Color.White)
            {
                ficha = "blanco";
            }
            else if (color == Color.Red)
            {
                ficha = "rojo";
            }
            else if (color == Color.Yellow)
            {
                ficha = "amarillo";
            }
            else if (color == Color.Blue)
            {
                ficha = "azul";
            }
            else if (color == Color.Orange)
            {
                ficha = "anaranjado";
            }
            else if (color == Color.Green)
            {
                ficha = "verde";
            }
            else if (color == Color.Violet)
            {
                ficha = "violeta";
            }
            else if (color == Color.Cyan)
            {
                ficha = "celeste";
            }
            else if (color == Color.Gray)
            {
                ficha = "gris";
            }
            return ficha;

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
        public void ImprimirFicha(Ficha ficha, Color color)
        {
            List<Button> botones = (List<Button>)Session["botones"];

            foreach (Button item in botones)
            {
                if (item.ID.Equals(ficha.columna + ficha.fila))
                {
                    item.Attributes.Add("style", "Height: 60px; Width: 60px; border-radius: 100%;");
                    item.BackColor = color;
                }
            }
            Session["botones"] = botones;

        }
        public void ImprimirFichas()
        {
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            List<Button> botones = (List<Button>)Session["botones"];

            foreach (Button item in botones)
            {
                foreach (Ficha fi in fichas)
                {
                    if (item.ID.Equals(fi.columna + fi.fila))
                    {
                            item.Attributes.Add("style", "height: 60px; width: 60px; border-radius: 100%;");
                            item.BackColor = Colores(fi.color);
                       

                    }
                }
            }
            Session["botones"] = botones;

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
            List<CheckBox> listaJ1 = new List<CheckBox>();
            List<CheckBox> listaJ2 = new List<CheckBox>();
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
            listaJ1.Add(CheckBox1);
            listaJ1.Add(CheckBox2);
            listaJ1.Add(CheckBox3);
            listaJ1.Add(CheckBox4);
            listaJ1.Add(CheckBox5);
            listaJ1.Add(CheckBox6);
            listaJ1.Add(CheckBox7);
            listaJ1.Add(CheckBox8);
            listaJ1.Add(CheckBox9);
            listaJ1.Add(CheckBox10);
            listaJ2.Add(CheckBox11);
            listaJ2.Add(CheckBox12);
            listaJ2.Add(CheckBox13);
            listaJ2.Add(CheckBox14);
            listaJ2.Add(CheckBox15);
            listaJ2.Add(CheckBox16);
            listaJ2.Add(CheckBox17);
            listaJ2.Add(CheckBox18);
            listaJ2.Add(CheckBox19);
            listaJ2.Add(CheckBox20);
            Session["check"] = lista;
            Session["checkJ1"] = listaJ1;
            Session["checkJ2"] = listaJ2;

        }

        public Boolean ListadeColores() 
        {

            LinkedList<String> jugador1 = new LinkedList<string>();
            LinkedList<String> jugador2 = new LinkedList<string>();
            List<CheckBox> listaJ1 = (List<CheckBox>)Session["checkJ1"];
            List<CheckBox> listaJ2 = (List<CheckBox>)Session["checkJ2"];
            foreach (CheckBox item in listaJ1)
            {
                if (item.Checked)
                {
                    jugador1.AddLast(item.Text.ToLower().Trim());
                }
            }
            foreach (CheckBox item in listaJ2)
            {
                if (item.Checked)
                {
                    jugador2.AddLast(item.Text.ToLower().Trim());
                }
            }
            if (jugador1.Count==0 && jugador2.Count==0)
            {
                return false;
            }
            else if (jugador1.Count==jugador2.Count)
            {
                Session["coloresJ1"] = jugador1;
                Session["coloresJ2"] = jugador2;
                return true;
            }
            else
            {
                Session["coloresJ1"] = null;
                Session["coloresJ2"] = null;
                return false;
            }

        }
    }
    
    

}