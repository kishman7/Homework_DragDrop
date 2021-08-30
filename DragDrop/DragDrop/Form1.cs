using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pbMain.AllowDrop = true; //включаємо функцію drop в pbMain
        }

        //обробка події при натиснені на клавішу мишки в PictureBox
        private void pbImg1_MouseClick(object sender, MouseEventArgs e)
        {
            pbImg1.DoDragDrop(pbImg1.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який буде копіюватись
        }

        private void pbImg2_MouseClick(object sender, MouseEventArgs e)
        {
            pbImg2.DoDragDrop(pbImg2.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який буде копіюватись
        }

        private void pbImg3_MouseClick(object sender, MouseEventArgs e)
        {
            pbImg3.DoDragDrop(pbImg3.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який буде копіюватись
        }

        private void pbImg4_MouseClick(object sender, MouseEventArgs e)
        {
            pbImg4.DoDragDrop(pbImg4.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який буде копіюватись
        }



        //обробка події DragEnter в головному PictureBox, яка буде показувати, що буде відбуватись з перетягнутим елементом
        private void pbMain_DragEnter(object sender, DragEventArgs e)
        {
            //встановлюємо певні ефекти по замовчуванню для PictureBox, коли дозволена операція перетягування
            e.Effect = e.AllowedEffect; 
        }

        //обробка події DragDrop в головному PictureBox
        private void pbMain_DragDrop(object sender, DragEventArgs e)
        {
            //спрацьовує подія, коли ми відпускаємо мишку після перетягування у вікно
            pbMain.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap); //Bitmap - об’єкт, який використовується для роботи з зображеннями
        }

        //обробка події, коли відпускаємо клавішу мишки в PictureBox
        private void pbImg1_MouseDown(object sender, MouseEventArgs e)
        {
            pbImg1.DoDragDrop(pbImg1.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який копіюється
        }

        private void pbImg2_MouseDown(object sender, MouseEventArgs e)
        {
            pbImg2.DoDragDrop(pbImg2.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який копіюється
        }

        private void pbImg3_MouseDown(object sender, MouseEventArgs e)
        {
            pbImg3.DoDragDrop(pbImg3.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який копіюється
        }

        private void pbImg4_MouseDown(object sender, MouseEventArgs e)
        {
            pbImg4.DoDragDrop(pbImg4.Image, DragDropEffects.Copy); //описуємо процедуру переміщення, переміщається Image, який копіюється
        }
    }
}
