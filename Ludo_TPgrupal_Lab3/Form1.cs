using System.Windows.Forms;

namespace Ludo_TPgrupal_Lab3
{
    public partial class Form1 : Form
    {
        Jugador jugadorRojo = new Jugador(0);
        Jugador jugadorVerde = new Jugador(0);
        Jugador jugadorAzul = new Jugador(0);
        Jugador jugadorAmarillo = new Jugador(0);
        

        Dictionary<int, TableLayoutPanelCellPosition> secuenciaTablero = new Dictionary<int, TableLayoutPanelCellPosition>();

        public void secuenciador()
        {
            secuenciaTablero.Add(1, new TableLayoutPanelCellPosition(1, 6));
            secuenciaTablero.Add(2, new TableLayoutPanelCellPosition(2, 6));
            secuenciaTablero.Add(3, new TableLayoutPanelCellPosition(3, 6));
            secuenciaTablero.Add(4, new TableLayoutPanelCellPosition(4, 6));
            secuenciaTablero.Add(5, new TableLayoutPanelCellPosition(5, 6));
            secuenciaTablero.Add(6, new TableLayoutPanelCellPosition(6, 5));
            secuenciaTablero.Add(7, new TableLayoutPanelCellPosition(6, 4));
            secuenciaTablero.Add(8, new TableLayoutPanelCellPosition(6, 3));
            secuenciaTablero.Add(9, new TableLayoutPanelCellPosition(6, 2));
            secuenciaTablero.Add(10, new TableLayoutPanelCellPosition(6, 1));
            secuenciaTablero.Add(11, new TableLayoutPanelCellPosition(6, 0));
            secuenciaTablero.Add(12, new TableLayoutPanelCellPosition(7, 0));
            secuenciaTablero.Add(13, new TableLayoutPanelCellPosition(8, 0));
            secuenciaTablero.Add(14, new TableLayoutPanelCellPosition(8, 1));
            secuenciaTablero.Add(15, new TableLayoutPanelCellPosition(8, 2));
            secuenciaTablero.Add(16, new TableLayoutPanelCellPosition(8, 3));
            secuenciaTablero.Add(17, new TableLayoutPanelCellPosition(8, 4));
            secuenciaTablero.Add(18, new TableLayoutPanelCellPosition(8, 5));
            secuenciaTablero.Add(19, new TableLayoutPanelCellPosition(9, 6));
            secuenciaTablero.Add(20, new TableLayoutPanelCellPosition(10, 6));
            secuenciaTablero.Add(21, new TableLayoutPanelCellPosition(11, 6));
            secuenciaTablero.Add(22, new TableLayoutPanelCellPosition(12, 6));
            secuenciaTablero.Add(23, new TableLayoutPanelCellPosition(13, 6));
            secuenciaTablero.Add(24, new TableLayoutPanelCellPosition(14, 6));
            secuenciaTablero.Add(25, new TableLayoutPanelCellPosition(14, 7));
            secuenciaTablero.Add(26, new TableLayoutPanelCellPosition(14, 8));
            secuenciaTablero.Add(27, new TableLayoutPanelCellPosition(13, 8));
            secuenciaTablero.Add(28, new TableLayoutPanelCellPosition(12, 8));
            secuenciaTablero.Add(29, new TableLayoutPanelCellPosition(11, 8));
            secuenciaTablero.Add(30, new TableLayoutPanelCellPosition(10, 8));
            secuenciaTablero.Add(31, new TableLayoutPanelCellPosition(9, 8));
            secuenciaTablero.Add(32, new TableLayoutPanelCellPosition(8, 9));
            secuenciaTablero.Add(33, new TableLayoutPanelCellPosition(8, 10));
            secuenciaTablero.Add(34, new TableLayoutPanelCellPosition(8, 11));
            secuenciaTablero.Add(35, new TableLayoutPanelCellPosition(8, 12));
            secuenciaTablero.Add(36, new TableLayoutPanelCellPosition(8, 13));
            secuenciaTablero.Add(37, new TableLayoutPanelCellPosition(8, 14));
            secuenciaTablero.Add(38, new TableLayoutPanelCellPosition(7, 14));
            secuenciaTablero.Add(39, new TableLayoutPanelCellPosition(6, 14));
            secuenciaTablero.Add(40, new TableLayoutPanelCellPosition(6, 13));
            secuenciaTablero.Add(41, new TableLayoutPanelCellPosition(6, 12));
            secuenciaTablero.Add(42, new TableLayoutPanelCellPosition(6, 11));
            secuenciaTablero.Add(43, new TableLayoutPanelCellPosition(6, 10));
            secuenciaTablero.Add(44, new TableLayoutPanelCellPosition(6, 9));
            secuenciaTablero.Add(45, new TableLayoutPanelCellPosition(5, 8));
            secuenciaTablero.Add(46, new TableLayoutPanelCellPosition(4, 8));
            secuenciaTablero.Add(47, new TableLayoutPanelCellPosition(3, 8));
            secuenciaTablero.Add(48, new TableLayoutPanelCellPosition(2, 8));
            secuenciaTablero.Add(49, new TableLayoutPanelCellPosition(1, 8));
            secuenciaTablero.Add(50, new TableLayoutPanelCellPosition(0, 8));
            secuenciaTablero.Add(51, new TableLayoutPanelCellPosition(0, 7));
            secuenciaTablero.Add(52, new TableLayoutPanelCellPosition(0, 6));
        }

        int resultDado, salidaRojo = 0, salidaVerde = 0, salidaAzul = 0, salidaAmarillo = 0;

        int sumadorRojo = 1;
        Boolean salioRojo = false;

        public Form1()
        {
            InitializeComponent();
            secuenciador();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            resultDado = Dado.lanzarDado();


            
            switch (resultDado)
            {
                case 1:
                    imagenDado.Image = Properties.Resources.dado1;
                    if (salioRojo)
                    {
                        sumadorRojo += resultDado;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);
                    }
                    else {
                        salioRojo = true;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);
                    }                    
                    
                    break;
                case 2:
                    imagenDado.Image = Properties.Resources.dado2;
                    if (salioRojo)
                    {
                        sumadorRojo += resultDado;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);
                    }

                    break;
                case 3:
                    imagenDado.Image = Properties.Resources.dado3;
                    if (salioRojo)
                    {
                        sumadorRojo += resultDado;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);

                    }

                    break;
                case 4:
                    imagenDado.Image = Properties.Resources.dado4;
                    if (salioRojo)
                    {
                        sumadorRojo += resultDado;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);

                    }

                    break;
                case 5:
                    imagenDado.Image = Properties.Resources.dado5;

                    if (salioRojo)
                    {
                        sumadorRojo += resultDado;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);

                    }
                    break;
                case 6:
                    imagenDado.Image = Properties.Resources.dado6;
                    if (salioRojo)
                    {
                        sumadorRojo += resultDado;
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);

                    }
                    else {
                        tableroLudo.SetCellPosition(fichaRoja1, secuenciaTablero[sumadorRojo]);
                        salioRojo = true;
                    }
                   
                    
                    break;

            }




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