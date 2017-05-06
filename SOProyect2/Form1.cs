using SOProyect2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOProyect2
{
    public partial class Form1 : Form
    {
        ThreadDriver ThreadDriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ThreadDriver = new ThreadDriver();
        }

        private void NUDConsumidores_ValueChanged(object sender, EventArgs e)
        {
            clearDataGridInfoConsumidores();
            addInfoDataGridInfoConsumidores((int)NUDConsumidores.Value);
        }

        private void clearDataGridInfoConsumidores()
        {
            dgvInfoConsumidores.Rows.Clear();
        }
        
        private void addInfoDataGridInfoConsumidores(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                dgvInfoConsumidores.Rows.Insert(i, (i+1).ToString());
            }
        }

        private List<int> getDataPriority()
        {
            List<int> prioritys = new List<int>();
            for (int i = 0; i < dgvInfoConsumidores.RowCount; i++)
            {
                int priority = 0;
                if(!int.TryParse(dgvInfoConsumidores.Rows[i].Cells[1].ToString(),out priority))
                {
                    throw new Exception("Error: La fila:" + i + " de la tabla de prioridades de consumidores no es un número ENTERO.");
                }
                prioritys.Add(priority);
            }
            return prioritys;
        }

        private void actualizarThreadDriver()
        {
            this.lbCantConsumidores.Text = ThreadDriver.getActiveConsumersInt() + " Consumidores";
            this.lbCantProductores.Text = ThreadDriver.getActiveProducersInt() + " Productores";
            if (!ThreadDriver.Balanced)
            {
                this.lbBalanceado.Text = "NO BALANCEADO";
            }
            else
            {
                this.lbBalanceado.Text = "BALANCEADO";
                this.pnBalanced.Enabled = true;
            }
        }

        private void btnBalancear_Click(object sender, EventArgs e)
        {
            this.pnBalanced.Enabled = false;
            int countMaxProducers = (int)this.NUDProductores.Value;
            int countMaxConsumers = (int)this.NUDConsumidores.Value;
            try
            {
                List<int> prioritys = getDataPriority();
                this.ThreadDriver.setSheduler(countMaxProducers, countMaxConsumers, prioritys);
            }
            catch (Exception ex)
            {
                this.pnBalanced.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            actualizarThreadDriver();
        }

        private void btnTitleEmpezar_Click(object sender, EventArgs e)
        {
            int countTransations = (int)this.NUDTitleTransations.Value;
            this.ThreadDriver.createScheduler(countTransations);
            this.pnTitle.Enabled = false;
            tabControl1.Enabled = true;
            this.timerActualizar.Start();
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                ExecutorQuery executor = new ExecutorQuery(this.tbProduccionOrigen.Text, this.tbProduccionDestino.Text,(int)NUDProduccionRegistros.Value, Enum.SQLExecutor.insert);
                this.ThreadDriver.quequeProduce(executor);
                ThreadStart ts = new ThreadStart(this.ThreadDriver.activeProducer);
                Thread thread = new Thread(ts);
                thread.Start();
                MessageBox.Show("Se ha insertado la Producción en espera");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                ExecutorQuery executor = new ExecutorQuery(this.tbProduccionOrigen.Text, this.tbProduccionDestino.Text, (int)NUDProduccionRegistros.Value, Enum.SQLExecutor.delete);
                this.ThreadDriver.quequeProduce(executor);
                ThreadStart ts = new ThreadStart(this.ThreadDriver.activeProducer);
                Thread thread = new Thread(ts);
                thread.Start();
                MessageBox.Show("Se ha insertado la Producción en espera");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
