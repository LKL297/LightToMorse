using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace HCIMorseProject
{


    public partial class Form1 : Form
    {
        SerialPort sp;

        const int LeWayMilli = 100;


        //set light values
        int low = 0;
        int high = 0;
        bool selectedSetting = false;
        int activated = 0;
        //end set light values

        //set dot time
        bool dotSet = false;
        long dotMilliSeconds = 0;
        bool dashSet = false;
        long dashMilliSeconds = 0;
        //end set dot time
        //dash time = 3 times dot time

        bool isClosed = false;
        Stopwatch stw = new Stopwatch();
        Stopwatch idleTime = new Stopwatch();
        Dictionary<string, string> morseMap;
        string finalMorse = "";
        string tempMorse = "";
        string finalWord = "";
        public Form1()
        {
            InitializeComponent();
            sp = new SerialPort();
            sp.PortName = "COM4";
            sp.BaudRate = 9600;
            sp.ReadTimeout = 500;
            sp.DataReceived += Sp_DataReceived;
            
            try
            {
                sp.Open();
            }
            catch { }

            morseMap = CreateMorseMap();
        }

       

        private Dictionary<string, string> CreateMorseMap()
        {
            StreamReader sr = new StreamReader("morse.txt");
            Dictionary<string, string> mMap = new Dictionary<string, string>();
            
            while(!sr.EndOfStream)
            {
                string[] tokens = sr.ReadLine().Split(' ');
               
                mMap.Add(tokens[1],tokens[0]);
            }

            sr.Close();
            return mMap;
        }


        private void TriggerTime()
        {
            
            while (idleTime.IsRunning)
            {
                labelTriggerTime.Invoke(new MethodInvoker(
                    delegate
                    {
                        labelTriggerTime.Text = idleTime.ElapsedMilliseconds.ToString();
                    }
                    ));
                
            }
            idleTime.Stop();
        }
        Thread t;
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sender is SerialPort)
            {
                SerialPort s = sender as SerialPort;
                textBox1.Invoke(new MethodInvoker(
                    delegate
                    {
                        long previousTime = idleTime.ElapsedMilliseconds;
                        //do detection for morse input if light is off

                        idleTime.Reset();
                        idleTime.Start();
                        if(t != null)t.Abort();
                        t = new Thread(TriggerTime);
                        t.Start();
                        
                        string line = s.ReadLine();
                        string[] tokens = line.Split(' ');
                        if (tokens[0] == "UPDATE") return;//dont process updates
                        textBox1.Text = tokens[1];
                        checkBox1.Checked = tokens[0] == "ON";
                        
                        if (selectedSetting)//set the high/low labels based on inputs
                        {
                            //this need to get 3 of each value and then average them so this mehtod will trigger 6 times total
                            if (tokens[0] == "ON")
                            {
                                high += int.Parse(tokens[1]);
                            }
                            else
                            {
                                low += int.Parse(tokens[1]);
                                activated++;
                            }


                            labelOutOf.Text = activated + "/3";
                            if (activated > 2)
                            {
                                selectedSetting = false;
                                activated = 0;
                                low = low / 3;
                                high = high / 3;
                                labelHigh.Text = high.ToString();
                                labelLow.Text = low.ToString();
                                //send low and high value to arduino to use
                                sp.WriteLine("SH:"+high);
                                sp.WriteLine("SL:" + low);

                            }


                        }//selectedsetting if
                        else if (dotSet ||dashSet)
                        {
                            if (checkBox1.Checked)
                            {
                                stw.Reset();
                                stw.Start();
                            }
                            else
                            {
                                dotMilliSeconds = stw.ElapsedMilliseconds;
                                if(dotSet)labelDotTime.Text = stw.ElapsedMilliseconds.ToString() + " MilliSeconds";
                                else labelDashTime.Text = stw.ElapsedMilliseconds.ToString() + " MilliSeconds";
                                stw.Stop();
                                dotSet = false;
                            }
                        }
                        else
                        {
                            //do actual morse detection here.
                            //use preiousTime and checkbox1.checked for if do stuff with values
                            //!checked = off, off for dot time is after letter
                            //           off for dot time *3 is space
                            //checked = true, time is just rough dot time = dot, rought dot *3 = dash
                            if (checkBox1.Checked)//previousTime = a wait time
                            {
                                bool dot = DetectDot(previousTime);
                                bool dash = DetectDash(previousTime);
                                if (dash)
                                {
                                    //is a space
                                    labelDetectedLetter.Text = "Space";
                                    finalMorse += "   ";//three spaces for actual space
                                    // do detect letter for the string and add to a final string
                                    //finalWord += morseMap[tempMorse];


                                    tempMorse += " ";//then reset the temp morse holder
                                }
                                else if (dot)
                                {
                                    //end a letter
                                    labelDetectedLetter.Text = "EndLetter";
                                    finalMorse += " ";//space between morse letters
                                    
                                }
                               
                            }
                            else//input - the previous value was an input
                            {
                                bool dot = DetectDot(previousTime);
                                bool dash = DetectDash(previousTime);
                                if (dash)
                                {
                                    labelDetectedLetter.Text = "Dash";
                                    finalMorse += "-";
                                    tempMorse += "-";
                                }
                                else if (dot)
                                {
                                    labelDetectedLetter.Text = "Dot";
                                    finalMorse += ".";
                                    tempMorse += ".";
                                }
                                
                                
                                
                            }
                            labelDetectedMorse.Text = finalMorse;
                            labelDetectedWord.Text = finalWord;
                        }//else
                    }//delesgate
                ));



            }

        }
        private bool DetectDot(long prev)
        {
            if (dotMilliSeconds - prev < LeWayMilli && dotMilliSeconds - prev > -LeWayMilli)
            {
                return true;
            }
            else return false;
        }
        private bool DetectDash(long prev)
        {
            if (dotMilliSeconds*3 - prev < LeWayMilli && dotMilliSeconds*3 - prev > -LeWayMilli)
            {
                return true;
            }
            else return false;
        }


        private bool DetectEnd(long prev)
        {
            if (dotMilliSeconds - prev > LeWayMilli - 2*LeWayMilli)
            {
                return true;
            }
            else return false;
        }
        private bool DetectSpace(long prev)
        {
            if (dotMilliSeconds * 3 - prev > LeWayMilli - 2*LeWayMilli)
            {
                return true;
            }
            else return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MorseIntoView();
        }

        private void MorseIntoView()
        {
            dataView.DefaultCellStyle.Font = new Font("Arial",15);
            dataView.Columns.Add("letter", "Letter");
            dataView.Columns[0].Width = 50;
            dataView.Columns.Add("morse", "Morse");
            
            int count = 0;
            while(count < morseMap.Count)
            {
                int rowID = dataView.Rows.Add();
                DataGridViewRow row = dataView.Rows[rowID];
                row.Cells["letter"].Value = morseMap.ElementAt(count).Value;
                row.Cells["morse"].Value = morseMap.ElementAt(count).Key;
                count++;
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
            if (sp.IsOpen)
            {
                sp.Close();
            }
            if (t != null && t.IsAlive) t.Abort();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //set light values             
            high = 0;
            low = 0;
            selectedSetting = true;
            dotSet = false;
            labelOutOf.Text = "0/3";
        }

        private void ButtonDTTime_Click(object sender, EventArgs e)
        {
            selectedSetting = false;
            dotSet = true;
            dashSet = false;
            dotMilliSeconds = 0;
        }

        private void ButtonDash_Click(object sender, EventArgs e)
        {
            selectedSetting = false;
            dashSet = true;
            dotSet = false;
            dashMilliSeconds = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string time = textBoxTimeSet.Text;
            dotMilliSeconds = long.Parse(time);
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LabelHigh_Click(object sender, EventArgs e)
        {

        }

        private void LabelLow_Click(object sender, EventArgs e)
        {

        }

        private void LabelOutOf_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            finalMorse = "";
            finalWord = "";
            tempMorse = "";
            labelDetectedWord.Text = "";
            labelDetectedMorse.Text = "";
        }

        private void ButtonWordMake_Click(object sender, EventArgs e)
        {
            string[] tokens = tempMorse.Split(' ');
            for(int i = 0; i < tokens.Length; i++)
            {
                finalWord += morseMap[tokens[i]];
            }
            labelDetectedWord.Text = finalWord;
            t.Abort();
            labelTriggerTime.Text = "0";
        }
    }
}
