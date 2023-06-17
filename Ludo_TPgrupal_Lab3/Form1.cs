using System.Windows.Forms;

namespace Ludo_TPgrupal_Lab3
{
    public partial class Form1 : Form
    {


        Dictionary<int, TableLayoutPanelCellPosition> secuenciaTableroRojo = new Dictionary<int, TableLayoutPanelCellPosition>();

        public void secuenciadorRojo()
        {
            secuenciaTableroRojo.Add(1, new TableLayoutPanelCellPosition(2, 6));
            secuenciaTableroRojo.Add(2, new TableLayoutPanelCellPosition(3, 6));
            secuenciaTableroRojo.Add(3, new TableLayoutPanelCellPosition(4, 6));
            secuenciaTableroRojo.Add(4, new TableLayoutPanelCellPosition(5, 6));
            secuenciaTableroRojo.Add(5, new TableLayoutPanelCellPosition(6, 5));
            secuenciaTableroRojo.Add(6, new TableLayoutPanelCellPosition(6, 4));
            secuenciaTableroRojo.Add(7, new TableLayoutPanelCellPosition(6, 3));
            secuenciaTableroRojo.Add(8, new TableLayoutPanelCellPosition(6, 2));
            secuenciaTableroRojo.Add(9, new TableLayoutPanelCellPosition(6, 1));
            secuenciaTableroRojo.Add(10, new TableLayoutPanelCellPosition(6, 0));
            secuenciaTableroRojo.Add(11, new TableLayoutPanelCellPosition(7, 0));
            secuenciaTableroRojo.Add(12, new TableLayoutPanelCellPosition(8, 0));
            secuenciaTableroRojo.Add(13, new TableLayoutPanelCellPosition(8, 1));
            secuenciaTableroRojo.Add(14, new TableLayoutPanelCellPosition(8, 2));
            secuenciaTableroRojo.Add(15, new TableLayoutPanelCellPosition(8, 3));
            secuenciaTableroRojo.Add(16, new TableLayoutPanelCellPosition(8, 4));
            secuenciaTableroRojo.Add(17, new TableLayoutPanelCellPosition(8, 5));
            secuenciaTableroRojo.Add(18, new TableLayoutPanelCellPosition(9, 6));
            secuenciaTableroRojo.Add(19, new TableLayoutPanelCellPosition(10, 6));
            secuenciaTableroRojo.Add(20, new TableLayoutPanelCellPosition(11, 6));
            secuenciaTableroRojo.Add(21, new TableLayoutPanelCellPosition(12, 6));
            secuenciaTableroRojo.Add(22, new TableLayoutPanelCellPosition(13, 6));
            secuenciaTableroRojo.Add(23, new TableLayoutPanelCellPosition(14, 6));
            secuenciaTableroRojo.Add(24, new TableLayoutPanelCellPosition(14, 7));
            secuenciaTableroRojo.Add(25, new TableLayoutPanelCellPosition(14, 8));
            secuenciaTableroRojo.Add(26, new TableLayoutPanelCellPosition(13, 8));
            secuenciaTableroRojo.Add(27, new TableLayoutPanelCellPosition(12, 8));
            secuenciaTableroRojo.Add(28, new TableLayoutPanelCellPosition(11, 8));
            secuenciaTableroRojo.Add(29, new TableLayoutPanelCellPosition(10, 8));
            secuenciaTableroRojo.Add(30, new TableLayoutPanelCellPosition(9, 8));
            secuenciaTableroRojo.Add(31, new TableLayoutPanelCellPosition(8, 9));
            secuenciaTableroRojo.Add(32, new TableLayoutPanelCellPosition(8, 10));
            secuenciaTableroRojo.Add(33, new TableLayoutPanelCellPosition(8, 11));
            secuenciaTableroRojo.Add(34, new TableLayoutPanelCellPosition(8, 12));
            secuenciaTableroRojo.Add(35, new TableLayoutPanelCellPosition(8, 13));
            secuenciaTableroRojo.Add(36, new TableLayoutPanelCellPosition(8, 14));
            secuenciaTableroRojo.Add(37, new TableLayoutPanelCellPosition(7, 14));
            secuenciaTableroRojo.Add(38, new TableLayoutPanelCellPosition(6, 14));
            secuenciaTableroRojo.Add(39, new TableLayoutPanelCellPosition(6, 13));
            secuenciaTableroRojo.Add(40, new TableLayoutPanelCellPosition(6, 12));
            secuenciaTableroRojo.Add(41, new TableLayoutPanelCellPosition(6, 11));
            secuenciaTableroRojo.Add(42, new TableLayoutPanelCellPosition(6, 10));
            secuenciaTableroRojo.Add(43, new TableLayoutPanelCellPosition(6, 9));
            secuenciaTableroRojo.Add(44, new TableLayoutPanelCellPosition(5, 8));
            secuenciaTableroRojo.Add(45, new TableLayoutPanelCellPosition(4, 8));
            secuenciaTableroRojo.Add(46, new TableLayoutPanelCellPosition(3, 8));
            secuenciaTableroRojo.Add(47, new TableLayoutPanelCellPosition(2, 8));
            secuenciaTableroRojo.Add(48, new TableLayoutPanelCellPosition(1, 8));
            secuenciaTableroRojo.Add(49, new TableLayoutPanelCellPosition(0, 8));
            secuenciaTableroRojo.Add(50, new TableLayoutPanelCellPosition(0, 7));
            secuenciaTableroRojo.Add(51, new TableLayoutPanelCellPosition(0, 6));
            secuenciaTableroRojo.Add(52, new TableLayoutPanelCellPosition(1, 6));
            secuenciaTableroRojo.Add(53, new TableLayoutPanelCellPosition(1, 7));
            secuenciaTableroRojo.Add(54, new TableLayoutPanelCellPosition(2, 7));
            secuenciaTableroRojo.Add(55, new TableLayoutPanelCellPosition(3, 7));
            secuenciaTableroRojo.Add(56, new TableLayoutPanelCellPosition(4, 7));
            secuenciaTableroRojo.Add(57, new TableLayoutPanelCellPosition(5, 7));
            secuenciaTableroRojo.Add(58, new TableLayoutPanelCellPosition(6, 7));
        }

        Dictionary<int, TableLayoutPanelCellPosition> secuenciaTableroVerde = new Dictionary<int, TableLayoutPanelCellPosition>();

        public void secuenciadorVerde()
        {
            secuenciaTableroVerde.Add(1, new TableLayoutPanelCellPosition(8, 2));
            secuenciaTableroVerde.Add(2, new TableLayoutPanelCellPosition(8, 3));
            secuenciaTableroVerde.Add(3, new TableLayoutPanelCellPosition(8, 4));
            secuenciaTableroVerde.Add(4, new TableLayoutPanelCellPosition(8, 5));
            secuenciaTableroVerde.Add(5, new TableLayoutPanelCellPosition(9, 6));
            secuenciaTableroVerde.Add(6, new TableLayoutPanelCellPosition(10, 6));
            secuenciaTableroVerde.Add(7, new TableLayoutPanelCellPosition(11, 6));
            secuenciaTableroVerde.Add(8, new TableLayoutPanelCellPosition(12, 6));
            secuenciaTableroVerde.Add(9, new TableLayoutPanelCellPosition(13, 6));
            secuenciaTableroVerde.Add(10, new TableLayoutPanelCellPosition(14, 6));
            secuenciaTableroVerde.Add(11, new TableLayoutPanelCellPosition(14, 7));
            secuenciaTableroVerde.Add(12, new TableLayoutPanelCellPosition(14, 8));
            secuenciaTableroVerde.Add(13, new TableLayoutPanelCellPosition(13, 8));
            secuenciaTableroVerde.Add(14, new TableLayoutPanelCellPosition(12, 8));
            secuenciaTableroVerde.Add(15, new TableLayoutPanelCellPosition(11, 8));
            secuenciaTableroVerde.Add(16, new TableLayoutPanelCellPosition(10, 8));
            secuenciaTableroVerde.Add(17, new TableLayoutPanelCellPosition(9, 8));
            secuenciaTableroVerde.Add(18, new TableLayoutPanelCellPosition(8, 9));
            secuenciaTableroVerde.Add(19, new TableLayoutPanelCellPosition(8, 10));
            secuenciaTableroVerde.Add(20, new TableLayoutPanelCellPosition(8, 11));
            secuenciaTableroVerde.Add(21, new TableLayoutPanelCellPosition(8, 12));
            secuenciaTableroVerde.Add(22, new TableLayoutPanelCellPosition(8, 13));
            secuenciaTableroVerde.Add(23, new TableLayoutPanelCellPosition(8, 14));
            secuenciaTableroVerde.Add(24, new TableLayoutPanelCellPosition(7, 14));
            secuenciaTableroVerde.Add(25, new TableLayoutPanelCellPosition(6, 14));
            secuenciaTableroVerde.Add(26, new TableLayoutPanelCellPosition(6, 13));
            secuenciaTableroVerde.Add(27, new TableLayoutPanelCellPosition(6, 12));
            secuenciaTableroVerde.Add(28, new TableLayoutPanelCellPosition(6, 11));
            secuenciaTableroVerde.Add(29, new TableLayoutPanelCellPosition(6, 10));
            secuenciaTableroVerde.Add(30, new TableLayoutPanelCellPosition(6, 9));
            secuenciaTableroVerde.Add(31, new TableLayoutPanelCellPosition(5, 8));
            secuenciaTableroVerde.Add(32, new TableLayoutPanelCellPosition(4, 8));
            secuenciaTableroVerde.Add(33, new TableLayoutPanelCellPosition(3, 8));
            secuenciaTableroVerde.Add(34, new TableLayoutPanelCellPosition(2, 8));
            secuenciaTableroVerde.Add(35, new TableLayoutPanelCellPosition(1, 8));
            secuenciaTableroVerde.Add(36, new TableLayoutPanelCellPosition(0, 8));
            secuenciaTableroVerde.Add(37, new TableLayoutPanelCellPosition(0, 7));
            secuenciaTableroVerde.Add(38, new TableLayoutPanelCellPosition(0, 6));
            secuenciaTableroVerde.Add(39, new TableLayoutPanelCellPosition(1, 6));
            secuenciaTableroVerde.Add(40, new TableLayoutPanelCellPosition(2, 6));
            secuenciaTableroVerde.Add(41, new TableLayoutPanelCellPosition(3, 6));
            secuenciaTableroVerde.Add(42, new TableLayoutPanelCellPosition(4, 6));
            secuenciaTableroVerde.Add(43, new TableLayoutPanelCellPosition(5, 6));
            secuenciaTableroVerde.Add(44, new TableLayoutPanelCellPosition(6, 5));
            secuenciaTableroVerde.Add(45, new TableLayoutPanelCellPosition(6, 4));
            secuenciaTableroVerde.Add(46, new TableLayoutPanelCellPosition(6, 3));
            secuenciaTableroVerde.Add(47, new TableLayoutPanelCellPosition(6, 2));
            secuenciaTableroVerde.Add(48, new TableLayoutPanelCellPosition(6, 1));
            secuenciaTableroVerde.Add(49, new TableLayoutPanelCellPosition(6, 0));
            secuenciaTableroVerde.Add(50, new TableLayoutPanelCellPosition(7, 0));
            secuenciaTableroVerde.Add(51, new TableLayoutPanelCellPosition(8, 0));
            secuenciaTableroVerde.Add(52, new TableLayoutPanelCellPosition(8, 1));
            secuenciaTableroVerde.Add(53, new TableLayoutPanelCellPosition(7, 1));
            secuenciaTableroVerde.Add(54, new TableLayoutPanelCellPosition(7, 2));
            secuenciaTableroVerde.Add(55, new TableLayoutPanelCellPosition(7, 3));
            secuenciaTableroVerde.Add(56, new TableLayoutPanelCellPosition(7, 4));
            secuenciaTableroVerde.Add(57, new TableLayoutPanelCellPosition(7, 5));
            secuenciaTableroVerde.Add(58, new TableLayoutPanelCellPosition(7, 6));
        }

        int resultDado, numeroJugadores = 2, turnoActual = 1;

        int sumadorRojo = 1, sumadorVerde = 1;
        Boolean salioRojo = false, salioVerde = false;

        public Form1()
        {
            InitializeComponent();
            secuenciadorRojo();
            secuenciadorVerde();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black; //aqui vuelve a ser negro el color del Boton

            resultDado = Dado.lanzarDado(); //asigna a una variable el resultado del ramdom generado en la clase Dado

            if (turnoActual == 1) //evalua el turno
            {
                //cambia de color y asigna Label al turno rojo
                turno.ForeColor = Color.Red;
                turno.Text = "ROJO";

                //en este switch se evalua el resultado del dado y se direcciona la ficha1 roja
                switch (resultDado)
                {
                    case 1:
                        imagenDado.Image = Properties.Resources.dado1;

                        if (salioRojo)
                        {
                            sumadorRojo += resultDado;
                            if (sumadorRojo < 59)
                            {
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                            else
                            {
                                sumadorRojo -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                        }
                        else
                        {
                            salioRojo = true;
                            tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                        }

                        break;
                    case 2:
                        imagenDado.Image = Properties.Resources.dado2;

                        if (salioRojo)
                        {
                            sumadorRojo += resultDado;
                            if (sumadorRojo < 59)
                            {
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                            else
                            {
                                sumadorRojo -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                        }

                        break;
                    case 3:
                        imagenDado.Image = Properties.Resources.dado3;

                        if (salioRojo)
                        {
                            sumadorRojo += resultDado;
                            if (sumadorRojo < 59)
                            {
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                            else
                            {
                                sumadorRojo -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                        }

                        break;
                    case 4:
                        imagenDado.Image = Properties.Resources.dado4;

                        if (salioRojo)
                        {
                            sumadorRojo += resultDado;
                            if (sumadorRojo < 59)
                            {
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                            else
                            {
                                sumadorRojo -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                        }
                        break;
                    case 5:
                        imagenDado.Image = Properties.Resources.dado5;

                        if (salioRojo)
                        {
                            sumadorRojo += resultDado;
                            if (sumadorRojo < 59)
                            {
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                            else
                            {
                                sumadorRojo -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                        }
                        break;
                    case 6:
                        imagenDado.Image = Properties.Resources.dado6;

                        if (salioRojo)
                        {
                            sumadorRojo += resultDado;
                            if (sumadorRojo < 59)
                            {
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                            else
                            {
                                sumadorRojo -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                            }
                        }
                        else
                        {
                            salioRojo = true;
                            tableroLudo.SetCellPosition(fichaRoja1, secuenciaTableroRojo[sumadorRojo]);
                        }
                        break;
                }

                if (sumadorRojo == 58)
                {
                    MessageBox.Show("Felicidades, lograste llegar a la meta con esta ficha");
                }

                turnoActual++;
                if (turnoActual > numeroJugadores)
                {
                    turnoActual = 1;
                }

                turno.ForeColor = Color.DarkGreen;
                turno.Text = "VERDE";

            }
            else if (turnoActual == 2)
            {
                turno.ForeColor = Color.DarkGreen;
                turno.Text = "VERDE";

                //en este switch se evalua el resultado del dado y se direcciona la ficha1 roja
                switch (resultDado)
                {
                    case 1:
                        imagenDado.Image = Properties.Resources.dado1;

                        if (salioVerde)
                        {
                            sumadorVerde += resultDado;
                            if (sumadorVerde < 59)
                            {
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                            else
                            {
                                sumadorVerde -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                        }
                        else
                        {
                            salioVerde = true;
                            tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                        }

                        break;
                    case 2:
                        imagenDado.Image = Properties.Resources.dado2;

                        if (salioVerde)
                        {
                            sumadorVerde += resultDado;
                            if (sumadorVerde < 59)
                            {
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                            else
                            {
                                sumadorVerde -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                        }

                        break;
                    case 3:
                        imagenDado.Image = Properties.Resources.dado3;

                        if (salioVerde)
                        {
                            sumadorVerde += resultDado;
                            if (sumadorVerde < 59)
                            {
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                            else
                            {
                                sumadorVerde -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                        }

                        break;
                    case 4:
                        imagenDado.Image = Properties.Resources.dado4;

                        if (salioVerde)
                        {
                            sumadorVerde += resultDado;
                            if (sumadorVerde < 59)
                            {
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                            else
                            {
                                sumadorVerde -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                        }
                        break;
                    case 5:
                        imagenDado.Image = Properties.Resources.dado5;

                        if (salioVerde)
                        {
                            sumadorVerde += resultDado;
                            if (sumadorVerde < 59)
                            {
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                            else
                            {
                                sumadorVerde -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                        }
                        break;
                    case 6:
                        imagenDado.Image = Properties.Resources.dado6;

                        if (salioVerde)
                        {
                            sumadorVerde += resultDado;
                            if (sumadorVerde < 59)
                            {
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                            else
                            {
                                sumadorVerde -= resultDado;
                                MessageBox.Show("Debe salir una cantidad de pasos justos para ganar");
                                tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                            }
                        }
                        else
                        {
                            salioVerde = true;
                            tableroLudo.SetCellPosition(fichaVerde1, secuenciaTableroVerde[sumadorVerde]);
                        }
                        break;
                }

                if (sumadorVerde == 58)
                {
                    MessageBox.Show("Felicidades, lograste llegar a la meta con esta ficha");

                }

                turnoActual++;
                if (turnoActual > numeroJugadores)
                {
                    turnoActual = 1;
                }

                turno.ForeColor = Color.Red;
                turno.Text = "ROJO";
            }


        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //Cambia de color al boton cuando se hace click
            button1.BackColor = Color.White;
        }


        private void imagenDado_Click(object sender, EventArgs e)
        {

        }

        private void fichaRoja1_Click(object sender, EventArgs e)
        {

        }

        private void fichaRoja1_Click_1(object sender, EventArgs e)
        {

        }


    }
}