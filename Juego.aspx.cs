using Proyecto2SIPC2.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proyecto2SIPC2
{
    public partial class Juego : System.Web.UI.Page
    {

        private List<Button> botonesM = new List<Button>();
        public List<Ficha> fichasM = new List<Ficha>();
        public Ficha ultimaM = new Ficha();
        public int[,] matrizM = new int[8, 8];
        public Boolean partida;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
            Label4.Text = (string)Session["usuario"];
            Label6.Text = (string)Session["colorficha"];
            Label14.Text = (string)Session["colorficha2"];
            if (!(Boolean)Session["partida"])
            {
                Session["movimientosJ1"] = 0;
                Session["movimientosJ2"] = 0;
                Session["partida"] = true;
                Session["botones"] = botonesM;
                AgregarBotones();
                Session["matriz"] = matrizM;
                Session["fichas"] = fichasM;
                Session["ultima"] = ultimaM;
                Session["turno"] = false;

                Inicio();
                MostrarTurno();
                MovimientosPosibles((Boolean)Session["turno"],8,8);

                if (!(Boolean)Session["jugador2"])
                {
                    Label12.Text = "Maquina";
                    if (Label19.Text == "Turno: Jugador 2")
                    {
                        TurnoMaquina();
                    }
                }
                else
                {
                    Label12.Text = (string)Session["j2"];
                }
            }
            else
            {
                
                AgregarBotones();
                ImprimirFichas();
                MovimientosPosibles((Boolean)Session["turno"],8,8);
                ValidarGanadores();
            }
        }
        public void TurnoMaquina() 
        {
            ValidadAccion(Maquina());
            Limpiar(8,8);
            MovimientosPosibles((Boolean)Session["turno"],8,8);
            ImprimirFichas();
            ImprimirMatriz((int[,])Session["matriz"],8,8);
            SumTurno();
            MostrarTurno();
            ValidarGanadores();
            

        }
        public Button Maquina()
        {
            List<Button> botones = (List<Button>)Session["botones"];
            int[,] matriz = (int[,])Session["matriz"];
            List<int[]> movimientos = new List<int[]>();
            int contador = 0;
            Random numR = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int[] ficha = new int[3];
                    if (matriz[i,j]==3)
                    {
                        contador++;
                        ficha[0] = contador;
                        ficha[1] = i;
                        ficha[2] = j;
                        movimientos.Add(ficha);
                    }
                }
            }
            if (contador==0)
            {
                return null;
            }
            int numero = numR.Next(1,contador);
            string boton = null;
            foreach (int[] item in movimientos)
            {
                if (numero == item[0])
                {
                   boton = Boton(item[1], item[2]);
                }
            }
            foreach (Button item in botones)
            {
                if (boton==item.ID)
                {
                    return item;
                }
                
                
            }
            return null;

        }
        public Partida Datos(int fichasJ1,int fichasJ2) 
        {
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            Partida partida = new Partida();

            jugador1.usuario= (string)Session["usuario"];
            jugador1.fichas = fichasJ1;
            jugador1.movimientos = (int)Session["movimientosJ1"];
            jugador2.usuario = Label12.Text;
            jugador2.fichas = fichasJ2;
            jugador2.movimientos = (int)Session["movimientosJ2"];
            partida.jugador1 = jugador1;
            partida.jugador2 = jugador2;
            if (!(Boolean)Session["jugador2"])
            {
                partida.tipo = "1 Jugador";
            }
            else
            {
                partida.tipo = "2 Jugadores";
            }

            return partida;

        }
        public void ValidarGanadores()
        {
            Partida partida = new Partida();
            int[,] matriz = (int[,])Session["matriz"];
            int[] fichas = ContarFichas(matriz);
            int fichasN = fichas[0];
            int fichasB = fichas[1];
            int fjugador1, fjugador2;
            Label10.Text = "" + (int)Session["movimientosJ1"];
            Label18.Text = "" + (int)Session["movimientosJ2"];
            if ((string)Session["colorficha"]=="Negro")
            {
                fjugador1 = fichasN;
                fjugador2 = fichasB;
                Label8.Text = ""+fichasN;
                Label16.Text = "" + fichasB;
                
            }
            else
            {
                fjugador1 = fichasB;
                fjugador2 = fichasN;
                Label8.Text = "" + fichasB;
                Label16.Text = "" + fichasN;
            }
            Boolean movOtroJ = MovimientosPosibles(!(Boolean)Session["turno"],8,8);
            Limpiar(8,8);

            Boolean movTurnoAct = MovimientosPosibles((Boolean)Session["turno"],8,8);
            if (fichasB + fichasN == 64 || !movTurnoAct && !movOtroJ)
            {
                string resultado=null;
                if (fichasN > fichasB)
                {
                    string script = "alert('Ganan las Negras!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    if ((string)Session["colorficha"] == "Negro")
                    {
                       resultado="Ganador";
                    }
                    else
                    {
                        resultado="Perdedor";
                    }
                }
                else if (fichasB > fichasN)
                {
                    string script = "alert('Ganan las Blancas!');";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    if ((string)Session["colorficha"] == "Blanco")
                    {
                        resultado = "Ganador";
                    }
                    else
                    {
                        resultado = "Perdedor";
                    }
                }
                else if (fichasB == fichasN)
                {
                    string script = "alert('Empate!');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    resultado = "Empate";

                }
                partida = Datos(fjugador1, fjugador2);
                partida.resultado = resultado;
                RegistrarPartida(partida);
            }
            else if (movTurnoAct)
            {

            }
            else if (!movTurnoAct)
            {
                Session["turno"] = !(Boolean)Session["turno"];
                string script = "alert('No puedes mover! :c');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                MovimientosPosibles((Boolean)Session["turno"],8,8);
            }


        }
        public void RegistrarPartida(Partida partida) 
        {
            string cadena1, cadena2, cadena3;
            cadena1 = ("insert into partida values (@tipo, 'Terminada')");
            cadena2 = ("SELECT MAX(codigoPartida) from partida");
            cadena3 = ("insert into participante values (@contrincante, @movimientos, @resultado, @codigo, @usuario, @fichasJ1, @fichasJ2)");
            string connectionString = @"Data Source=DESKTOP-KTTU0OF; Initial Catalog = othello; Integrated Security=True;";
            int id=0;
            try
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlDa = new SqlCommand(cadena1, sqlCon);
                    sqlDa.Parameters.AddWithValue("@tipo", partida.tipo);
                    sqlDa.ExecuteNonQuery();
                    sqlCon.Close();

                }
            }
            catch (Exception)
            {
            }
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlDa = new SqlCommand(cadena2, sqlCon);
                    SqlDataReader lector = sqlDa.ExecuteReader();
                    lector.Read();
                    {
                        id = int.Parse(lector.GetValue(0).ToString());
                    }
                    lector.Close();
                    sqlCon.Close();
                }
            }
            catch (Exception)
            {
            }
            try
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlDa = new SqlCommand(cadena3, sqlCon);
                    sqlDa.Parameters.AddWithValue("@contrincante", partida.jugador2.usuario);
                    sqlDa.Parameters.AddWithValue("@movimientos", partida.jugador1.movimientos);
                    sqlDa.Parameters.AddWithValue("@resultado", partida.resultado);
                    sqlDa.Parameters.AddWithValue("@codigo", id);
                    sqlDa.Parameters.AddWithValue("@usuario", partida.jugador1.usuario);
                    sqlDa.Parameters.AddWithValue("@fichasJ1", partida.jugador1.fichas);
                    sqlDa.Parameters.AddWithValue("@fichasJ2", partida.jugador2.fichas);
                    sqlDa.ExecuteNonQuery();
                    sqlCon.Close();

                }
                string script = "alert('Datos Guardados!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            catch (Exception)
            {
            }
        }
        protected void UpdatePanel1_Load(object sender, EventArgs e)
        {
            AgregarBotones();
            ImprimirFichas();
            
        }
        public void MostrarTurno() 
        {
            
            if ((!(Boolean)Session["turno"]) && (string)Session["colorficha"] == "Negro")
            {
                Label19.Text = "Turno: Jugador 1";
            }
            else if (((Boolean)Session["turno"]) && (string)Session["colorficha"] == "Blanco")
            {
                Label19.Text = "Turno: Jugador 1";

            }
            else if ((!(Boolean)Session["turno"]) && (string)Session["colorficha2"] == "Negro")
            {
                Label19.Text = "Turno: Jugador 2";

            }
            else if (((Boolean)Session["turno"]) && (string)Session["colorficha2"] == "Blanco")
            {
                Label19.Text = "Turno: Jugador 2";

            }
            
        }
        public void SumTurno()
        {

            if ((!(Boolean)Session["turno"]) && (string)Session["colorficha"] == "Negro")
            {
                Session["movimientosJ2"] = (int)Session["movimientosJ2"] + 1;
            }
            else if (((Boolean)Session["turno"]) && (string)Session["colorficha"] == "Blanco")
            {
                Session["movimientosJ2"] = (int)Session["movimientosJ2"] + 1;

            }
            else if ((!(Boolean)Session["turno"]) && (string)Session["colorficha2"] == "Negro")
            {
                Session["movimientosJ1"] = (int)Session["movimientosJ1"] + 1;

            }
            else if (((Boolean)Session["turno"]) && (string)Session["colorficha2"] == "Blanco")
            {
                Session["movimientosJ1"] = (int)Session["movimientosJ1"] + 1;

            }

        }
        public void Limpiar(int columnas, int filas)
        {
            List<Button> botones = (List<Button>)Session["botones"];
            int[,] matriz = (int[,])Session["matriz"];

            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (matriz[i, j] == 3 || matriz[i, j] == 0)
                    {
                        foreach (Button item in botones)
                        {
                            if (item.ID.Equals(Boton(i, j)))
                            {
                                item.Attributes.Add("style", "border-radius: 100%; border: none; background-color:transparent;");
                                matriz[i, j] = 0;
                            }
                        }
                    }
                }
            }
            Session["matriz"] = matriz;

        }
        public void Click(object sender, EventArgs args)
        {

            Button button = sender as Button;
            TurnoJugador(button);
            if (!(Boolean)Session["jugador2"])
            {
                if (Label19.Text == "Turno: Jugador 2")
                {

                    TurnoMaquina();

                }
            }

        }
        public void TurnoJugador(Button button) 
        {
            if (ValidadAccion(button))
            {
                Accion(button);
                Limpiar(8,8);
                MovimientosPosibles((Boolean)Session["turno"],8,8);
                ImprimirFichas();
                ImprimirMatriz((int[,])Session["matriz"],8,8);
                SumTurno();
                MostrarTurno();
                ValidarGanadores();
                
            }
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
        public int[,] ImprimirMov(int turno, int[,] matriz, int columnas, int filas, string color)
        {
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (matriz[i, j] == 4)
                    {
                        string bot = Boton(i, j);
                        foreach (Ficha item in fichas)
                        {
                            if (item.columna + item.fila == bot)
                            {
                                if (turno == 1)
                                {
                                    item.color = color;
                                }
                                else if (turno == 2)
                                {
                                    item.color = color;
                                }
                            }
                        }
                        matriz[i, j] = turno;
                    }

                }

            }
            Session["fichas"] = fichas;
            if (Session["tablero"] == null) 
            {
                ImprimirFichas();

            }
            else
            {
                JuegoExt juego = new JuegoExt();
                juego.ImprimirFichas();
            }
            return matriz;

        }
        public void Movimiento(Ficha ficha, Boolean turno, int[,] matriz, int columnas, int filas,string colorF)
        {

            int color, colorT, movHP = 0, movHN = 0, movVN = 0, movVP = 0, movDiP = 0, movDiN = 0, movDP = 0, movDN = 0;
            int[] posicionM = Coordenada(ficha.columna + ficha.fila);
            int fil = posicionM[1];
            int colum = posicionM[0];
            if (turno)
            {
                color = 2;
                colorT = 1;
            }
            else
            {
                color = 1;
                colorT = 2;
            }
            for (int col = posicionM[0] + 1; col < columnas; col++)
            {
                try
                {
                    if (matriz[col, fil] != color)
                    {
                        break;
                    }
                    if (matriz[col, fil] == color)
                    {
                        movHP++;
                    }
                    if (matriz[col, fil] == color && matriz[col + 1, fil] == colorT)
                    {
                        if (posicionM[0] + movHP < columnas)
                        {
                            for (int i = posicionM[0]; i < posicionM[0] + movHP; i++)
                            {
                                try
                                {
                                    matriz[i + 1, fil] = 4;

                                }
                                catch (Exception)
                                {

                                    break;
                                }
                            }
                            break;
                        }

                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
            for (int col = posicionM[0] - 1; col >= 0; col--)
            {
                try
                {
                    if (matriz[col, fil] != color)
                    {
                        break;
                    }
                    if (matriz[col, fil] == color)
                    {
                        movHN++;
                    }

                    if (matriz[col, fil] == color && matriz[col - 1, fil] == colorT)
                    {
                        if (posicionM[0] - movHN >= 0)
                        {
                            for (int i = posicionM[0]; i >= posicionM[0] - movHN; i--)
                            {
                                try
                                {
                                    matriz[i - 1, fil] = 4;


                                }
                                catch (Exception)
                                {

                                    break;
                                }
                            }
                            break;
                        }

                    }

                }
                catch (Exception)
                {
                    break;

                }
            }
            for (int fila = posicionM[1] - 1; fila >= 0; fila--)
            {
                try
                {
                    if (matriz[colum, fila] != color)
                    {
                        break;
                    }
                    if (matriz[colum, fila] == color)
                    {
                        movVP++;
                    }
                    if (matriz[colum, fila] == color && matriz[colum, fila - 1] == colorT)
                    {
                        if (posicionM[1] - movVP >= 0)
                        {
                            for (int i = posicionM[1]; i >= posicionM[1] - movVP; i--)
                            {
                                try
                                {
                                    matriz[colum, i - 1] = 4;

                                }
                                catch (Exception)
                                {

                                    break;
                                }
                            }
                            break;
                        }

                    }

                }
                catch (Exception)
                {
                    break;

                }
            }
            for (int fila = posicionM[1] + 1; fila < filas; fila++)
            {
                try
                {
                    if (matriz[colum, fila] != color)
                    {
                        break;
                    }
                    if (matriz[colum, fila] == color)
                    {
                        movVN++;
                    }
                    if (matriz[colum, fila] == color && matriz[colum, fila + 1] == colorT)
                    {
                        if (posicionM[1] + movVN < filas)
                        {
                            for (int i = posicionM[1]; i < posicionM[1] + movVN; i++)
                            {
                                try
                                {
                                    matriz[colum, i + 1] = 4;

                                }
                                catch (Exception)
                                {

                                    break;
                                }
                            }
                            break;
                        }

                    }

                }
                catch (Exception)
                {
                    break;

                }
            }
            int filaDiag = fil + 1;
            int filaIn = fil + 1;
            for (int col = posicionM[0] + 1; col < columnas; col++)
            {
                try
                {
                    if (matriz[col, filaDiag] != color)
                    {
                        break;
                    }
                    if (matriz[col, filaDiag] == color)
                    {
                        movDiP++;
                    }
                    if (matriz[col, filaDiag] == color && matriz[col + 1, filaDiag + 1] == colorT)
                    {
                        if (posicionM[0] + movDiP < columnas)
                        {
                            for (int i = posicionM[0]; i < posicionM[0] + movDiP; i++)
                            {
                                try
                                {
                                    matriz[i + 1, filaIn] = 4;
                                    filaIn++;
                                }
                                catch (Exception)
                                {

                                    break;
                                }
                                
                            }
                            break;
                        }

                    }
                    filaDiag++;

                }
                catch (Exception)
                {
                    break;

                }

            }
            filaDiag = fil - 1;
            filaIn = fil - 1;
            for (int col = posicionM[0] + 1; col < columnas; col++)
            {
                try
                {
                    if (matriz[col, filaDiag] != color)
                    {
                        break;
                    }
                    if (matriz[col, filaDiag] == color)
                    {
                        movDiN++;
                    }
                    if (matriz[col, filaDiag] == color && matriz[col + 1, filaDiag - 1] == colorT)
                    {
                        if (posicionM[0] + movDiN < columnas)
                        {
                            for (int i = posicionM[0]; i < posicionM[0] + movDiN; i++)
                            {
                                try
                                {
                                    matriz[i + 1, filaIn] = 4;
                                    filaIn--;
                                }
                                catch (Exception)
                                {

                                    break;
                                }
                                
                            }
                            break;
                        }

                    }
                    filaDiag--;

                }
                catch (Exception)
                {
                }
            }
            filaDiag = fil + 1;
            filaIn = fil + 1;
            for (int col = posicionM[0] - 1; col >= 0; col--)
            {
                try
                {
                    if (matriz[col, filaDiag] != color)
                    {
                        break;
                    }
                    if (matriz[col, filaDiag] == color)
                    {
                        movDP++;
                    }
                    if (matriz[col, filaDiag] == color && matriz[col - 1, filaDiag + 1] == colorT)
                    {
                        if (posicionM[0] - movDP < columnas)
                        {
                            for (int i = posicionM[0]; i >= posicionM[0] - movDP; i--)
                            {
                                try
                                {
                                    matriz[i - 1, filaIn] = 4;
                                    filaIn++;

                                }
                                catch (Exception)
                                {

                                    break;
                                }
                                
                            }
                            break;
                        }

                    }
                    filaDiag++;

                }
                catch (Exception)
                {
                    break;

                }

            }
            filaDiag = fil - 1;
            filaIn = fil - 1;
            for (int col = posicionM[0] - 1; col >= 0; col--)
            {
                try
                {
                    if (matriz[col, filaDiag] != color)
                    {
                        break;
                    }
                    if (matriz[col, filaDiag] == color)
                    {
                        movDN++;
                    }
                    if (matriz[col, filaDiag] == color && matriz[col - 1, filaDiag - 1] == colorT)
                    {
                        if (posicionM[0] - movDN < columnas)
                        {
                            for (int i = posicionM[0]; i >= posicionM[0] - movDN; i--)
                            {
                                try
                                {
                                    matriz[i - 1, filaIn] = 4;
                                    filaIn--;
                                }
                                catch (Exception)
                                {

                                    break;
                                }
                                
                            }
                            break;
                        }

                    }
                    filaDiag--;

                }
                catch (Exception)
                {
                    break;

                }
            }
            Session["matriz"] = ImprimirMov(colorT, matriz, columnas, filas, colorF);
        }
        public Boolean MovimientosPosibles(Boolean turno, int columnas, int filas)
        {
            List<Button> botones = (List<Button>)Session["botones"];
            int[,] matriz = (int[,])Session["matriz"];
            int color, colorT;

            if (turno)
            {
                color = 2;
                colorT = 1;
            }
            else
            {
                color = 1;
                colorT = 2;
            }
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (matriz[i, j] == color)
                    {
                        for (int k = i; k < columnas; k++)
                        {
                            if (i - 1>=0)
                            {
                                if ((matriz[i - 1, j] == 0) && (matriz[k, j] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i - 1, j)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i - 1, j] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[k, j] == 0 || matriz[k, j] == colorT || matriz[k, j] == 3))
                                {
                                    break;
                                }
                            }
                            else
                            {

                                break;
                            }


                        }
                        for (int k = i; k >= 0; k--)
                        {
                            if (i+1<columnas)
                            {
                                if ((matriz[i + 1, j] == 0) && (matriz[k, j] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i + 1, j)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i + 1, j] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[k, j] == 0 || matriz[k, j] == colorT || matriz[k, j] == 3))
                                {
                                    break;
                                }
                            }
                            else
                            {

                                break;
                            }

                        }
                        for (int k = j; k < filas; k++)
                        {
                            if(j-1>=0)
                            {
                                if ((matriz[i, j - 1] == 0) && (matriz[i, k] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i, j - 1)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i, j - 1] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[i, k] == 0 || matriz[i, k] == colorT || matriz[i, k] == 3))
                                {
                                    break;
                                }
                            }
                            else
                            {

                                break;
                            }

                        }
                        for (int k = j; k >= 0; k--)
                        {
                            if (j+1<filas)
                            {
                                if ((matriz[i, j + 1] == 0) && (matriz[i, k] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i, j + 1)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i, j + 1] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[i, k] == 0 || matriz[i, k] == colorT || matriz[i, k] == 3))
                                {
                                    break;
                                }
                            }
                            else
                            {

                                break;
                            }

                        }
                        int col = j;
                        for (int k = i; k < columnas; k++)
                        {
                            if(i-1>=0 && j-1>=0 && col<columnas)
                            {
                                if ((matriz[i - 1, j - 1] == 0) && (matriz[k, col] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i - 1, j - 1)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i - 1, j - 1] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[k, col] == 0 || matriz[k, col] == colorT || matriz[k, col] == 3))
                                {
                                    break;
                                }
                                col++;
                            }
                            else
                            {

                                break;
                            }


                        }
                        col = j;
                        for (int k = i; k < columnas; k++)
                        {
                            if(i-1>=0 && j+1<filas && col>=0)
                            {
                                if ((matriz[i - 1, j + 1] == 0) && (matriz[k, col] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i - 1, j + 1)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i - 1, j + 1] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[k, col] == 0 || matriz[k, col] == colorT || matriz[k, col] == 3))
                                {
                                    break;
                                }
                                col--;
                            }
                            else
                            {

                                break;
                            }


                        }
                        col = j;
                        for (int k = i; k >= 0; k--)
                        {
                            if(i+1<columnas&& j-1>=0 && col<columnas)
                            {
                                if ((matriz[i + 1, j - 1] == 0) && (matriz[k, col] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i + 1, j - 1)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i + 1, j - 1] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[k, col] == 0 || matriz[k, col] == colorT || matriz[k, col] == 3))
                                {
                                    break;
                                }
                                col++;
                            }
                            else
                            {

                                break;
                            }

                        }
                        col = j;
                        for (int k = i; k >= 0; k--)
                        {
                            if(i+1<columnas && j+1<filas && col>=0)
                            {
                                if ((matriz[i + 1, j + 1] == 0) && (matriz[k, col] == colorT))
                                {
                                    foreach (Button item in botones)
                                    {
                                        if (item.ID.Equals(Boton(i + 1, j + 1)))
                                        {
                                            item.Attributes.Add("style", "border-radius: 100%; border-bottom-color: black; background-color:transparent;");
                                            matriz[i + 1, j + 1] = 3;
                                        }
                                    }
                                    break;

                                }
                                else if ((matriz[k, col] == 0 || matriz[k, col] == colorT || matriz[k, col] == 3))
                                {
                                    break;
                                }
                                col--;
                            }
                            else
                            {

                                break;
                            }

                        }

                    }
                }
            }
            Session["botones"] = botones;
            Session["matriz"] = matriz;

            return HaveMovimientos(matriz, columnas, filas);

        }
        public int[] ContarFichas(int[,] matriz)
        {
            int movimientosN = 0, movimientosB = 0;
            int[] fichasJugadas = new int[2];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matriz[i, j] == 1)
                    {
                        movimientosB++;
                    }
                    else if (matriz[i, j] == 2)
                    {
                        movimientosN++;
                    }
                }
            }
            fichasJugadas[0] = movimientosN;
            fichasJugadas[1] = movimientosB;
            return fichasJugadas;
        }
        public Boolean HaveMovimientos(int[,] matriz, int columnas, int filas)
        {
            int movimientos = 0;
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (matriz[i, j] == 3)
                    {
                        movimientos++;
                    }
                }
            }
            if (movimientos == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public Boolean ValidadAccion(Button button)
        {
            
            try
            {
                int[,] matriz = (int[,])Session["matriz"];
                int[] posicion = Coordenada(button.ID);
                if (matriz[posicion[0], posicion[1]] == 2 || matriz[posicion[0], posicion[1]] == 1 || matriz[posicion[0], posicion[1]] == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
            
            
        }
        public void Accion(Button button)
        {
            Ficha ultima = (Ficha)Session["ultima"];
            Boolean turno = (Boolean)Session["turno"];
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            int[,] matriz = (int[,])Session["matriz"];
            Ficha ficha = new Ficha();
            int[] posicionM = Coordenada(button.ID);
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
            ficha.fila = posicion[1].ToString();
            fichas.Add(ficha);
            Movimiento(ficha, (Boolean)Session["turno"], matriz,8,8,ficha.color);
            ImprimirFicha(ficha);

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
            Session["turno"] = !(Boolean)Session["turno"];
        }
        protected void AgregarBotones()
        {

            List<Button> botones = (List<Button>)Session["botones"];
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
            Session["botones"] = botones;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string extension = Path.GetExtension(FileUpload1.FileName);
            System.Diagnostics.Debug.WriteLine("hola mundo");
            if (FileUpload1.HasFile)
            {
                if (extension.Equals(".xml"))
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
            Ficha ultima = new Ficha();
            List<Ficha> fichas = new List<Ficha>();
            XmlDocument archivo = new XmlDocument();
            archivo.Load(Server.MapPath("~/Xml/partida.xml"));
            int numero = 0;
            Boolean turno;
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
                        case "siguienteTiro":
                            fi.color = valor;
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

            Session["fichas"] = fichas;
            Session["ultima"] = ultima;
            LimpiarTablero(fichas);
            ImprimirFichas();
            if (ultima.color == "negro")
            {

                turno = false;
                Session["turno"] = turno;

            }
            else
            {
                turno = true;
                Session["turno"] = turno;

            }
            MovimientosPosibles(turno,8,8);
            ValidarGanadores();
            MostrarTurno();
            

        }
        public void LimpiarTablero(List<Ficha> fichas)
        {
            int[,] matriz = new int[8, 8];
            foreach (Ficha item in fichas)
            {
                int[] coor = Coordenada(item.columna + item.fila);
                if (item.color == "negro")
                {
                    matriz[coor[0], coor[1]] = 2;
                }
                else
                {
                    matriz[coor[0], coor[1]] = 1;
                }
            }
            Session["matriz"] = matriz;
            ImprimirMatriz(matriz,8,8);
            Limpiar(8,8);
            

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
                        if (fi.color.Equals("blanco"))
                        {
                            item.Attributes.Add("style", "height: 60px; width: 60px; border-radius: 100%; background-color: White;");

                        }
                        else
                        {
                            item.Attributes.Add("style", "height: 60px; width: 60px; border-radius: 100%; background-color: Black;");

                        }

                    }
                }
            }
            Session["botones"] = botones;

        }
        public void Ingresar(string coor)
        {
            Boolean turno = (Boolean)Session["turno"];
            List<Ficha> fichas = (List<Ficha>)Session["fichas"];
            int[,] matriz = (int[,])Session["matriz"];
            Ficha ultima = (Ficha)Session["ultima"];
            int[] posicionM = Coordenada(coor);
            Ficha ficha = new Ficha();
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
            char[] posicion = coor.ToCharArray();
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
            Session["fichas"] = fichas;
            Session["ultima"] = ultima;
            Session["turno"] = turno;
            Session["matriz"] = matriz;
        }
        public void ImprimirFicha(Ficha ficha)
        {
            List<Button> botones = (List<Button>)Session["botones"];

            foreach (Button item in botones)
            {
                if (item.ID.Equals(ficha.columna + ficha.fila))
                {
                    if (ficha.color.Equals("blanco"))
                    {
                        item.Attributes.Add("style", "Height: 60px; Width: 60px; border-radius: 100%; background-color: White;");

                    }
                    else
                    {
                        item.Attributes.Add("style", "Height: 60px; Width: 60px; border-radius: 100%; background-color: Black;");

                    }
                }
            }
            Session["botones"] = botones;

        }
        public void Guardar()
        {
            Ficha ultima = (Ficha)Session["ultima"];

            List<Ficha> fichas = (List<Ficha>)Session["fichas"];

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                Indent = true,
                NewLineOnAttributes = true,
                OmitXmlDeclaration = true
            };
            XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"archivo2.xml"), xmlWriterSettings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("tablero");
            foreach (Ficha ficha in fichas)
            {
                xmlWriter.WriteStartElement("ficha");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString(ficha.color);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("columna");
                xmlWriter.WriteString(ficha.columna);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("fila");
                xmlWriter.WriteString(ficha.fila);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

            }
            xmlWriter.WriteStartElement("siguienteTiro");
            xmlWriter.WriteString(ultima.color);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Close();

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["movimientosJ1"] = 0;
            Session["movimientosJ2"] = 0;
            Session["partida"] = true;
            Session["botones"] = botonesM;
            AgregarBotones();
            Session["matriz"] = matrizM;
            Session["fichas"] = fichasM;
            Session["ultima"] = ultimaM;
            Session["turno"] = false; 
            LimpiarTablero((List<Ficha>)Session["fichas"]);
            Inicio();
            ImprimirFichas();
            MostrarTurno();
            MovimientosPosibles(false,8,8);
            ValidarGanadores();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Inicio()
        {
            int[,] matriz = new int[8, 8];
            Random numR = new Random();

            if (numR.Next(1,2) == 1)
            {
                matriz[3, 3] = 1;
                matriz[3, 4] = 2;
                matriz[4, 4] = 1;
                matriz[4, 3] = 2;
                Ingresar("E4");
                Ingresar("E5");
                Ingresar("D5");
                Ingresar("D4");

            }
            else
            {

                matriz[3, 3] = 2;
                matriz[3, 4] = 1;
                matriz[4, 4] = 2;
                matriz[4, 3] = 1;
                Ingresar("E5");
                Ingresar("E4");
                Ingresar("D4");
                Ingresar("D5");
            }

            Session["matriz"] = matriz;

        }
        public int[] Coordenada(string id)
        {
            int[] coordenada = new int[2];
            char[] posicion = id.ToCharArray();
            string numero;
            try
            {
                 numero = posicion[1].ToString() + posicion[2].ToString();

            }
            catch (Exception)
            {
                 numero = posicion[1].ToString();
            }
            switch (id[0])
            {
                case 'A':
                    coordenada[0] = 0;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'B':
                    coordenada[0] = 1;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'C':
                    coordenada[0] = 2;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'D':
                    coordenada[0] = 3;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'E':
                    coordenada[0] = 4;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'F':
                    coordenada[0] = 5;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'G':
                    coordenada[0] = 6;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'H':
                    coordenada[0] = 7;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'I':
                    coordenada[0] = 8;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'J':
                    coordenada[0] = 9;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'K':
                    coordenada[0] = 10;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'L':
                    coordenada[0] = 11;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'M':
                    coordenada[0] = 12;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'N':
                    coordenada[0] = 13;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'O':
                    coordenada[0] = 14;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'P':
                    coordenada[0] = 15;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'Q':
                    coordenada[0] = 16;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'R':
                    coordenada[0] = 17;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'S':
                    coordenada[0] = 18;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                case 'T':
                    coordenada[0] = 19;
                    coordenada[1] = int.Parse(numero) - 1;
                    break;
                default:
                    break;
            }
            return coordenada;
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