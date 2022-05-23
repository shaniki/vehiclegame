using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;



namespace WindowsFormsApp3
{
    [Serializable]
  
    public partial class VehicleGame : Form
    {
        int roadspeed;
        int Score;
        int maxRecord;
        int carImage;
        int truckImage;
        int playerspeed;

       
        Random rand = new Random();
        Random rand1 = new Random();
        Random carPosition = new Random();

      



        bool moveLeft, moveRight, space1;
        public VehicleGame()
        {
            InitializeComponent();

        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = true;
            if (e.KeyCode == Keys.Right)
                moveRight = true;
            if (e.KeyCode == Keys.Space)
                space1 = true;

        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = false;
            if (e.KeyCode == Keys.Right)
                moveRight = false;
            if (e.KeyCode == Keys.Space)
                space1 = false;

        }
        private void startGame(object sender, EventArgs e)
        {
            start1();
        }
       
        private void start1()
        {
            player l1 = new player();
            playerspeed = l1.speed; 
            start.Enabled = false;
            explosion.Visible = false;
            medal.Visible = false;
            moveLeft = false;
            moveRight = false;
            Score = 0;
            emergency.Visible = false;

            roadspeed = 5;
            //carspeed = 7;
            //truckspeed = 6;

            txtId.Text = "ID: " + l1._Id();
            txtBrand.Text = "Brand: " + l1._brand;
            txtRealese.Text = "RealseYear: " + l1._release_year;
            txtKmh.Text = "km'h: " + l1._kmh;
            txtContent.Text = "content: " + l1.Content();

            car1.Top = carPosition.Next(200, 500) * -1;
            car1.Left = carPosition.Next(5, 200);

            car2.Top = carPosition.Next(200, 500) * -1;
            car2.Left = carPosition.Next(245, 422);

            Timer.Start();

        }
        private void restartGame(object sender, EventArgs e)
        {
            start1();
           
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            Vehicle cr1 = new Vehicle();
            BigCars bt1 = new BigCars();
            player p = new player();

            txtscore.Text = "Score: " + Score;
            Score++;
            if (moveLeft == true && player.Left > 10)
            {
                player.Left -= playerspeed;
            }

            if (moveRight == true && player.Left < 415)
            {
                player.Left += playerspeed;
            }

            roadTrack1.Top += roadspeed;
            roadTrack2.Top += roadspeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            car1.Top += cr1.speed;
            car2.Top += bt1.speed;

            if (car1.Top > 520)
            {
                changeCars(car1);
            }

            if (car2.Top > 520)
            {
                changeTruck(car2);
            }

            if (Score > 300)
            {
                car1.Top += 2;
                car2.Top += 2;
            }
            if (Score > 600)
            {
                car1.Top += 3;
                car2.Top += 3;
            }
            if (Score > 1000)
            {
                car1.Top += 4;
                car2.Top += 4;
            }

            if (space1)
            {
                p.makeNoise();
            }


            if (player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
            {
                if (player.Bounds.IntersectsWith(car1.Bounds))
                    { 
                if (isEqual(car1, Properties.Resources.carPink))
                {
                    carPink car = new carPink();
                    txtId.Text = "ID: " + car._Id();
                    txtBrand.Text = "Brand: " + car._brand;
                    txtRealese.Text = "RealseYear: " + car._release_year;
                    txtKmh.Text = "km'h: " + car._kmh;
                    txtContent.Text = "content: " + car.Content();
                }
                if (isEqual(car1, Properties.Resources.CarRed))
                {
                    carRed car = new carRed();
                    txtId.Text = "ID: " + car._Id();
                    txtBrand.Text = "Brand: " + car._brand;
                    txtRealese.Text = "RealseYear: " + car._release_year;
                    txtKmh.Text = "km'h: " + car._kmh;
                    txtContent.Text = "content: " + car.Content();
                }
                if (isEqual(car1, Properties.Resources.carGreen))
                {
                    carGreen car = new carGreen();
                    txtId.Text = "ID: " + car._Id();
                    txtBrand.Text = "Brand: " + car._brand;
                    txtRealese.Text = "RealseYear: " + car._release_year;
                    txtKmh.Text = "km'h: " + car._kmh;
                    txtContent.Text = "content: " + car.Content();
                }
                if (isEqual(car1, Properties.Resources.carOrange))
                {
                    carOrange car = new carOrange();
                    txtId.Text = "ID: " + car._Id();
                    txtBrand.Text = "Brand: " + car._brand;
                    txtRealese.Text = "RealseYear: " + car._release_year;
                    txtKmh.Text = "km'h: " + car._kmh;
                    txtContent.Text = "content: " + car.Content();
                }
                    if (isEqual(car1, Properties.Resources.carYellow))
                    {
                        carYellow car = new carYellow();
                        txtId.Text = "ID: " + car._Id();
                        txtBrand.Text = "Brand: " + car._brand;
                        txtRealese.Text = "RealseYear: " + car._release_year;
                        txtKmh.Text = "km'h: " + car._kmh;
                        txtContent.Text = "content: " + car.Content();
                    }
                }
                if (player.Bounds.IntersectsWith(car2.Bounds))
                {
                    if (isEqual(car2, Properties.Resources.ambulance))
                    {
                        Ambulance track = new Ambulance();
                        txtId.Text = "ID: " + track._Id();
                        txtBrand.Text = "Brand: " + track._brand;
                        txtRealese.Text = "RealseYear: " + track._release_year;
                        txtKmh.Text = "km'h: " + track._kmh;
                        txtContent.Text = "content: " + track.Content();
                     
                    }
                    if (isEqual(car2, Properties.Resources.TruckBlue))
                    {
                        whiteTrack track = new whiteTrack();
                        txtId.Text = "ID: " + track._Id();
                        txtBrand.Text = "Brand: " + track._brand;
                        txtRealese.Text = "RealseYear: " + track._release_year;
                        txtKmh.Text = "km'h: " + track._kmh;
                        txtContent.Text = "content: " + track.Content();
                    }
                    if (isEqual(car2, Properties.Resources.TruckWhite))
                    {
                        BTrucks track = new BTrucks();
                        txtId.Text = "ID: " + track._Id();
                        txtBrand.Text = "Brand: " + track._brand;
                        txtRealese.Text = "RealseYear: " + track._release_year;
                        txtKmh.Text = "km'h: " + track._kmh;
                        txtContent.Text = "content: " + track.Content();
                    }
                }
                gameOver();
            } 
               
        }


        private void changeCars(PictureBox tempcar)
        {
            carImage = rand.Next(1, 6);

            switch (carImage)
            {

                case 1:

                    tempcar.Image = Properties.Resources.CarRed;
                    break;
                case 2:
                    tempcar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempcar.Image = Properties.Resources.carOrange;
                    break;
                case 4: 
                        tempcar.Image = Properties.Resources.carPink;
                        break;
                case 5:
                    tempcar.Image = Properties.Resources.carYellow;
                    break;

            }
            tempcar.Top = carPosition.Next(50, 225) * -1;

            if ((string)tempcar.Tag == "moveLeft")
            {
                tempcar.Left = carPosition.Next(52, 100);
            }
            if ((string)tempcar.Tag ==  "moveRight")
            {
                tempcar.Left = carPosition.Next(120, 280);
            }
        }
       
        private void changeTruck(PictureBox tempbus)
        {
            truckImage = rand1.Next(1,4);
            switch (truckImage)
            {
                case 1:
                    tempbus.Image = Properties.Resources.ambulance;
                    Ambulance mda = new Ambulance();
                    if(mda.savelives())
                        emergency.Visible = true;
                    mda.makeNoise();
                        break;
                case 2:
                    tempbus.Image = Properties.Resources.TruckWhite;
                    whiteTrack t = new whiteTrack();
                    emergency.Visible = false;
                        break;
                case 3:
                    tempbus.Image = Properties.Resources.TruckBlue;
                    emergency.Visible = false;
                    break;
                    
            }
            
            tempbus.Top = carPosition.Next(50, 225) * -1;

            if ((string)tempbus.Tag == "moveLeft")
            {
                tempbus.Left = carPosition.Next(52, 100);
            }
            if ((string)tempbus.Tag == "moveRight")
            {
                tempbus.Left = carPosition.Next(200, 400);
            }

        }

        private void gameOver()
        {
            explosionSound();
            Timer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-3, 4);
            explosion.BackColor = Color.Transparent;
            start.Enabled = true;

            Random rand2 = new Random();
            int fixPrice = rand2.Next(10000, 30000);
            txtPrice.Text = "FixPrice: " + fixPrice;


   
            if (maxRecord < Score)
            {
                maxRecord = Score;
                txtRecord.Text = "record: " + (maxRecord - 1);
                medal.Visible = true;
            }

        }
       public bool isEqual(PictureBox v1,Bitmap v2)
        {
            var array1 = ImageToByteArray(v1.Image);
            var array2 = ImageToByteArray(v2);

            bool isSame = array1.Length == array2.Length;
            if (isSame)
            {
                for (int index = 0; index < array1.Length; index++)
                    if (array1[index] != array2[index])
                    {
                        isSame = false;
                        break;
                    }
            }
            return isSame;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void car2_Click(object sender, EventArgs e)
        {

        }

        private void medal_Click(object sender, EventArgs e)
        {

        }

        private void txtRecord_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtscore_Click(object sender, EventArgs e)
        {

        }

   

        private void Honk_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void roadTrack1_Click(object sender, EventArgs e)
        {

        }

        private void VehicleGame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, maxRecord);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                maxRecord = (int)binaryFormatter.Deserialize(stream);
                pictureBox1.Invalidate();
                txtRecord.Text = "record: " + (maxRecord - 1);
            }

        }


        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void explosionSound()
        {
            System.Media.SoundPlayer playcrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playcrash.Play();
        }
        
    }
}
  


      
