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
using Excel = Microsoft.Office.Interop.Excel;

namespace BMS_Control_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string data;
        private int row = 1, column = 1, cycleCounter = 0, cycle = 0, coolDownTime = 0, tick = 0, currentBatteryState = 0, previousBatteryState = 0;
        Boolean cycleCounterEnabled = false, coolDownEnabled = false;
        Excel.Application ExcellApp = new Excel.Application();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            ExcellApp.Workbooks.Add();
            ExcellApp.Visible = false;

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displaydata));
        }

        private void displaydata(object sender, EventArgs e)
        {
            string[] value = data.Split('/');
            voltage_label.Text = "VOLTAGE " + value[1];
            current_label.Text = "CURRENT " + value[2];
            temprature_label.Text = "TEMPRATURE " + value[3];

            if (savedata_checkbox.Checked == true)
            {
                ExcellApp.Cells[row, column] = value[0];
                row++;
                ExcellApp.Cells[row, column] = value[1];
                row++;
                ExcellApp.Cells[row, column] = value[2];
                row++;
                ExcellApp.Cells[row, column] = value[3];
                row = 1; column++;
            }

            if (currentBatteryState != int.Parse(value[0]))
            {
                previousBatteryState = currentBatteryState;
                currentBatteryState = int.Parse(value[0]);

                if (cycleCounterEnabled == true)
                {
                    cycleCounter++;
                    cycle_counter_label.Text = "Cycle counter: " + cycleCounter + "/" + cycle;
                    if (cycle == cycleCounter * 2)
                    {
                        serialPort1.Write("idle");
                    }
                }
                else
                {
                    cycle_counter_label.Text = "Cycle counter: " + cycleCounter;
                }

                if (coolDownEnabled == true)
                {
                    timer1.Enabled = true;
                }
                else
                {
                    if (previousBatteryState == 1)
                    {
                        serialPort1.Write("charge");
                    }
                    else if (previousBatteryState == 2)
                    {
                        serialPort1.Write("discharge");
                    }
                }
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                start_button.Enabled = false;
                stop_button.Enabled = true;
                connection_state_label.Text = "CONNECTED";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                start_button.Enabled = true;
                stop_button.Enabled = false;
                connection_state_label.Text = "DISCONNECTED";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void charge_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen == true)
                {
                    serialPort1.Write("charge");
                    battery_state_label.Text = "Battery Charging...";
                    discharge_button.Enabled = true;
                    idle_button.Enabled = true;
                    charge_button.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }

        private void cycle_set_button_Click(object sender, EventArgs e)
        {
            cycle = int.Parse(cycle_textBox.Text);
            cycle_counter_label.Text = "Cycle counter: " + cycleCounter + "/" + cycle;
            cycleCounterEnabled = true;

        }

        private void cycle_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void coolDown_button_Click(object sender, EventArgs e)
        {
            coolDownTime = int.Parse(cycle_textBox.Text);
            coolDownEnabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            if(tick == coolDownTime)
            {
                timer1.Enabled = false;
                if (previousBatteryState == 1)
                {
                    serialPort1.Write("charge");
                }
                else if (previousBatteryState == 2)
                {
                    serialPort1.Write("discharge");
                }
            }
        }

        private void coolDownTime_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void discharge_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Write("discharge");
                    battery_state_label.Text = "Battery Discharging...";
                    discharge_button.Enabled = false;
                    idle_button.Enabled = true;
                    charge_button.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }

        }

        private void idle_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Write("idle");
                    battery_state_label.Text = "Battery State Idle...";
                    discharge_button.Enabled = true;
                    idle_button.Enabled = false;
                    charge_button.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }

        private void saveData_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(savedata_checkbox.Checked == true) {
                ExcellApp.Visible= true;
            }
        }

        }
}
