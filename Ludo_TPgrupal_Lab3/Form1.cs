using System.Windows.Forms;

namespace Ludo_TPgrupal_Lab3
{
    public partial class Form1 : Form
    {
        Jugador jugadorRojo = new Jugador(0);
        Jugador jugadorVerde = new Jugador(0);
        Jugador jugadorAzul = new Jugador(0);
        Jugador jugadorAmarillo = new Jugador(0);





        Control[] tableroCeldas;

        public void tableroSecuencia()
        {
            tableroCeldas[0] = tableroLudo.GetControlFromPosition(2, 6);
            tableroCeldas[1] = tableroLudo.GetControlFromPosition(3, 6);
            tableroCeldas[2] = tableroLudo.GetControlFromPosition(4, 6);
            tableroCeldas[3] = tableroLudo.GetControlFromPosition(5, 6);
            tableroCeldas[4] = tableroLudo.GetControlFromPosition(6, 5);
            tableroCeldas[5] = tableroLudo.GetControlFromPosition(6, 4);
            tableroCeldas[6] = tableroLudo.GetControlFromPosition(6, 3);
            tableroCeldas[7] = tableroLudo.GetControlFromPosition(6, 2);
            tableroCeldas[8] = tableroLudo.GetControlFromPosition(6, 1);
            tableroCeldas[9] = tableroLudo.GetControlFromPosition(6, 0);
            tableroCeldas[10] = tableroLudo.GetControlFromPosition(7, 0);
            tableroCeldas[11] = tableroLudo.GetControlFromPosition(8, 0);
            tableroCeldas[12] = tableroLudo.GetControlFromPosition(8, 1);
            tableroCeldas[13] = tableroLudo.GetControlFromPosition(8, 2);
            tableroCeldas[14] = tableroLudo.GetControlFromPosition(8, 3);
            tableroCeldas[15] = tableroLudo.GetControlFromPosition(8, 4);
            tableroCeldas[16] = tableroLudo.GetControlFromPosition(8, 5);
            tableroCeldas[17] = tableroLudo.GetControlFromPosition(9, 6);
            tableroCeldas[18] = tableroLudo.GetControlFromPosition(10, 6);
            tableroCeldas[19] = tableroLudo.GetControlFromPosition(11, 6);
            tableroCeldas[20] = tableroLudo.GetControlFromPosition(12, 6);
            tableroCeldas[21] = tableroLudo.GetControlFromPosition(13, 6);
            tableroCeldas[22] = tableroLudo.GetControlFromPosition(14, 6);
            tableroCeldas[23] = tableroLudo.GetControlFromPosition(14, 7);
            tableroCeldas[24] = tableroLudo.GetControlFromPosition(14, 8);
            tableroCeldas[25] = tableroLudo.GetControlFromPosition(13, 8);
            tableroCeldas[26] = tableroLudo.GetControlFromPosition(12, 8);
            tableroCeldas[27] = tableroLudo.GetControlFromPosition(11, 8);
            tableroCeldas[28] = tableroLudo.GetControlFromPosition(10, 8);
            tableroCeldas[29] = tableroLudo.GetControlFromPosition(9, 8);
            tableroCeldas[30] = tableroLudo.GetControlFromPosition(8, 9);
            tableroCeldas[31] = tableroLudo.GetControlFromPosition(8, 10);
            tableroCeldas[32] = tableroLudo.GetControlFromPosition(8, 11);
            tableroCeldas[33] = tableroLudo.GetControlFromPosition(8, 12);
            tableroCeldas[34] = tableroLudo.GetControlFromPosition(8, 13);
            tableroCeldas[35] = tableroLudo.GetControlFromPosition(8, 14);
            tableroCeldas[36] = tableroLudo.GetControlFromPosition(7, 14);
            tableroCeldas[37] = tableroLudo.GetControlFromPosition(6, 14);
            tableroCeldas[38] = tableroLudo.GetControlFromPosition(6, 13);
            tableroCeldas[39] = tableroLudo.GetControlFromPosition(6, 12);
            tableroCeldas[40] = tableroLudo.GetControlFromPosition(6, 11);
            tableroCeldas[41] = tableroLudo.GetControlFromPosition(6, 10);
            tableroCeldas[42] = tableroLudo.GetControlFromPosition(6, 9);
            tableroCeldas[43] = tableroLudo.GetControlFromPosition(5, 8);
            tableroCeldas[44] = tableroLudo.GetControlFromPosition(4, 8);
            tableroCeldas[45] = tableroLudo.GetControlFromPosition(3, 8);
            tableroCeldas[46] = tableroLudo.GetControlFromPosition(2, 8);
            tableroCeldas[47] = tableroLudo.GetControlFromPosition(1, 8);
            tableroCeldas[48] = tableroLudo.GetControlFromPosition(0, 8);
            tableroCeldas[49] = tableroLudo.GetControlFromPosition(0, 7);
            tableroCeldas[50] = tableroLudo.GetControlFromPosition(1, 7);
            tableroCeldas[51] = tableroLudo.GetControlFromPosition(2, 7);
            tableroCeldas[52] = tableroLudo.GetControlFromPosition(3, 7);
            tableroCeldas[53] = tableroLudo.GetControlFromPosition(4, 7);
            tableroCeldas[54] = tableroLudo.GetControlFromPosition(5, 7);
            tableroCeldas[55] = tableroLudo.GetControlFromPosition(6, 7);

        }





        int resultDado, salidaRojo = 0, salidaVerde = 0, salidaAzul = 0, salidaAmarillo = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            resultDado = Dado.lanzarDado();



            switch (resultDado)
            {
                case 1:
                    imagenDado.Image = Properties.Resources.dado1;
                    if (salidaRojo == 0)
                    {



                    }
                    else MessageBox.Show("Debe salir 6 para poder sacar tu ficha");
                    break;
                case 2:
                    imagenDado.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    imagenDado.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    imagenDado.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    imagenDado.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    imagenDado.Image = Properties.Resources.dado6;
                    salidaRojo = 6;
                    tableroLudo.SetCellPosition(fichaRoja1, new TableLayoutPanelCellPosition(2, 6));
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